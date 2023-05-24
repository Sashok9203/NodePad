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
using System.Reflection.Metadata.Ecma335;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private string? path = null;
        bool _saved = false;
        bool Saved
        {
            get => _saved;
            set
            {
                _saved = value;
                saveToolStripMenuItem.Enabled = !value;
                saveToolStripButton.Enabled = !value;
            }
        }
        public MainForm()
        {
            InitializeComponent();
            pastToolStripMenuItem.Enabled = richTextBox.CanPaste(DataFormats.GetFormat(DataFormats.Text));
            pastToolStripButton.Enabled = pastToolStripMenuItem.Enabled;
            _saved = false;
        }

        private void newMenuItem_Click(object sender, EventArgs e)
        {
            saveDial();
            richTextBox.Clear();
            path = null;
        }

        private void openFile(object sender, EventArgs e)
        {
            OpenFileDialog opd = new();
            opd.Filter = "Txt Files (*.txt)|*.txt|RichTxt files (*.rtxt)|*.rtxt";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                path = opd.FileName;
                if (Path.GetExtension(opd.FileName) == ".txt") richTextBox.Text = File.ReadAllText(path);
                else richTextBox.Rtf = File.ReadAllText(path);
            }
            Saved = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) => SaveText(path);

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) => SaveText();

        private void SaveText(string? path = null)
        {
            SaveFileDialog? sfd = null;
            if (path == null)
            {
                sfd = new()
                {
                    Filter = "Text Files (*.txt)|*.txt|RichText files (*.rtxt)|*.rtxt",
                    FilterIndex = 1,
                    RestoreDirectory = true
                };
                if (sfd.ShowDialog() != DialogResult.OK) return;
                this.path = sfd.FileName;
            }
            if (Path.GetExtension(this.path) == ".txt") File.WriteAllText(this.path, richTextBox.Text);
            else File.WriteAllText(this.path, richTextBox.Rtf);
            Saved = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveDial();
            Close();
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

            undoToolStripButton.Enabled = richTextBox.CanUndo;
            undoToolStripMenuItem.Enabled = richTextBox.CanUndo;
            redoToolStripButton.Enabled = richTextBox.CanRedo;
            redoToolStripMenuItem.Enabled = richTextBox.CanRedo;
            charsCount.Text = $"Chars: {richTextBox.Text.Length,-5}";
            linesCount.Text = $"Lines: {richTextBox.Lines.Length}";
            selectAllToolStripMenuItem.Enabled = richTextBox.Text.Length != 0;
            Saved = false;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox.Undo();

        private void redoToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox.Redo();

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pastToolStripMenuItem.Enabled)
            {
                pastToolStripMenuItem.Enabled = true;
                pastToolStripButton.Enabled = pastToolStripMenuItem.Enabled;
            }
            richTextBox.Copy();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox.Paste();

        private void cutToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox.Cut();

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox.SelectAll();

        private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox.DeselectAll();

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) => MessageBox.Show("NotePad...", "About");

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => saveDial();

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox.SelectedText.Length == 0) richTextBox.Font = fd.Font;
                else richTextBox.SelectionFont = fd.Font;
            }
        }

        private void richTextBox_SelectionChanged(object sender, EventArgs e)
        {
            bool enabled = richTextBox.SelectedText.Length > 0;
            copyToolStripMenuItem.Enabled = enabled;
            copyToolStripButton.Enabled = enabled;
            cutToolStripMenuItem.Enabled = enabled;
            cutToolStripButton.Enabled = enabled;
            deselectAllToolStripMenuItem.Enabled = enabled;
        }

        private void saveDial()
        {
            if (!Saved && !string.IsNullOrEmpty(richTextBox.Text) && MessageBox.Show("Save File ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) SaveText();
        }

        private void fontBackColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox.SelectedText.Length == 0) richTextBox.BackColor = cd.Color;
                else richTextBox.SelectionBackColor = cd.Color;
            }
        }

        private void fontForColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox.SelectedText.Length == 0) richTextBox.ForeColor = cd.Color;
                else richTextBox.SelectionColor = cd.Color;
            }
        }
    }
}