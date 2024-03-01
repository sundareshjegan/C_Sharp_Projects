using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;

            MailAddress from = new MailAddress("sundareshjegan@outlook.com", "[Sundareshwaran. J]");
            MailAddress to = new MailAddress("sundareshjegan@gmail.com", "SUNDARESHWARAN JEGANATHAN");

            MailMessage message = new MailMessage(from, to);
            message.Body = "This is a test e-mail message sent using gmail as a relay server";
            message.Subject = "Gmail test email with SSL and Credentials";

            NetworkCredential myCreds = new NetworkCredential("sundareshjegan@outlook.com", "Sundar2606$","");
            client.Credentials = myCreds;
            client.EnableSsl = false;
            try
            {
                client.Send(message);
                MessageBox.Show("Email sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception is:" + ex.ToString());
            }
        }

        private void test_Click(object sender, EventArgs e)
        {
            try
            {

                //Sending the email.
                //Now we must create a new Smtp client to send our email.

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);   //smtp.gmail.com // For Gmail
                                                                            //smtp.live.com // Windows live / Hotmail
                                                                            //smtp.mail.yahoo.com // Yahoo
                                                                            //smtp.aim.com // AIM
                                                                            //my.inbox.com // Inbox


                //Authentication.
                //This is where the valid email account comes into play. You must have a valid email account(with password) to give our program a place to send the mail from.

                NetworkCredential cred = new NetworkCredential("whitehatsundar@gmail.com", "$Ss2606sS$");

                //To send an email we must first create a new mailMessage(an email) to send.
                MailMessage Msg = new MailMessage();

                // Sender e-mail address.
                Msg.From = new MailAddress("whitehatsundar@gmail.com");//Nothing But Above Credentials or your credentials (*******@gmail.com)

                // Recipient e-mail address.
                Msg.To.Add("whitehatsundar@gmail.com");

                // Assign the subject of our message.
                Msg.Subject = "Subject";

                // Create the content(body) of our message.
                Msg.Body = "Body Content";

                // Send our account login details to the client.
                client.Credentials = cred;

                //Enabling SSL(Secure Sockets Layer, encyription) is reqiured by most email providers to send mail
                client.EnableSsl = true;

                //Confirmation After Click the Button
                label5.Text = "Mail Sended Succesfully";

                // Send our email.
                client.Send(Msg);



            }
            catch(Exception ex)
            {
                // If Mail Doesnt Send Error Mesage Will Be Displayed
                label5.Text = ex.Message;
            }
        }
        protected void SendEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc, List<MailAddress> _bcc = null)
        {
            string Text = "";
            SmtpClient mailClient = new SmtpClient("Mailhost");
            MailMessage msgMail;
            Text = "Stuff";
            msgMail = new MailMessage();
            msgMail.From = _from;
            msgMail.To.Add(_to);
            foreach (MailAddress addr in _cc)
            {
                msgMail.CC.Add(addr);
            }
            if (_bcc != null)
            {
                foreach (MailAddress addr in _bcc)
                {
                    msgMail.Bcc.Add(addr);
                }
            }
            msgMail.Subject = _subject;
            msgMail.Body = Text;
            msgMail.IsBodyHtml = true;
            mailClient.Send(msgMail);
            msgMail.Dispose();
        }
    }
}
