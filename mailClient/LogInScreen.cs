using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace mailClient
{
    public partial class LogInScreen : Form
    {
        MailFunctionality mailFunctionality = new MailFunctionality();
        
        public LogInScreen()
        {
            InitializeComponent();
            //if rememberMe is true, set the RememberCredentials as checked 
            if (Properties.Settings.Default.RememberMe == true)
            {
                //Sets check box to true
                RememberCredentials.Checked = true;
                //Sets the textboxes to the saved credentials
                PasswordBox.Text = Properties.Settings.Default.Password;
                EmailAddressBox.Text = Properties.Settings.Default.Email;
                ServerBox.Text = Properties.Settings.Default.Server;
            }
        }

        private void LogInScreen_Load(object sender, EventArgs e)
        {

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EmailAddressBox_TextChanged(object sender, EventArgs e)
        {
            //if rememberMe is true, set the text in EmailAddresBox to the saved email
        }
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            
               
            
        }

        private void ServerBox_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void LogInBotton_Click(object sender, EventArgs e)
        {
            

            //add music to the loading screen
            SoundPlayer sndplayr = new

            SoundPlayer(mailClient.Properties.Resources.grindsetvokal);

            sndplayr.Play();
           
            this.Hide();
            
                


            SplashForm.ShowSplashScreen();

            if (mailFunctionality.LogIn(EmailAddressBox.Text, PasswordBox.Text, ServerBox.Text))
            {
                //Saves the Email credentials to the settings to the settings
                Properties.Settings.Default.Email = EmailAddressBox.Text;
                Properties.Settings.Default.Password = PasswordBox.Text;
                Properties.Settings.Default.Server = ServerBox.Text;
                Properties.Settings.Default.Save();
                
                
                
                
                Interface Interface = new Interface();
                SplashForm.CloseForm();
                Interface.Show();
                
                
                
                



            }
            else
            {
                SplashForm.CloseForm();
                this.Show();
                MessageBox.Show("Wrong Email, Password or Server");
                
            }


        }

        private void RememberCredentials_CheckedChanged(object sender, EventArgs e)
        {
            //set setting RememberMe to true if box is checked
            if (RememberCredentials.Checked == true)
            {
                Properties.Settings.Default.RememberMe = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.RememberMe = false;
                Properties.Settings.Default.Save();
            }
        }


    }
}
