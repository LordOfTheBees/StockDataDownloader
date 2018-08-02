using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalForms
{
    public partial class FileDialogElement : UserControl
    {
        public DialogType Type { get; set; }

        public string Path
        {
            get { return textBox.Text; }
        }

        public FileDialogElement()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string result = "";
            switch (Type)
            {
                case DialogType.Folder:
                    if (folderBrowserDialog.ShowDialog() != DialogResult.Cancel)
                    {
                        result = folderBrowserDialog.SelectedPath;
                    }
                    break;
                case DialogType.SaveFile:
                    if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
                    {
                        result = saveFileDialog.FileName;
                    }
                    break;
                case DialogType.OpenFile:
                    if (openFileDialog.ShowDialog() != DialogResult.Cancel)
                    {
                        result = openFileDialog.FileName;
                    }
                    break;
            }

            textBox.Text = result;
        }
    }

    public enum DialogType
    {
        Folder,
        SaveFile,
        OpenFile
    }
}
