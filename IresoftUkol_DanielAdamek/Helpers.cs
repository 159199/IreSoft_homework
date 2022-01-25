using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IresoftUkol_DanielAdamek
{
    static class Helpers
    {
        internal static void ShowDialogAndSetLabel(OpenFileDialog dialog, Label label)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                label.Text = dialog.FileName;
                label.ForeColor = Color.Black;
            }
        }
        public static bool IsDialogFileValid(this OpenFileDialog dialog) => System.IO.File.Exists(dialog.FileName);
    }
}
