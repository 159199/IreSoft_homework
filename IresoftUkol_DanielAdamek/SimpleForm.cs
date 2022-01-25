using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IresoftUkol_DanielAdamek.DTOs;

//TODO add info label and display progress and info
namespace IresoftUkol_DanielAdamek
{
    public partial class SimpleForm : Form
    {
        private Validator _validator { get; set; } //TODO init, implement

        public SimpleForm()
        {
            InitializeComponent();
        }

        private void SimpleForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadInputFileButton_Click(object sender, EventArgs e)
        {
            Helpers.ShowDialogAndSetLabel(InputFileDialog, InputFileName);
        }

        private void LoadOutputFileButton_Click(object sender, EventArgs e)
        {
            Helpers.ShowDialogAndSetLabel(OutputFileDialog, OutputFileName);
        }        

        private void CalculateStatistics_Click(object sender, EventArgs e)
        {
            if (InputFileDialog.IsDialogFileValid())
            {
                SetFileInfo(InputFileDialog.FileName);
            }
            else
                MessageBox.Show("First you need to add valid input file.");
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            
            if (InputFileDialog.IsDialogFileValid() && OutputFileDialog.IsDialogFileValid())
            {
                if (MessageBox.Show("this will overwrite output file. Continue?", "Overwrite Alert", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                System.IO.File.Copy(InputFileDialog.FileName, OutputFileDialog.FileName, true); //TODO try catch
                SetFileInfo(OutputFileDialog.FileName);
            }
            else
                MessageBox.Show("First you need to add valid input and output files.");
        }

        private void RemoveDiacriticsButton_Click(object sender, EventArgs e)
        {
            if (InputFileDialog.IsDialogFileValid() && OutputFileDialog.IsDialogFileValid())
            {
                if (MessageBox.Show("this will overwrite output file. Continue?", "Overwrite Alert", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                var lines = System.IO.File.ReadAllLines(InputFileDialog.FileName);
                var outputLines = new List<string>();
                foreach (var line in lines)
                {
                    var normalizedString = line.Normalize(NormalizationForm.FormD);
                    var stringBuilder = new StringBuilder();

                    foreach (var c in normalizedString)
                    {
                        var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                        if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                        {
                            stringBuilder.Append(c);
                        }
                    }

                    outputLines.Add(stringBuilder.ToString().Normalize(NormalizationForm.FormC));
                    SetFileInfo(OutputFileDialog.FileName);
                }
                System.IO.File.WriteAllLines(OutputFileDialog.FileName, outputLines); //TODO try catch
            }
            else
                MessageBox.Show("First you need to add valid input and output files.");
        }

        private void RemoveEmptyRowsButton_Click(object sender, EventArgs e)
        {
            if (InputFileDialog.IsDialogFileValid() && OutputFileDialog.IsDialogFileValid())
            {
                if (MessageBox.Show("this will overwrite output file. Continue?", "Overwrite Alert", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                var lines = System.IO.File.ReadAllLines(InputFileDialog.FileName).ToList().Where(x => x != "");
                System.IO.File.WriteAllLines(OutputFileDialog.FileName, lines);
                SetFileInfo(OutputFileDialog.FileName);
            }
            else
                MessageBox.Show("First you need to add valid input and output files.");
        }

        private void SqueezeButton_Click(object sender, EventArgs e)
        {
            if (InputFileDialog.IsDialogFileValid() && OutputFileDialog.IsDialogFileValid())
            {
                if (MessageBox.Show("this will overwrite output file. Continue?", "Overwrite Alert", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                var text =
                CultureInfo.CurrentCulture.TextInfo.ToTitleCase(System.IO.File.ReadAllText(InputFileDialog.FileName).ToLower());
                text = text.Replace(" ", "")
                    .Replace(".", "")
                    .Replace(",", "")
                    .Replace("?", "")
                    .Replace("!", ""); //TODO rozsekat text na kusy treba po 1000znacich a provest tohle pro kazdou cast. A merit progress at mam co zobrazovat
                System.IO.File.WriteAllText(OutputFileDialog.FileName, text);
                SetFileInfo(OutputFileDialog.FileName);
            }
            else
                MessageBox.Show("First you need to add valid input and output files.");
        }

        private void SetFileInfo(string filename)
        {
            var stats = Statistics.Calculate(filename);
            NumberOfRows.Text = stats.NumberOfRows.ToString();
            NumberOfWords.Text = stats.NumberOfWords.ToString();
            NumberOfSentences.Text = stats.NumberOfSentences.ToString();
            NumberOfCharacters.Text = stats.NumberOfCharacters.ToString();
        }
    }
}
