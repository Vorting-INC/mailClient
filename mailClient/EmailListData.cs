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
        public string CC { get; set; }
        public string BCC { get; set; }

        //Location of Attachment
        public string Attachment { get; set; }

    }
}
