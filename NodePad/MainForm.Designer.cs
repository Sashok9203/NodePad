namespace WinFormsApp1
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pastToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            deselectAllToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            fontToolStripMenuItem = new ToolStripMenuItem();
            fontBackColorToolStripMenuItem = new ToolStripMenuItem();
            fontForColorToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            statusStrip1 = new StatusStrip();
            charsCount = new ToolStripStatusLabel();
            linesCount = new ToolStripStatusLabel();
            richTextBox = new RichTextBox();
            toolStrip1 = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            saveAsToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            undoToolStripButton = new ToolStripButton();
            redoToolStripButton = new ToolStripButton();
            cutToolStripButton = new ToolStripButton();
            copyToolStripButton = new ToolStripButton();
            pastToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton8 = new ToolStripButton();
            foreColorToolStripButton = new ToolStripButton();
            backColorToolStripButton = new ToolStripButton();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            contextMenuStrip1.Text = "File";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(793, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newMenuItem
            // 
            newMenuItem.Name = "newMenuItem";
            newMenuItem.Size = new Size(201, 22);
            newMenuItem.Text = "New";
            newMenuItem.Click += newMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(201, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openFile;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(201, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(201, 22);
            saveAsToolStripMenuItem.Text = "Save As...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(201, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, copyToolStripMenuItem, pastToolStripMenuItem, cutToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem, deselectAllToolStripMenuItem, toolStripSeparator5, fontToolStripMenuItem, fontBackColorToolStripMenuItem, fontForColorToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(161, 22);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(161, 22);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(158, 6);
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Enabled = false;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(161, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pastToolStripMenuItem
            // 
            pastToolStripMenuItem.Enabled = false;
            pastToolStripMenuItem.Name = "pastToolStripMenuItem";
            pastToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pastToolStripMenuItem.Size = new Size(161, 22);
            pastToolStripMenuItem.Text = "Past";
            pastToolStripMenuItem.Click += pastToolStripMenuItem_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Enabled = false;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(161, 22);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(158, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Enabled = false;
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(161, 22);
            selectAllToolStripMenuItem.Text = "SelectAll";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // deselectAllToolStripMenuItem
            // 
            deselectAllToolStripMenuItem.Enabled = false;
            deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
            deselectAllToolStripMenuItem.Size = new Size(161, 22);
            deselectAllToolStripMenuItem.Text = "Deselect All";
            deselectAllToolStripMenuItem.Click += deselectAllToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(158, 6);
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            fontToolStripMenuItem.Size = new Size(161, 22);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // fontBackColorToolStripMenuItem
            // 
            fontBackColorToolStripMenuItem.Name = "fontBackColorToolStripMenuItem";
            fontBackColorToolStripMenuItem.Size = new Size(161, 22);
            fontBackColorToolStripMenuItem.Text = "Font BackColor";
            fontBackColorToolStripMenuItem.Click += fontBackColorToolStripMenuItem_Click;
            // 
            // fontForColorToolStripMenuItem
            // 
            fontForColorToolStripMenuItem.Name = "fontForColorToolStripMenuItem";
            fontForColorToolStripMenuItem.Size = new Size(161, 22);
            fontForColorToolStripMenuItem.Text = "Font ForColor";
            fontForColorToolStripMenuItem.Click += fontForColorToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(61, 20);
            aboutToolStripMenuItem.Text = "About...";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { charsCount, linesCount });
            statusStrip1.Location = new Point(0, 337);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(793, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // charsCount
            // 
            charsCount.Name = "charsCount";
            charsCount.Size = new Size(61, 17);
            charsCount.Text = "Chars: 0    ";
            // 
            // linesCount
            // 
            linesCount.Name = "linesCount";
            linesCount.Size = new Size(46, 17);
            linesCount.Text = "Lines: 0";
            // 
            // richTextBox
            // 
            richTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox.Location = new Point(12, 49);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(769, 285);
            richTextBox.TabIndex = 4;
            richTextBox.Text = "";
            richTextBox.SelectionChanged += richTextBox_SelectionChanged;
            richTextBox.TextChanged += richTextBox_TextChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(18, 18);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripButton1, saveToolStripButton, saveAsToolStripButton, toolStripSeparator1, undoToolStripButton, redoToolStripButton, cutToolStripButton, copyToolStripButton, pastToolStripButton, toolStripSeparator2, toolStripButton8, foreColorToolStripButton, backColorToolStripButton });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(793, 25);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.New_document_empty_6315;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "New";
            toolStripButton2.Click += newMenuItem_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.open_file;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "Open";
            toolStripButton1.Click += openFile;
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Enabled = false;
            saveToolStripButton.Image = Properties.Resources.save_file_disk_open_searsh_loading_clipboard_1513;
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(23, 22);
            saveToolStripButton.Text = "Save";
            saveToolStripButton.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripButton
            // 
            saveAsToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveAsToolStripButton.Image = Properties.Resources.saveall_sav_10186;
            saveAsToolStripButton.ImageTransparentColor = Color.Magenta;
            saveAsToolStripButton.Name = "saveAsToolStripButton";
            saveAsToolStripButton.Size = new Size(23, 22);
            saveAsToolStripButton.Text = "SaveAs";
            saveAsToolStripButton.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // undoToolStripButton
            // 
            undoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            undoToolStripButton.Enabled = false;
            undoToolStripButton.Image = Properties.Resources.undoarrow_undo_1534;
            undoToolStripButton.ImageTransparentColor = Color.Magenta;
            undoToolStripButton.Name = "undoToolStripButton";
            undoToolStripButton.Size = new Size(23, 22);
            undoToolStripButton.Text = "Undo";
            undoToolStripButton.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripButton
            // 
            redoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            redoToolStripButton.Enabled = false;
            redoToolStripButton.Image = Properties.Resources.redoarrow_rehace_1547;
            redoToolStripButton.ImageTransparentColor = Color.Magenta;
            redoToolStripButton.Name = "redoToolStripButton";
            redoToolStripButton.Size = new Size(23, 22);
            redoToolStripButton.Text = "Redo";
            redoToolStripButton.Click += redoToolStripMenuItem_Click;
            // 
            // cutToolStripButton
            // 
            cutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cutToolStripButton.Enabled = false;
            cutToolStripButton.Image = Properties.Resources.Scissors512_44207;
            cutToolStripButton.ImageTransparentColor = Color.Magenta;
            cutToolStripButton.Name = "cutToolStripButton";
            cutToolStripButton.Size = new Size(23, 22);
            cutToolStripButton.Text = "Cut";
            cutToolStripButton.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripButton
            // 
            copyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copyToolStripButton.Enabled = false;
            copyToolStripButton.Image = Properties.Resources._1455554314_line_15_icon_icons_com_53330;
            copyToolStripButton.ImageTransparentColor = Color.Magenta;
            copyToolStripButton.Name = "copyToolStripButton";
            copyToolStripButton.Size = new Size(23, 22);
            copyToolStripButton.Text = "Copy";
            copyToolStripButton.Click += pastToolStripMenuItem_Click;
            // 
            // pastToolStripButton
            // 
            pastToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pastToolStripButton.Enabled = false;
            pastToolStripButton.Image = Properties.Resources.texteditor_note_notes_pencil_detext_9967;
            pastToolStripButton.ImageTransparentColor = Color.Magenta;
            pastToolStripButton.Name = "pastToolStripButton";
            pastToolStripButton.Size = new Size(23, 22);
            pastToolStripButton.Text = "Past";
            pastToolStripButton.Click += pastToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripButton8
            // 
            toolStripButton8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton8.Image = Properties.Resources.fontsize_99704;
            toolStripButton8.ImageTransparentColor = Color.Magenta;
            toolStripButton8.Name = "toolStripButton8";
            toolStripButton8.Size = new Size(23, 22);
            toolStripButton8.Text = "Font";
            toolStripButton8.Click += fontToolStripMenuItem_Click;
            // 
            // foreColorToolStripButton
            // 
            foreColorToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            foreColorToolStripButton.Image = Properties.Resources.gui_text_color_icon_157009;
            foreColorToolStripButton.ImageTransparentColor = Color.Magenta;
            foreColorToolStripButton.Name = "foreColorToolStripButton";
            foreColorToolStripButton.Size = new Size(23, 22);
            foreColorToolStripButton.Text = "ForeColor";
            foreColorToolStripButton.Click += fontForColorToolStripMenuItem_Click;
            // 
            // backColorToolStripButton
            // 
            backColorToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            backColorToolStripButton.Image = Properties.Resources.rgb_color_9827;
            backColorToolStripButton.ImageTransparentColor = Color.Magenta;
            backColorToolStripButton.Name = "backColorToolStripButton";
            backColorToolStripButton.Size = new Size(23, 22);
            backColorToolStripButton.Text = "BackColor";
            backColorToolStripButton.Click += fontBackColorToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 359);
            Controls.Add(toolStrip1);
            Controls.Add(richTextBox);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(350, 300);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NotePad";
            FormClosing += MainForm_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem newMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel charsCount;
        private ToolStripStatusLabel linesCount;
        private RichTextBox richTextBox;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pastToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem deselectAllToolStripMenuItem;
        private ToolStripButton saveToolStripButton;
        private ToolStripButton undoToolStripButton;
        private ToolStripButton redoToolStripButton;
        private ToolStripButton cutToolStripButton;
        private ToolStripButton copyToolStripButton;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripButton toolStripButton8;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton pastToolStripButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem fontBackColorToolStripMenuItem;
        private ToolStripMenuItem fontForColorToolStripMenuItem;
        private ToolStripButton foreColorToolStripButton;
        private ToolStripButton backColorToolStripButton;
        private ToolStripButton saveAsToolStripButton;
    }
}