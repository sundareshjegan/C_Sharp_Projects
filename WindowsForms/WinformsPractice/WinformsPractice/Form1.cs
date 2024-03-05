using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenAI_API;
using OpenAI_API.Completions;
using MySql.Data.MySqlClient;
using System.Data;

namespace WinformsPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DBConnect();
            //GenerateAsync();
        }
        private async Task GenerateAsync()
        {
            var openAiApiKey = "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"; // Replace with your OpenAI API key

            APIAuthentication aPIAuthentication = new APIAuthentication(openAiApiKey);
            OpenAIAPI openAiApi = new OpenAIAPI(aPIAuthentication);


            try
            {
                string prompt = "Once upon a time";
                string model = "gpt-3.5-turbo";
                int maxTokens = 100;

                var completionRequest = new CompletionRequest
                {
                    Prompt = prompt,
                    Model = model,
                    MaxTokens = maxTokens
                };

                var completionResult = await openAiApi.Completions.CreateCompletionAsync(completionRequest);
                var generatedText = completionResult.Completions[0].Text; //completionResult.Choices[0].Text.Trim();

                Console.WriteLine("Generated text:");
                Console.WriteLine(generatedText);
                MessageBox.Show(generatedText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        

        private void DBConnect()
        {
            string server = "localhost";
            string database = "practice";
            string user = "root";
            string password = "$Ss2606sS$";

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = server,
                Database = database,
                UserID = user,
                Password = password
            };

            string connectionString = builder.ConnectionString;

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT * FROM student";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    //string result = "";
                    //while (reader.Read())
                    //{
                    //    int id = reader.GetInt32(0);
                    //    string name = reader.GetString(1);
                    //    int age = reader.GetInt32(2);

                    //    result += $"ID: {id}, Name: {name}, Age: {age}\n--------------------------------------------\n";
                    //}
                    //resultLabel.Text = (result);
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    displayTable.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
