using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextGlobe
{
    public partial class MainForm : Form
    {
        Engine engine = new Engine();

        public MainForm()
        {
            InitializeComponent();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    addressTextBox.Text = fbd.SelectedPath;
                }
            }
        }

        private void scan_Click(object sender, EventArgs e)
        {
            string extensionsFilter = filtersTextBox.Text;

            string[] allFiles = Directory.GetFiles(addressTextBox.Text, "*." + extensionsFilter, SearchOption.AllDirectories);
            if (allFiles.Length == 0)
            {
                MessageBox.Show("No files were found", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            engine.ScanFiles(allFiles);
            searchTextBox.Enabled = true;
            resultTextBox.Text = "READY!";
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            scanButton.Enabled = !string.IsNullOrWhiteSpace(addressTextBox.Text) && !string.IsNullOrWhiteSpace(filtersTextBox.Text);
        }

        private void filtersTextBox_TextChanged(object sender, EventArgs e)
        {
            scanButton.Enabled = !string.IsNullOrWhiteSpace(filtersTextBox.Text) && !string.IsNullOrWhiteSpace(addressTextBox.Text);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            findButton.Enabled = !string.IsNullOrWhiteSpace(searchTextBox.Text);
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            List<string> results = engine.Query(searchTextBox.Text);

            if (results.Count == 0)
                resultTextBox.Text = "No results were found";
            else
            {
                resultTextBox.Text = "";
                foreach (string res in results)
                    resultTextBox.AppendText(res);
            }
        }
    }
}
