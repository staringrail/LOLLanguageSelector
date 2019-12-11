using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOLLanguageSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string strDefaultPath = "C:/Riot Games/League of Legends/LeagueClient.exe";
            if (File.Exists(strDefaultPath)) {
                txtFilePath.Text = strDefaultPath;
            } else {
                txtFilePath.Text = "Please select the path to LeagueClient.exe";
            }

            // Set the language combo box properties
            cmbLanguage.DisplayMember = "KEY";
            cmbLanguage.ValueMember = "VALUE";

            IDictionary<string, string> items = new Dictionary<string, string>();
            items.Add("English (US)", "en_US");
            items.Add("Japanese (日本語)", "ja_JP");
            items.Add("Korean (한글)", "ko_KR");
            items.Add("Russian (Русский)", "ru_RU");
            items.Add("Portuguese (Português)", "pt_BR");
            items.Add("Turkish (Türkçe)", "tr_TR");
            items.Add("Dutch (Deutsch)", "de_DE");
            items.Add("Spanish (Español)", "es_ES");
            items.Add("French (Français)", "fr_FR");
            items.Add("Italian (Italiano)", "it_IT");
            items.Add("Czech (Čeština)", "cs_CZ");


            cmbLanguage.DataSource = new BindingSource(items, null);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\Riot Games\\League of Legends\\";
            openFileDialog1.FileName = "LeagueClient";
            openFileDialog1.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                
                // Check if this is valid executable

                txtFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process.Start(txtFilePath.Text, "--locale=" + cmbLanguage.SelectedValue.ToString());
        }
    }
}
