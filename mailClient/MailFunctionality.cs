using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net;
using Newtonsoft.Json;



using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Org.BouncyCastle.Asn1.X509;


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

                //return true if the email is valid
                return client.IsAuthenticated;
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

            //attachment
            //message.attachments.add(new mimepart("application", "octet-stream")
            //{
            //    content = new mimecontent(new memorystream(file.readallbytes("c:\\users\\public\\pictures\\sample pictures\\desert.jpg"))),
            //    contentdisposition = new contentdisposition(contentdisposition.attachment),
            //    contenttransferencoding = contentencoding.base64,
            //    filename = path.getfilename("c:\\users\\public\\pictures\\sample pictures\\desert.jpg")
            //});
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


        public async void RetrieveEmailToJson(string Email , string Password, string Server)
        {
            using (var client = new ImapClient())
            {
                
                await client.ConnectAsync(Server, 993, true);
                await client.AuthenticateAsync(Email, Password);

                //retrieve last email from server
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                

                Console.WriteLine("Total messages: {0}", inbox.Count);
                Console.WriteLine("Recent messages: {0}", inbox.Recent);
               
                
                for(int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    Console.WriteLine("Subject: {0}", message.Body);

                }


                //foreach (var message in inbox.fetch(0, -1, messagesummaryitems.full | messagesummaryitems.uniqueid))
                //{
                //    var email = new emaillistdata();
                //    email.from = message.envelope.from.tostring();
                //    email.subject = message.envelope.subject.tostring();
                //    email.date = message.date.tostring();


                //    email.to = message.envelope.to.tostring();
                //    email.cc = message.envelope.cc.tostring();
                //    email.bcc = message.envelope.bcc.tostring();


                //    string jsonfile = jsonconvert.serializeobject(email);
                //    string path = @"c:\users\askvo\documents\emailfolder\" + message.envelope.subject.tostring() + ".json";

                //    if (file.exists(path))
                //    {
                //        file.delete(path);
                //        using (var tw = new streamwriter(path, true))
                //        {
                //            tw.writeline(jsonfile.tostring());
                //            tw.close();
                //        }

                //    }
                //    else if (!file.exists(path))
                //    {
                //        using (var tw = new streamwriter(path, true))
                //        {
                //            tw.writeline(jsonfile.tostring());
                //            tw.close();
                //        }
                //    }

                //}

                client.Disconnect(true);
                
               
            }
        }

        public static void DownloadBodyParts(string Email, string Password, string Server)
        {
            using (var client = new ImapClient())
            {
                client.Connect(Server, 993, true);
                client.Authenticate(Email, Password);

                client.Inbox.Open(FolderAccess.ReadWrite);

                var inbox = client.Inbox;

                // search for messages where the Subject header contains either "MimeKit" or "MailKit"
                //var query = SearchQuery.SubjectContains("MimeKit").Or(SearchQuery.SubjectContains("MailKit"));
                // var uids = client.Inbox.Search(query);

                // fetch summary information for the search results (we will want the UID and the BODYSTRUCTURE
                // of each message so that we can extract the text body and the attachments)

                //var items = client.Inbox.Fetch(uids, MessageSummaryItems.UniqueId | MessageSummaryItems.BodyStructure);

                var items = inbox.Fetch(0, -1, MessageSummaryItems.UniqueId | MessageSummaryItems.BodyStructure);



                
                Console.WriteLine("Total messages: {0}", inbox.Count);
                Console.WriteLine("Recent messages: {0}", inbox.Recent);

                foreach (var item in items)
                {
                    //.AddFlags(uids, MessageFlags.Seen, true);
                    var uid = item.UniqueId;
                    inbox.AddFlags(uid, MessageFlags.Seen, true);
                    // determine a directory to save stuff in
                    var directory = Path.Combine("C:\\Users\\askvo\\Documents\\EmailFolder", item.UniqueId.ToString ());

                    // create the directory
                    Directory.CreateDirectory(directory);

                    // IMessageSummary.TextBody is a convenience property that finds the 'text/plain' body part for us
                    var bodyPart = item.TextBody;

                    // download the 'text/plain' body part
                    var body = (TextPart)client.Inbox.GetBodyPart(item.UniqueId, bodyPart);

                    // TextPart.Text is a convenience property that decodes the content and converts the result to
                    // a string for us
                    var text = body.Text;

                    File.WriteAllText(Path.Combine(directory, "body.txt"), text);

                    // now iterate over all of the attachments and save them to disk
                    foreach (var attachment in item.Attachments)
                    {
                        // download the attachment just like we did with the body
                        var entity = client.Inbox.GetBodyPart(item.UniqueId, attachment);

                        // attachments can be either message/rfc822 parts or regular MIME parts
                        if (entity is MessagePart)
                        {
                            var rfc822 = (MessagePart)entity;

                            var path = Path.Combine(directory, attachment.PartSpecifier + ".eml");

                            rfc822.Message.WriteTo(path);
                        }
                        else
                        {
                            var part = (MimePart)entity;

                            // note: it's possible for this to be null, but most will specify a filename
                            var fileName = part.FileName;

                            var path = Path.Combine(directory, fileName);

                            // decode and save the content to a file
                            using (var stream = File.Create(path))
                                part.Content.DecodeTo(stream);
                        }
                    }
                }
                
                client.Disconnect(true);
            }
        }

        async void RetrieveEmail(string Server, string Email, string Password)
        {
            {
                using (var client = new ImapClient())
                {
                    await client.ConnectAsync(Server, 993, true);
                    await client.AuthenticateAsync(Email, Password);

                   
                }
            }
        }
        

        //Recieve Email using Imap
        async void  RecieveFolders(string Email, string Password, string Server)
        {
            using (var client = new ImapClient())
            {
                client.Connect(Server, 993, true);
                client.Authenticate(Email, Password);

                //retrieve last email from server
                var folders = await client.GetFoldersAsync(new FolderNamespace('.', ""));
                

                
              
                
            }
        }



    }
}
