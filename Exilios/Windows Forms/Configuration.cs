using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exilios.Windows_Forms
{
    public partial class Configuration : Form
    {

        #region Registry Stuff.
        static RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Exilios");

        static String regIsConfig = "isConfig";
        static String regBotToken = "botToken";
        static String regClientId = "clientId";
        static String regBotUsername = "botUsername";
        static String regChannelName = "botChannelName";
        static String regConnectOL = "connectOnLaunch";
        #endregion

        public Configuration()
        {
            InitializeComponent();
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            try
            {
                txtBotToken.Text = reg.GetValue(regBotToken, null).ToString();
                txtClientId.Text = reg.GetValue(regClientId, null).ToString();
                txtBotUsername.Text = reg.GetValue(regBotUsername, null).ToString();
                txtChannelName.Text = reg.GetValue(regChannelName, null).ToString();
            }
            catch (NullReferenceException n)
            {
                Console.WriteLine("First Time Config. NullReferenceException thrown.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            reg.SetValue(regBotToken, txtBotToken.Text);
            reg.SetValue(regClientId, txtClientId.Text);
            reg.SetValue(regBotUsername, txtBotUsername.Text);
            reg.SetValue(regChannelName, txtChannelName.Text);
            reg.SetValue(regIsConfig, true);
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
