using Microsoft.VisualBasic.Logging;
using System.DirectoryServices.ActiveDirectory;
using System.Runtime.Intrinsics.Arm;
using System;
using System.Security.Cryptography;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private string? path = null;
        bool saved = false;

        public MainForm()
        {

            InitializeComponent();

        }

        private void newMenuItem_Click(object sender, EventArgs e)
        {
            if (!saved && MessageBox.Show("Save File ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) SaveText();
            richTextBox.Clear();
            path = null;
        }

        private void openFile(object sender, EventArgs e)
        {
            OpenFileDialog opd = new();
            opd.Filter = "AllFiles(*.*)|*.*|Text Files(*.txt)|*.txt||";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                path = opd.FileName;
                richTextBox.Text = File.ReadAllText(path);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveText(path);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveText();
        }

        private void SaveText(string? path = null)
        {
            if (path == null)
            {
                SaveFileDialog sfd = new();
                sfd.DefaultExt = ".txt";
                if (sfd.ShowDialog() != DialogResult.OK) return;
                this.path = sfd.FileName;
            }
            File.WriteAllText(this.path, richTextBox.Text);
            saved = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!saved && !string.IsNullOrEmpty(richTextBox.Text) && MessageBox.Show("Save File ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) SaveText();
            Close();
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            charsCount.Text = $"Chars: {richTextBox.Text.Length,-5}";
            linesCount.Text = $"Lines: {richTextBox.Lines.Count()}";
            saved = false;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox.CanUndo) richTextBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox.CanRedo) richTextBox.Redo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(richTextBox.SelectedText.Length != 0 ) richTextBox.Copy();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* if(Clipboard.ContainsData("string"))*/  richTextBox.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText.Length != 0) richTextBox.Cut();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text.Length != 0) richTextBox.SelectAll();
        }

        private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText.Length != 0) richTextBox.DeselectAll();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NotePad...", "About");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved! && !string.IsNullOrEmpty(richTextBox.Text) && MessageBox.Show("Save File ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) SaveText();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Font = fd.Font;
            }
        }
    }
}