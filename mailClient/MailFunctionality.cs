using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MimeKit;


namespace mailClient
{
    internal class MailFunctionality
    {
        //Checks if the email is valid by connectid to Email server with Imap
        public bool LogIn(string Email, string Password, string Server)
        {

            using (var client = new ImapClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect(Server, 993, true);
                client.Authenticate(Email, Password);


                if (client.IsAuthenticated == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //Sending Using MimeKit and SMTP
        public void SendMail(string Name, string Email, string Password, string Server, string To, string Subject, string Body)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(Name, Email));
            message.To.Add(new MailboxAddress("", To));
            message.Subject = Subject;
            message.Body = new TextPart("plain")
            {
                Text = Body
            };

            using (var client = new SmtpClient())
            {
                // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect(Server, 587, false);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate(Email, Password);

                client.Send(message);
                client.Disconnect(true);
            }
        }


        //Recieve Email using Imap
        


    }
}
