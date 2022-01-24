using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
            if (this.InputFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.InputFileName.Text = InputFileDialog.FileName;
                this.InputFileName.ForeColor = Color.Black;
                CountStatistics();
            }
        }

        private void LoadOutputFileButton_Click(object sender, EventArgs e)
        {
            if (this.OutputFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.OutputFileName.Text = OutputFileDialog.FileName;
                this.OutputFileName.ForeColor = Color.Black;
            }
        }

        private void CountStatistics()
        {
            var lines = System.IO.File.ReadAllLines(InputFileDialog.FileName);
            NumberOfRows.Text = lines.Length.ToString();
            var words = new List<string>();
            foreach (var line in lines)
            {
                if (line.Length > 0)
                    words.AddRange(line.Split(" "));
            }
            NumberOfWords.Text = words.Count.ToString();
            NumberOfSentences.Text = words.Count(x => x.EndsWith(".") || x.EndsWith("?") || x.EndsWith("!")).ToString();

            var numberOfCharacters = 0;
            foreach (var word in words)
            {
                numberOfCharacters += word.Length;
            }
            NumberOfCharacters.Text = numberOfCharacters.ToString();
        }
    }
}
