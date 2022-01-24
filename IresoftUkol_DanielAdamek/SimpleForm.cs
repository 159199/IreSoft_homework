using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using IresoftUkol_DanielAdamek.DTOs;

namespace IresoftUkol_DanielAdamek
{
    public partial class SimpleForm : Form
    {
        public SimpleForm()
        {
            InitializeComponent();
        }

        private void SimpleForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadInputFileButton_Click(object sender, EventArgs e)
        {
            ShowDialogAndSetLabel(InputFileDialog, InputFileName);
        }

        private void LoadOutputFileButton_Click(object sender, EventArgs e)
        {
            ShowDialogAndSetLabel(OutputFileDialog, OutputFileName);
        }

        //Custom
        private void ShowDialogAndSetLabel(OpenFileDialog dialog, Label label)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                label.Text = dialog.FileName;
                label.ForeColor = Color.Black;
            }
        }

        private void CalculateStatistics_Click(object sender, EventArgs e)
        {
            var stats = Statistics.Calculate(InputFileDialog.FileName);
            NumberOfRows.Text = stats.NumberOfRows.ToString();
            NumberOfWords.Text = stats.NumberOfWords.ToString();
            NumberOfSentences.Text = stats.NumberOfSentences.ToString();
            NumberOfCharacters.Text = stats.NumberOfCharacters.ToString();
        }
    }
}
