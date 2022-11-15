using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace mailClient
{
    public partial class Interface : Form
    {

        
        public Interface()
        {
            InitializeComponent();
        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }

        private void Recieve_Click(object sender, EventArgs e)
        {
            StorageInterface StorageInterface = new StorageInterface();         
            RecievedEmails.Items.Clear();
            string[] files = Directory.GetFiles(StorageInterface.GetFileFolderPath());

            foreach (string file in files)
            {
                RecievedEmails.Items.Add(Path.GetFileName(file));
 
            }
        }

        private void RecievedEmails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
