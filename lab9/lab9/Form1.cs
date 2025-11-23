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

namespace lab9
{
    public partial class Form1 : Form
    {
        private ByteSearcher searcher;
        private string selectedFilePath;
        public Form1()
        {
            InitializeComponent();
            searcher = new ByteSearcher();

            searcher.ProgressChanged += OnProgressChanged;
            searcher.SearchCompleted += OnSearchCompleted;
            searcher.SearchStopped += OnSearchStopped;
        }

        private void OnProgressChanged(int progress)
        {
            this.Invoke(new Action(() =>
            {
                progressBar.Value = progress;
            }));
        }

        private void OnSearchCompleted(long count)
        {
            this.Invoke((Action)(() =>
            {
                lblResult.Text = $"Найдено: {count} байтов";
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }));
        }

        private void OnSearchStopped()
        {
            this.Invoke((Action)(() =>
            {
                lblResult.Text = "Поиск остановлен";
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }));
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = dialog.FileName;
                    lblFileName.Text = Path.GetFileName(dialog.FileName);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Выберите файл!");
                return;
            }

            if (!byte.TryParse(txtByte.Text, out byte targetByte))
            {
                MessageBox.Show("Введите число от 0 до 255!");
                return;
            }

            btnStart.Enabled = false;
            btnStop.Enabled = true;
            progressBar.Value = 0;
            lblResult.Text = "Поиск...";

            searcher.StartSearch(selectedFilePath, targetByte);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            searcher.StopSearch();
        }
    }
}
