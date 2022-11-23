using MailKit;
using MailKit.Net;
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
using System.Text.RegularExpressions;

namespace mailClient
{
    internal class MailFunctionality
    {
    
           



        //Checks if the email is valid by connectid to Email server with Imap
        public bool LogIn(string Email, string Password, string Server)
        {
       // try
            //{
                using (var client = new ImapClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect(Server, 993, true);
                    client.Authenticate(Email, Password);
                    
                    return true;
                }
           // }
            //catch (Exception)
            //{
            //    return false;


            //}
            
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


        //Functions that Downloads New Emails
        public void DownloadNewEmails(string Email, string Password, string Server)
        {
            using (var client = new ImapClient())
            {
                client.Connect(Server, 993, true);
                client.Authenticate(Email, Password);

                client.Inbox.Open(FolderAccess.ReadWrite);

                var inbox = client.Inbox;

                var items = inbox.Fetch(0, -1, MessageSummaryItems.Full | MessageSummaryItems.UniqueId | MessageSummaryItems.BodyStructure);

                foreach (var item in items)
                {
                    if (!item.Flags.Value.HasFlag(MessageFlags.Seen))
                    {
                        //Set the flag to seen
                        inbox.AddFlags(item.UniqueId, MessageFlags.Seen, true);

                        //create a new emailListdata clas to store the data in Json format
                        var email = new EmailListData();
                        email.From = item.Envelope.From.ToString();
                        email.Subject = item.Envelope.Subject.ToString();
                        email.Date = item.Date.ToString();
                        email.To = item.Envelope.To.ToString();
                        email.Cc = item.Envelope.Cc.ToString();
                        email.Bcc = item.Envelope.Bcc.ToString();


                        // get the body structure for the message
                        // IMessageSummary.TextBody is a convenience property that finds the 'text/plain' body part for us
                        var bodyPart = item.TextBody;

                        // download the 'text/plain' body part
                        var body = (TextPart)client.Inbox.GetBodyPart(item.UniqueId, bodyPart);

                        // TextPart.Text is a convenience property that decodes the content and converts the result to
                        // a string for us
                        var text = body.Text;

                        email.Body = text;


                        // now iterate over all of the attachments and save them to disk
                        foreach (var attachment in item.Attachments)
                        {
                            
                            // download the attachment just like we did with the body
                            var entity = client.Inbox.GetBodyPart(item.UniqueId, attachment);

                            // attachments can be either message/rfc822 parts or regular MIME parts
                            if (entity is MessagePart)
                            {
                                var rfc822 = (MessagePart)entity;
                                string folderPathAttachments = Properties.Settings.Default.FolderPathAttachments;
                                var path = Path.Combine(folderPathAttachments, attachment.PartSpecifier + ".eml");

                                rfc822.Message.WriteTo(path);
                                email.Attachment = path;
                            }
                            else
                            {
                                var part = (MimePart)entity;

                                // note: it's possible for this to be null, but most will specify a filename
                                var fileName = part.FileName;
                                string folderPathAttachments = Properties.Settings.Default.FolderPathAttachments;
                                var path = Path.Combine(folderPathAttachments, fileName);

                                // decode and save the content to a file
                                using (var stream = File.Create(path))
                                    part.Content.DecodeTo(stream);
                                email.Attachment = path;
                            }
                        }


                        string jsonfile = JsonConvert.SerializeObject(email);
                        string subject = item.Envelope.Subject.ToString();
                        //remove this charrackte :  from the string 
                        subject = Regex.Replace(subject, "[^a-zA-Z0-9]", String.Empty);



                        string pathFolder = Properties.Settings.Default.FolderPath + "\\Inbox\\" + subject + ".json";
                        

                        if (File.Exists(pathFolder))
                        {
                            File.Delete(pathFolder);
                        }
                        //write the json file to the pathFolder using stream
                        Console.WriteLine("PathFolder: {0}", pathFolder);
                        using (var tw = new StreamWriter(pathFolder, true))
                        {
                            tw.WriteLine(jsonfile.ToString());
                            tw.Close();
                        }
                    }
                }
                
            }
        }

        //Function that downloads all Email from the server and put them into their respective folders
        public void DownloadAllEmails(string Email, string Password, string Server)
        {
            using (var client = new ImapClient())
            {
                if (!client.IsConnected)
                {
                    Console.WriteLine("Connecting to server...");
                    client.Connect(Server, 993, true);
                    client.Authenticate(Email, Password);
                }

                var folders = client.GetFolders(new FolderNamespace('.', ""));
                //Goes through the folders
                foreach (var folder in folders)
                {
                    
                    //open the folder
                    folder.Open(FolderAccess.ReadWrite);
                    var items = folder.Fetch(0, -1, MessageSummaryItems.Full | MessageSummaryItems.UniqueId | MessageSummaryItems.BodyStructure);

                    //Goes through each Email in the folder
                    foreach (var item in items)
                    {
                        
                        
                        //add a seen flag to the mail so we know we dont have to download it again
                        folder.AddFlags(item.UniqueId, MessageFlags.Seen, true);
                        //create a new emailListdata clas to store the data in Json format
                        var email = new EmailListData();
                        email.From = item.Envelope.From.ToString();
                        email.Subject = item.Envelope.Subject.ToString();
                        email.Date = item.Date.ToString();
                        email.To = item.Envelope.To.ToString();
                        email.Cc = item.Envelope.Cc.ToString();
                        email.Bcc = item.Envelope.Bcc.ToString();


                        // get the body structure for the message
                        // IMessageSummary.TextBody is a convenience property that finds the 'text/plain' body part for us
                        var bodyPart = item.TextBody;

                        if (bodyPart == null)
                        {
                            email.Body = "There is a problem with this Email, it could be that it has no body";

                        }
                        else
                        {
                            // download the 'text/plain' body part
                            var bodyEmail = (TextPart)folder.GetBodyPart(item.UniqueId, bodyPart);

                            // TextPart.Text is a convenience property that decodes the content and converts the result to
                            // a string for us
                            var bodytext = bodyEmail.Text;

                            email.Body = bodytext;
                        }
                        


                        // now iterate over all of the attachments and save them to disk
                        foreach (var attachment in item.Attachments)
                        {

                            // download the attachment just like we did with the body
                            var entity = folder.GetBodyPart(item.UniqueId, attachment);

                            // attachments can be either message/rfc822 parts or regular MIME parts
                            if (entity is MessagePart)
                            {
                                var rfc822 = (MessagePart)entity;
                                string folderPathAttachments = Properties.Settings.Default.FolderPathAttachments;
                                var path = Path.Combine(folderPathAttachments, attachment.PartSpecifier + ".eml");

                                rfc822.Message.WriteTo(path);
                                email.Attachment = path;
                            }
                            else
                            {
                                var part = (MimePart)entity;

                                // note: it's possible for this to be null, but most will specify a filename
                                var fileName = part.FileName;
                                string folderPathAttachments = Properties.Settings.Default.FolderPathAttachments;
                                var path = Path.Combine(folderPathAttachments, fileName);

                                // decode and save the content to a file
                                using (var stream = File.Create(path))
                                    part.Content.DecodeTo(stream);
                                email.Attachment = path;
                            }
                        }

                        string jsonfile = JsonConvert.SerializeObject(email);
                        string subject = item.Envelope.Subject.ToString();
                        //remove this charrackte :  from the string
                        subject = Regex.Replace(subject, "[^a-zA-Z0-9]", String.Empty);

                        string pathFolder = Properties.Settings.Default.FolderPath + "\\" + folder.Name + "\\" + subject + "_"+ item.UniqueId + ".json";

                        if (File.Exists(pathFolder))
                        {
                            File.Delete(pathFolder);
                        }

                        //write the json file to the pathFolder using stream
                        using (var tw = new StreamWriter(pathFolder, true))
                        {
                            tw.WriteLine(jsonfile.ToString());
                            tw.Close();
                        }



                    }
                }
            }
        }
        
        


        //Retrieve the Folders from the Email Server and create Folder in the local machine
        public async void  RetrieveFolders(string Email, string Password, string Server)
        {
            using (var client = new ImapClient())
            {
                client.Connect(Server, 993, true);
                client.Authenticate(Email, Password);

                var Folders = await client.GetFoldersAsync(new FolderNamespace('.',""));

                foreach (var item in Folders)
                {
                    //create folder in the local storage
                    //it gets the path from setting
                    string path = Properties.Settings.Default.FolderPath;
                    string folderName = item.Name;
                    string fullPath = Path.Combine(path, folderName);
                    Directory.CreateDirectory(fullPath);                   
                }
            }
        }
        //this function is done

        

    }
}
