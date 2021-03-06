
namespace IresoftUkol_DanielAdamek
{
    partial class SimpleForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OutputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.LoadInputFileButton = new System.Windows.Forms.Button();
            this.LoadOutputFileButton = new System.Windows.Forms.Button();
            this.InputFileName = new System.Windows.Forms.Label();
            this.OutputFileName = new System.Windows.Forms.Label();
            this.FileInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.CalculateStatistics = new System.Windows.Forms.Button();
            this.NumberOfRows = new System.Windows.Forms.Label();
            this.NumberOfRowsLabel = new System.Windows.Forms.Label();
            this.NumberOfCharacters = new System.Windows.Forms.Label();
            this.NumberOfCharacterLabel = new System.Windows.Forms.Label();
            this.NumberOfWords = new System.Windows.Forms.Label();
            this.NumberOfWordsLabel = new System.Windows.Forms.Label();
            this.NumberOfSentences = new System.Windows.Forms.Label();
            this.NumberOfSentencesLabel = new System.Windows.Forms.Label();
            this.ActionsGroupBox = new System.Windows.Forms.GroupBox();
            this.SqueezeButton = new System.Windows.Forms.Button();
            this.RemoveEmptyRowsButton = new System.Windows.Forms.Button();
            this.RemoveDiacriticsButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.FileInfoGroupBox.SuspendLayout();
            this.ActionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputFileDialog
            // 
            this.InputFileDialog.FileName = "InputFile";
            this.InputFileDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // OutputFileDialog
            // 
            this.OutputFileDialog.FileName = "OutputFile";
            this.OutputFileDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // LoadInputFileButton
            // 
            this.LoadInputFileButton.Location = new System.Drawing.Point(12, 12);
            this.LoadInputFileButton.Name = "LoadInputFileButton";
            this.LoadInputFileButton.Size = new System.Drawing.Size(128, 23);
            this.LoadInputFileButton.TabIndex = 0;
            this.LoadInputFileButton.Text = "Add Input File";
            this.LoadInputFileButton.UseVisualStyleBackColor = true;
            this.LoadInputFileButton.Click += new System.EventHandler(this.LoadInputFileButton_Click);
            // 
            // LoadOutputFileButton
            // 
            this.LoadOutputFileButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LoadOutputFileButton.Location = new System.Drawing.Point(12, 41);
            this.LoadOutputFileButton.Name = "LoadOutputFileButton";
            this.LoadOutputFileButton.Size = new System.Drawing.Size(128, 23);
            this.LoadOutputFileButton.TabIndex = 2;
            this.LoadOutputFileButton.Text = "Add Output File";
            this.LoadOutputFileButton.UseVisualStyleBackColor = true;
            this.LoadOutputFileButton.Click += new System.EventHandler(this.LoadOutputFileButton_Click);
            // 
            // InputFileName
            // 
            this.InputFileName.AutoSize = true;
            this.InputFileName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.InputFileName.Location = new System.Drawing.Point(160, 16);
            this.InputFileName.Name = "InputFileName";
            this.InputFileName.Size = new System.Drawing.Size(105, 15);
            this.InputFileName.TabIndex = 4;
            this.InputFileName.Text = "...input file name...";
            // 
            // OutputFileName
            // 
            this.OutputFileName.AutoSize = true;
            this.OutputFileName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.OutputFileName.Location = new System.Drawing.Point(160, 45);
            this.OutputFileName.Name = "OutputFileName";
            this.OutputFileName.Size = new System.Drawing.Size(113, 15);
            this.OutputFileName.TabIndex = 5;
            this.OutputFileName.Text = "...output file name...";
            // 
            // FileInfoGroupBox
            // 
            this.FileInfoGroupBox.Controls.Add(this.CalculateStatistics);
            this.FileInfoGroupBox.Controls.Add(this.NumberOfRows);
            this.FileInfoGroupBox.Controls.Add(this.NumberOfRowsLabel);
            this.FileInfoGroupBox.Controls.Add(this.NumberOfCharacters);
            this.FileInfoGroupBox.Controls.Add(this.NumberOfCharacterLabel);
            this.FileInfoGroupBox.Controls.Add(this.NumberOfWords);
            this.FileInfoGroupBox.Controls.Add(this.NumberOfWordsLabel);
            this.FileInfoGroupBox.Controls.Add(this.NumberOfSentences);
            this.FileInfoGroupBox.Controls.Add(this.NumberOfSentencesLabel);
            this.FileInfoGroupBox.Location = new System.Drawing.Point(12, 70);
            this.FileInfoGroupBox.Name = "FileInfoGroupBox";
            this.FileInfoGroupBox.Size = new System.Drawing.Size(253, 368);
            this.FileInfoGroupBox.TabIndex = 6;
            this.FileInfoGroupBox.TabStop = false;
            this.FileInfoGroupBox.Text = "File Informations";
            // 
            // CalculateStatistics
            // 
            this.CalculateStatistics.Location = new System.Drawing.Point(18, 23);
            this.CalculateStatistics.Name = "CalculateStatistics";
            this.CalculateStatistics.Size = new System.Drawing.Size(96, 23);
            this.CalculateStatistics.TabIndex = 8;
            this.CalculateStatistics.Text = "Get file info";
            this.CalculateStatistics.UseVisualStyleBackColor = true;
            this.CalculateStatistics.Click += new System.EventHandler(this.CalculateStatistics_Click);
            // 
            // NumberOfRows
            // 
            this.NumberOfRows.AutoSize = true;
            this.NumberOfRows.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NumberOfRows.Location = new System.Drawing.Point(149, 103);
            this.NumberOfRows.Name = "NumberOfRows";
            this.NumberOfRows.Size = new System.Drawing.Size(13, 15);
            this.NumberOfRows.TabIndex = 7;
            this.NumberOfRows.Text = "0";
            // 
            // NumberOfRowsLabel
            // 
            this.NumberOfRowsLabel.AutoSize = true;
            this.NumberOfRowsLabel.Location = new System.Drawing.Point(44, 103);
            this.NumberOfRowsLabel.Name = "NumberOfRowsLabel";
            this.NumberOfRowsLabel.Size = new System.Drawing.Size(99, 15);
            this.NumberOfRowsLabel.TabIndex = 6;
            this.NumberOfRowsLabel.Text = "Number of rows :";
            // 
            // NumberOfCharacters
            // 
            this.NumberOfCharacters.AutoSize = true;
            this.NumberOfCharacters.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NumberOfCharacters.Location = new System.Drawing.Point(149, 88);
            this.NumberOfCharacters.Name = "NumberOfCharacters";
            this.NumberOfCharacters.Size = new System.Drawing.Size(13, 15);
            this.NumberOfCharacters.TabIndex = 5;
            this.NumberOfCharacters.Text = "0";
            // 
            // NumberOfCharacterLabel
            // 
            this.NumberOfCharacterLabel.AutoSize = true;
            this.NumberOfCharacterLabel.Location = new System.Drawing.Point(16, 88);
            this.NumberOfCharacterLabel.Name = "NumberOfCharacterLabel";
            this.NumberOfCharacterLabel.Size = new System.Drawing.Size(128, 15);
            this.NumberOfCharacterLabel.TabIndex = 4;
            this.NumberOfCharacterLabel.Text = "Number of characters :";
            // 
            // NumberOfWords
            // 
            this.NumberOfWords.AutoSize = true;
            this.NumberOfWords.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NumberOfWords.Location = new System.Drawing.Point(149, 73);
            this.NumberOfWords.Name = "NumberOfWords";
            this.NumberOfWords.Size = new System.Drawing.Size(13, 15);
            this.NumberOfWords.TabIndex = 3;
            this.NumberOfWords.Text = "0";
            // 
            // NumberOfWordsLabel
            // 
            this.NumberOfWordsLabel.AutoSize = true;
            this.NumberOfWordsLabel.Location = new System.Drawing.Point(38, 73);
            this.NumberOfWordsLabel.Name = "NumberOfWordsLabel";
            this.NumberOfWordsLabel.Size = new System.Drawing.Size(106, 15);
            this.NumberOfWordsLabel.TabIndex = 2;
            this.NumberOfWordsLabel.Text = "Number of words :";
            // 
            // NumberOfSentences
            // 
            this.NumberOfSentences.AutoSize = true;
            this.NumberOfSentences.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NumberOfSentences.Location = new System.Drawing.Point(149, 58);
            this.NumberOfSentences.Name = "NumberOfSentences";
            this.NumberOfSentences.Size = new System.Drawing.Size(13, 15);
            this.NumberOfSentences.TabIndex = 1;
            this.NumberOfSentences.Text = "0";
            // 
            // NumberOfSentencesLabel
            // 
            this.NumberOfSentencesLabel.AutoSize = true;
            this.NumberOfSentencesLabel.Location = new System.Drawing.Point(18, 58);
            this.NumberOfSentencesLabel.Name = "NumberOfSentencesLabel";
            this.NumberOfSentencesLabel.Size = new System.Drawing.Size(126, 15);
            this.NumberOfSentencesLabel.TabIndex = 0;
            this.NumberOfSentencesLabel.Text = "Number of sentences :";
            // 
            // ActionsGroupBox
            // 
            this.ActionsGroupBox.Controls.Add(this.SqueezeButton);
            this.ActionsGroupBox.Controls.Add(this.RemoveEmptyRowsButton);
            this.ActionsGroupBox.Controls.Add(this.RemoveDiacriticsButton);
            this.ActionsGroupBox.Controls.Add(this.CopyButton);
            this.ActionsGroupBox.Location = new System.Drawing.Point(325, 70);
            this.ActionsGroupBox.Name = "ActionsGroupBox";
            this.ActionsGroupBox.Size = new System.Drawing.Size(263, 264);
            this.ActionsGroupBox.TabIndex = 7;
            this.ActionsGroupBox.TabStop = false;
            this.ActionsGroupBox.Text = "Actions";
            // 
            // SqueezeButton
            // 
            this.SqueezeButton.Location = new System.Drawing.Point(21, 138);
            this.SqueezeButton.Name = "SqueezeButton";
            this.SqueezeButton.Size = new System.Drawing.Size(208, 23);
            this.SqueezeButton.TabIndex = 3;
            this.SqueezeButton.Text = "Remove spaces and interpuntion";
            this.SqueezeButton.UseVisualStyleBackColor = true;
            this.SqueezeButton.Click += new System.EventHandler(this.SqueezeButton_Click);
            // 
            // RemoveEmptyRowsButton
            // 
            this.RemoveEmptyRowsButton.Location = new System.Drawing.Point(49, 109);
            this.RemoveEmptyRowsButton.Name = "RemoveEmptyRowsButton";
            this.RemoveEmptyRowsButton.Size = new System.Drawing.Size(158, 23);
            this.RemoveEmptyRowsButton.TabIndex = 2;
            this.RemoveEmptyRowsButton.Text = "Remove empty rows";
            this.RemoveEmptyRowsButton.UseVisualStyleBackColor = true;
            this.RemoveEmptyRowsButton.Click += new System.EventHandler(this.RemoveEmptyRowsButton_Click);
            // 
            // RemoveDiacriticsButton
            // 
            this.RemoveDiacriticsButton.Location = new System.Drawing.Point(49, 79);
            this.RemoveDiacriticsButton.Name = "RemoveDiacriticsButton";
            this.RemoveDiacriticsButton.Size = new System.Drawing.Size(158, 23);
            this.RemoveDiacriticsButton.TabIndex = 1;
            this.RemoveDiacriticsButton.Text = "Remove diacritics";
            this.RemoveDiacriticsButton.UseVisualStyleBackColor = true;
            this.RemoveDiacriticsButton.Click += new System.EventHandler(this.RemoveDiacriticsButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(90, 50);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 23);
            this.CopyButton.TabIndex = 0;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // SimpleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ActionsGroupBox);
            this.Controls.Add(this.FileInfoGroupBox);
            this.Controls.Add(this.OutputFileName);
            this.Controls.Add(this.InputFileName);
            this.Controls.Add(this.LoadOutputFileButton);
            this.Controls.Add(this.LoadInputFileButton);
            this.Name = "SimpleForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SimpleForm_Load);
            this.FileInfoGroupBox.ResumeLayout(false);
            this.FileInfoGroupBox.PerformLayout();
            this.ActionsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog InputFileDialog;
        private System.Windows.Forms.OpenFileDialog OutputFileDialog;
        private System.Windows.Forms.Button LoadInputFileButton;
        private System.Windows.Forms.Button LoadOutputFileButton;
        private System.Windows.Forms.Label InputFileName;
        private System.Windows.Forms.Label OutputFileName;
        private System.Windows.Forms.GroupBox FileInfoGroupBox;
        private System.Windows.Forms.Label NumberOfRowsLabel;
        private System.Windows.Forms.Label NumberOfCharacters;
        private System.Windows.Forms.Label NumberOfCharacterLabel;
        private System.Windows.Forms.Label NumberOfWords;
        private System.Windows.Forms.Label NumberOfWordsLabel;
        private System.Windows.Forms.Label NumberOfSentences;
        private System.Windows.Forms.Label NumberOfSentencesLabel;
        private System.Windows.Forms.Label NumberOfRows;
        private System.Windows.Forms.Button CalculateStatistics;
        private System.Windows.Forms.GroupBox ActionsGroupBox;
        private System.Windows.Forms.Button SqueezeButton;
        private System.Windows.Forms.Button RemoveEmptyRowsButton;
        private System.Windows.Forms.Button RemoveDiacriticsButton;
        private System.Windows.Forms.Button CopyButton;
    }
}

