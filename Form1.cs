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

namespace UpdateNCFiles
{
    public partial class Form1 : Form
    {
        //public string searchPath = "\\\\anthro3\\MachinePrograms\\HeianRouters";
        public string searchPath = "";
        public string fileText = "";
        public List<string> ncFilesList = new List<string>();

        public Form1()
        {
            InitializeComponent();
            txtSearch.Focus();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please enter a search value");
                txtSearch.Focus();
                return;
            }

            if (txtReplace.Text == "")
            {
                MessageBox.Show("Please enter a replacement value");
                txtReplace.Focus();
                return;
            }

            ncFilesList = Directory.GetFileSystemEntries(searchPath, "*.nc", SearchOption.AllDirectories).ToList<string>();
            string searchString = txtSearch.Text;
           
            foreach (string ncFile in ncFilesList)
            {
                fileText = File.ReadAllText(ncFile);
                if (fileText.Contains(searchString))
                {
                    lbFilesFound.Items.Add(ncFile);
                    fileText = fileText.Replace(searchString, txtReplace.Text);
                    File.WriteAllText(ncFile, fileText);
                }
            }

            filesFound.Text = lbFilesFound.Items.Count + " Files found that contain " + searchString;
            filesFound.Visible = true;
            searchLocation.Enabled = true;
            Search.Enabled = false;

        }

        private void searchLocation_Click(object sender, EventArgs e)
        {
            if (ncFilesList != null)
            {
                ncFilesList.Clear();
            }

            if (lbFilesFound.Items.Count != 0)
            {
                lbFilesFound.Items.Clear();
            }

            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                searchPath = fbd.SelectedPath;
                Search.Enabled = true;
                searchLocation.Enabled = false;
                filesFound.Text = "Search in: " + searchPath;
                filesFound.Visible = true;
            }
        }

    }
}
