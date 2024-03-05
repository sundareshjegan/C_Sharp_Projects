using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Threading.Tasks;
using OpenAI_API;

namespace ExpenseTracker
{
    public partial class EmailForm : Form
    {

        public EmailForm()
        {
            InitializeComponent();
        }

        private void OnSendBtnClicked(object sender, EventArgs e)
        {

            MailAddress fromAddress = new MailAddress("whitehatsundar@gmail.com", "Sundareshwaran J");
            MailAddress toAddress = null;

            const string fromPassword = "xpre wkhu tgmh fsyj";
            if (IsValidEmail(toEmailTB.Text))
            {
                toAddress = new MailAddress(toEmailTB.Text, toNameTB.Text);
            }
            else { MessageBox.Show("Invalid Email Address"); }
            
            string subject = subjectTB.Text;
            string body = messageBodyTB.Text;

            try
            {
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress.ToString(), toAddress.ToString())
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                    MessageBox.Show("Sent Successfully..!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static bool IsValidEmail(string email)
        {
            var valid = true;

            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }

            return valid;
        }

    }
}
