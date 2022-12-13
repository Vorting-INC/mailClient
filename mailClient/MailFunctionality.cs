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
        //creates a instance of the storage interface
        StorageInterface StorageInterface = new StorageInterface();




        //Checks if the email is valid by connectid to Email server with Imap
        public bool LogIn(string Email, string Password, string Server)
        {
     
                using (var client = new ImapClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect(Server, 993, true);
                    client.Authenticate(Email, Password);
                    
                    return true;
                }
          
            
        }

        //Sending Using MimeKit and SMTP
        public void SendEmailTest(EmailListData email, string Email, string Password , string Server)
        {
            
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("", Email));
            message.To.Add(new MailboxAddress("", email.To));
            message.Subject = email.Subject;
            message.Body = new TextPart("plain")
            
            {
                Text = email.Body
            };
            if (email.Cc != "")
            {
                message.Cc.Add(new MailboxAddress("", email.Cc));
            }
            if (email.Attachment != "")
            {
                //adds the attachment to the Mimemessage
                var attachment = new MimePart("application", "octet-stream")
                {
                    Content = new MimeContent(File.OpenRead(email.Attachment), ContentEncoding.Default),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = Path.GetFileName(email.Attachment)
                };
                message.Body = new Multipart("mixed")
                {
                    message.Body,
                    attachment
                };
                
            }
            

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

        //send an email taking the class EmailListData as a parameter
        public async void SendEmail(EmailListData email, string Email, string Password, string Server)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("",Email));
            message.To.Add(MailboxAddress.Parse(email.To));
            
            Console.WriteLine(email.To);
            message.Subject = email.Subject;
            if (email.Cc != "")
            {
                message.Cc.Add(new MailboxAddress("", email.Cc));
            }
           
            
           

            BodyBuilder builder = new BodyBuilder();
            
                
            builder.TextBody = email.Body;
            if (email.Attachment != "")
            {
                builder.Attachments.Add(email.Attachment);
            }
            
            message.Body = builder.ToMessageBody();
            

            //Send the mail via SMTP
            SmtpClient client = new SmtpClient();
            
                // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                

                string SMTPserver = Server;
                //removes imap prefix from Server and set it to SMTP
                SMTPserver = SMTPserver.Replace("imap", "smtp");
                Console.WriteLine(SMTPserver);



                //await client.ConnectAsync(SMTPserver, 465, true);
                client.Connect(SMTPserver, 587, false);

                await client.AuthenticateAsync(Email, Password);
                await client.SendAsync(message);
                Console.WriteLine("Should have send");

                if(!client.IsConnected)
                {
                    Console.WriteLine("Not connected");
                    //return false;
                }
                client.Disconnect(true);
                client.Dispose();
                //check if the mail was send 
                //return true;
                
            

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

                        //save the UniqueId of the email
                        email.UniqueID = item.UniqueId.ToString();

                        email.From = item.Envelope.From.ToString();
                        //check if email has a subject
                        if (item.Envelope.Subject != null)
                        {
                            email.Subject = item.Envelope.Subject.ToString();
                        }
                        else
                        {
                            email.Subject = "No Subject";
                        }
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

                        //remove unwanted charrects from the subject
                        string subject = email.Subject;
                        subject = Regex.Replace(subject, "[^a-zA-Z0-9]", String.Empty);
                        string FileName = subject + item.UniqueId + ".json";


                        //Now its time to deside where to save the file
                        string FolderPath = Path.Combine(Properties.Settings.Default.FolderPath, "Inbox");

                        //check if there is a inbox folder else create it
                        if (!Directory.Exists(FolderPath))
                        {
                            Directory.CreateDirectory(FolderPath);
                        }


                        
                        string[] SpamWords = Properties.Settings.Default.SpamWords.Split(',');
                        //check if the email is spam

                        string SpamBody = email.Body.ToLower();
                        if (SpamWords.Any(SpamBody.Contains))
                        {
                            FolderPath = Path.Combine(Properties.Settings.Default.FolderPath, "Junk");
                            //check if the folder exists
                            if (!Directory.Exists(FolderPath))
                            {
                                Directory.CreateDirectory(FolderPath);
                            }
                            
                            
                        }

                        //check if the mail is a SnapMail
                        if (email.Body.Contains("%%SNAPMAIL%%"))
                        {
                            FolderPath = Path.Combine(Properties.Settings.Default.FolderPath, "SnapMail");
                            //check if the folder exists
                            if (!Directory.Exists(FolderPath))
                            {
                                Directory.CreateDirectory(FolderPath);
                            }
                            //save the file in the spam folder
                            

                            //set boolean snapmail to true
                            email.Snap = true;

                            //remove the snapmail tag from the body
                            email.Body = email.Body.Replace("%%SNAPMAIL%%", "");

                            //delete the email from the server so it wont be downloaded again
                            client.Inbox.AddFlags(item.UniqueId, MessageFlags.Deleted, true);
                            client.Inbox.Expunge();


                        }
                        email.JsonFileName = FileName;
                        //save the file tp the folderPath using storageInterface
                        StorageInterface.SaveJsonFile(email , FileName, FolderPath);



                        






                        /*
                        //create a string path to store the json data
                        string subject = item.Envelope.Subject.ToString();
                        string pathFolder = Properties.Settings.Default.FolderPath + "\\Inbox\\" + subject+"_"+item.UniqueId + ".json";

                        //saves the Name of the file in the Json file itself
                        

                        string jsonfile = JsonConvert.SerializeObject(email);
                        
                        //remove this charrackte :  from the string 
                        subject = Regex.Replace(subject, "[^a-zA-Z0-9]", String.Empty);

                        

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
                        */
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
                        //create a new emailListdata clas to store the data in Json format
                        var email = new EmailListData();
                        
                        if (!item.Flags.Value.HasFlag(MessageFlags.Seen))
                        {
                            //Set the flag to seen
                            folder.AddFlags(item.UniqueId, MessageFlags.Seen, true);
                            email.EmailIsSeen = false;
                        }
                        else
                        {
                            email.EmailIsSeen = true;
                        }

                        email.UniqueID = item.UniqueId.ToString();

                        email.From = item.Envelope.From.ToString();

                        //check if email has a subject
                        if (item.Envelope.Subject != null)
                        {
                            email.Subject = item.Envelope.Subject.ToString();
                        }
                        else
                        {
                            email.Subject = "No Subject";
                        }
                        email.Date = item.Date.ToString();
                        //if there +00.00 remove the +00:00 from the end of the date string 
                        email.Date = email.Date.Replace("+00:00", "");


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

                        //remove unwanted charrects from the subject
                        string subject = email.Subject;
                        subject = Regex.Replace(subject, "[^a-zA-Z0-9]", String.Empty);
                        string FileName = subject + item.UniqueId + ".json";

                        email.JsonFileName = FileName;
                        
                        string PathFolder = Path.Combine(Properties.Settings.Default.FolderPath, folder.Name);
                        //save the file tp the folderPath using storageInterface
                        StorageInterface.SaveJsonFile(email, FileName, PathFolder);


                        /*
                        string jsonfile = JsonConvert.SerializeObject(email);
                        
                        string subject = email.Subject;
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
                        }*/



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

        //this function  saves EmailListdata to a json file
        public void SaveEmail(EmailListData emai)
        {
            string jsonfile = JsonConvert.SerializeObject(emai);
            string subject = emai.Subject;
            //remove this charrackte :  from the string
            subject = Regex.Replace(subject, "[^a-zA-Z0-9]", String.Empty);

            string pathFolder = Properties.Settings.Default.FolderPath + "\\Sent\\" + subject + ".json";

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
