using System;
using System.Windows.Forms;
using HalconDotNet;
using HalconRegionEditor;
using HalconEditorTools;
using HOS = HalconDotNet.HOperatorSet;

namespace HalconPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            halconWindowControl = new HalconWindowControl()
            {
                Dock = DockStyle.Fill
            };
            region.SetHalconWindow(halconWindowControl);
            region.SetListLimit("Rect", 1, ListLimitType.OverWrite);
            region.RegionCreated += Region_RegionCreated;
            ImagePanel.Controls.Add(halconWindowControl);

            engine.SetProcedurePath(@"D:\Sundareshwaran\Resources\Halcon\Base_Script_For_Training_H20\Scripts");
            procedure = new HDevProcedure("Threshold_Cropped_Image");
        }

        private void Region_RegionCreated(RegionEditor sender, string list, EditorRegionData region)
        {
            
        }

        private HObject Image;
        private HTuple EmptyTuple = new HTuple();
        private HalconWindowControl halconWindowControl;
        RegionEditor region = new RegionEditor()
        {
            DisplayText = true,
            DisplayID = true,
            BoxInfo = {DisplayBox = true}
        };
        NormalRectangle rectangle = new NormalRectangle()
        {
            ID = "1",
            DisplayText = true,
        };

        HDevEngine engine = new HDevEngine();
        HDevProcedure procedure;


        public void MainScript()
        {
            //HOS.SetSystem("clip_region", "false");
            HOS.GenRectangle1(out HObject CropRegion, rectangle.TopLeftPoint.Y, rectangle.TopLeftPoint.X, rectangle.BottomRightPoint.Y, rectangle.BottomRightPoint.X);
            //HOS.GenRectangle1(out HObject CropRegion, 500,500,1000,1000);
            HTuple Orientation = 0, PaddingWidth = 0.5, ProfileName = "Crop1";

            HOS.CreateDict(out HTuple ModelData);
            HOS.CreateDict(out HTuple RunTimeSettings);
            HOS.CreateDict(out HTuple ParentResultData);
            HOS.CreateDict(out HTuple RuntimeTranferData);
            HOS.CreateDict(out HTuple CompositeData);

            HOS.SetDictTuple(CompositeData, "EmpWidth", 5);
            HOS.SetDictTuple(CompositeData, "EmpHeight", 5);
            HOS.SetDictTuple(CompositeData, "Iteration", 1);
            HOS.SetDictTuple(CompositeData, "ProfileName", ProfileName);

            HOS.SetDictObject(CropRegion, ModelData, "CropRegion");
            HOS.SetDictTuple(ModelData, "Orientation", (int)tb.Value);
            HOS.SetDictTuple(RunTimeSettings, "PaddingWidth", PaddingWidth / 0.4);
            HOS.SetDictTuple(RunTimeSettings, "CompositeData", CompositeData);

            ThresholdCroppedImage(Image, ModelData, RunTimeSettings, ParentResultData, RuntimeTranferData,
                out HTuple UserResultData, out HTuple TransferResultData, out HTuple LogData);

            HOS.GetDictTuple(UserResultData, "Textual", out HTuple Textual);
            HOS.GetDictTuple(Textual, "Result", out HTuple Result);
            HOS.GetDictTuple(Result, "IsSuccess", out HTuple IsSuccess);

            if (IsSuccess == 1)
            {
                HOS.GetDictTuple(UserResultData, "UserDisplayRegion", out HTuple UserDisplayRegion);
                HOS.GetDictTuple(UserResultData, "UserDisplayRegionColor", out HTuple UserDisplayRegionColor);
                HOS.GetDictTuple(UserResultData, "Graphical", out HTuple Graphical);

                for (int i = 1; i < UserDisplayRegion.Length ; i++)
                {
                    HOS.GetDictObject(out HObject Object, Graphical, UserDisplayRegion[i]);
                }
                HOS.GetDictObject(out HObject ProcessedImage, TransferResultData, "ProcessedImage");

                if (ProcessedImage.IsInitialized())
                    //halconWindowControl.DisplayImage(new HImage(ProcessedImage));
                    LoadImage(new HImage(ProcessedImage));
            }
        }

        private void ScriptWithDevEngine()
        {
            HOS.GenRectangle1(out HObject CropRegion, rectangle.TopLeftPoint.Y, rectangle.TopLeftPoint.X, rectangle.BottomRightPoint.Y, rectangle.BottomRightPoint.X);
            //HOS.GenRectangle1(out HObject CropRegion, 500,500,1000,1000);
            HTuple Orientation = 0, PaddingWidth = 0.5, ProfileName = "Crop1";

            HOS.CreateDict(out HTuple ModelData);
            HOS.CreateDict(out HTuple RunTimeSettings);
            HOS.CreateDict(out HTuple ParentResultData);
            HOS.CreateDict(out HTuple RuntimeTranferData);
            HOS.CreateDict(out HTuple CompositeData);

            HOS.SetDictTuple(CompositeData, "EmpWidth", 5);
            HOS.SetDictTuple(CompositeData, "EmpHeight", 5);
            HOS.SetDictTuple(CompositeData, "Iteration", 1);
            HOS.SetDictTuple(CompositeData, "ProfileName", ProfileName);

            HOS.SetDictObject(CropRegion, ModelData, "CropRegion");
            HOS.SetDictTuple(ModelData, "Orientation", 5);
            HOS.SetDictTuple(RunTimeSettings, "PaddingWidth", PaddingWidth / 0.4);
            HOS.SetDictTuple(RunTimeSettings, "CompositeData", CompositeData);

            #region Engine call Part
            HTuple UserResultData, TransferResultData, LogData;

            HDevProcedureCall procedureCall = procedure.CreateCall();
            procedureCall.SetInputIconicParamObject("Image", Image);
            procedureCall.SetInputCtrlParamTuple("ModelData", ModelData);
            procedureCall.SetInputCtrlParamTuple("RunTimeSettings", RunTimeSettings);
            procedureCall.SetInputCtrlParamTuple("ParentResultData", ParentResultData);
            procedureCall.SetInputCtrlParamTuple("RunTimeTransferData", RuntimeTranferData);

            //engine.StartDebugServer();
            //procedureCall.SetWaitForDebugConnection(true);
            procedureCall.Execute();
            //engine.StopDebugServer();
            UserResultData = procedureCall.GetOutputCtrlParamTuple("UserResultData");
            TransferResultData = procedureCall.GetOutputCtrlParamTuple("TransferResultData");
            LogData = procedureCall.GetOutputCtrlParamTuple("LogData");

            HOS.GetDictTuple(UserResultData, "Textual", out HTuple Textual);
            HOS.GetDictTuple(Textual, "Result", out HTuple Result);
            HOS.GetDictTuple(Result, "IsSuccess", out HTuple IsSuccess);
            #endregion

            if (IsSuccess == 1)
            {
                HOS.GetDictTuple(UserResultData, "UserDisplayRegion", out HTuple UserDisplayRegion);
                HOS.GetDictTuple(UserResultData, "UserDisplayRegionColor", out HTuple UserDisplayRegionColor);
                HOS.GetDictTuple(UserResultData, "Graphical", out HTuple Graphical);

                for (int i = 0; i < UserDisplayRegion.Length - 1; i++)
                {
                    HOS.GetDictObject(out HObject Object, Graphical, UserDisplayRegion[i]);
                }
                HOS.GetDictObject(out HObject ProcessedImage, TransferResultData, "ProcessedImage");

                if (ProcessedImage.IsInitialized())
                    halconWindowControl.DisplayImage(new HImage(ProcessedImage));
            }
        }

        private void ThresholdCroppedImage(HObject image, HTuple modelData, HTuple runTimeSettings, HTuple parentResultData, HTuple runtimeTranferData, out HTuple userResultData, out HTuple transferResultData, out HTuple logData)
        {
            HOS.CreateDict(out userResultData);
            HOS.CreateDict(out transferResultData);
            HOS.CreateDict(out HTuple Graphical);
            HOS.CreateDict(out HTuple Textual);
            HOS.CreateDict(out HTuple Result);
            HOS.CreateDict(out logData);

            HOS.GenEmptyObj(out HObject CroppingRegion);
            HOS.HomMat2dIdentity(out HTuple HomMat2DIdentity);

            HTuple Orientation = 90, PaddingWidth = 0, IsSuccess = 1, RegionFeatures = 0;
            HTuple Error = new HTuple();
            HTuple ErrorMessage = new HTuple();
            HTuple UserDisplayRegion = new HTuple();
            HTuple UserDisplayRegionColor = new HTuple();

            HObject ImagePart = new HObject();
            HObject GrayImage = new HImage();
            HObject RegionAffineTrans = new HObject();
            HObject ImageRotate = new HObject();

            HOS.SetDictTuple(userResultData, "Graphical", Graphical);
            HOS.SetDictTuple(Textual, "Result", Result);
            HOS.SetDictTuple(userResultData, "Textual", Textual);

            HOS.GetDictObject(out CroppingRegion, modelData, "CropRegion");
            HOS.GetDictTuple(modelData, "Orientation", out Orientation);
            HOS.GetDictTuple(runTimeSettings, "PaddingWidth", out PaddingWidth);
            HOS.GetDictTuple(runTimeSettings, "CompositeData", out HTuple CompositeData);

            try
            {
                HOS.SmallestRectangle1(CroppingRegion, out HTuple Row1, out HTuple Column1, out HTuple Row2, out HTuple Column2);
                HOS.CropRectangle1(Image, out ImagePart, Row1 + PaddingWidth, Column1 + PaddingWidth, Row2 + PaddingWidth, Column2 + PaddingWidth);
                HOS.AreaCenter(CroppingRegion, out HTuple Area, out HTuple Row, out HTuple Column);

                HOS.CountChannels(ImagePart, out HTuple Channels);

                if (Channels == 3)
                {
                    HOS.Rgb1ToGray(ImagePart, out GrayImage);
                }

                HOS.GetDictTuple(CompositeData, "EmpWidth", out HTuple EmpWidth);
                HOS.GetDictTuple(CompositeData, "EmpHeight", out HTuple EmpHeight);
                HOS.GetDictTuple(CompositeData, "Iteration", out HTuple Iteration);
                HOS.Emphasize(GrayImage, out HObject ImageEmphasize, EmpWidth, EmpHeight, Iteration);
                HOS.RotateImage(ImageEmphasize, out ImageRotate, Orientation, "constant");

                HOS.LocalThreshold(ImageEmphasize, out HObject Region, "adapted_std_deviation", "dark", EmptyTuple, EmptyTuple);
                HOS.VectorAngleToRigid(0, 0, 0, Row1, Column1, 0, out HTuple HomMat2D);
                HOS.AffineTransRegion(Region, out RegionAffineTrans, HomMat2D, "nearest_neighbor");
            }
            catch (Exception e)
            {
                IsSuccess = 0;
                Error.Append("Crop Image");
                ErrorMessage.Append("Unable to Process the Image");

            }
            
            UserDisplayRegion.Append("CroppingRegion");
            UserDisplayRegion.Append("ThresholdRegion");
            UserDisplayRegionColor.Append("Red");
            UserDisplayRegionColor.Append("Green");

            //UserDisplayRegion = "CroppingRegion " + "ThresholdRegion";
            //UserDisplayRegionColor = "Red" + "Green";

            HOS.SetDictObject(ImagePart, Graphical, "CroppedImage");
            HOS.SetDictObject(CroppingRegion, Graphical, "CroppingRegion");
            if (RegionAffineTrans.IsInitialized())
                HOS.SetDictObject(RegionAffineTrans, Graphical, "ThresholdRegion");

            HOS.SetDictObject(ImageRotate, transferResultData, "ProcessedImage");
            HOS.GetDictTuple(CompositeData, "ProfileName", out HTuple ProfileName);
            HOS.SetDictTuple(Textual, "Profile", ProfileName);
            HOS.SetDictTuple(userResultData, "UserDisplayRegion", UserDisplayRegion);
            HOS.SetDictTuple(userResultData, "UserDisplayRegionColor", UserDisplayRegionColor);

            HOS.SetDictTuple(Result, "IsSuccess", IsSuccess);
            HOS.SetDictTuple(Result, "Error", Error);
            HOS.SetDictTuple(Result, "ErrorMessage", ErrorMessage);
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            HOS.ReadImage(out Image, @"D:\Sundareshwaran\Resources\Halcon\Base_Script_For_Training_H20\Image\shelby.jpg");
            LoadImage(new HImage(Image));
            //region.DisplayImage(new HImage(Image));
            //region.SetActiveTool("Rect", rectangle);
            //region.SetActiveTool("Rect", rectangle1);
        }

        private void LoadImage(HImage img)
        {
            region.DisplayImage(img);
            region.SetActiveTool("Rect", rectangle);
        }

        private void CropBtn_Click(object sender, EventArgs e)
        {
            MainScript();
            region.DeleteRegion("Rect", "1");
        }

        private void cropImageEngine_Click(object sender, EventArgs e)
        {
            ScriptWithDevEngine();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Image?.Dispose();
            region.RemoveHalconWindow();
            region.DisposeAllLists();
        }
    }
}
