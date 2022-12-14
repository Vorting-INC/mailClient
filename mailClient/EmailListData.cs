using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mailClient
{
    public class EmailListData
    {
        public string From { get; set; }

        public string FromName { get; set; }
        public string Subject { get; set; }
        public string Date { get; set; }
        public string Body { get; set; }
        public string To { get; set; }

        public string ToName { get; set; }

        public string Cc { get; set; }
        public string Bcc { get; set; }

        //Location of Attachment
        public string Attachment { get; set; }

        //Name of Json file
        public string JsonFileName { get; set; }

        //I have made to  Flag to be used in the EmailListData class
        public bool Flag { get; set; }

        public bool Seen { get; set; }

        public bool Snap { get; set; }

        //To save the unique ID of the email
        public string UniqueID { get; set; }

        public bool EmailIsSeen { get; set; }
    }
}
