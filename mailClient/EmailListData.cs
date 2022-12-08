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
        public string Subject { get; set; }
        public string Date { get; set; }
        public string Body { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }

        //Location of Attachment
        public string Attachment { get; set; }

        //I have made to  Flag to be used in the EmailListData class
        public bool Flag { get; set; }

        public bool Seen { get; set; }



    }
}
