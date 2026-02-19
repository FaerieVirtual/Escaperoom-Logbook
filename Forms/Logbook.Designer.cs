using Logbook.Properties;
using System.Drawing;
using System.Drawing.Configuration;
using System.Windows.Forms;

namespace Logbook
{
    partial class Logbook
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logbook));
            Home_Beehive = new PictureBox();
            Home_button = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            Add_button = new ToolStripSplitButton();
            Add_LogButton = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            AddTextButton = new ToolStripMenuItem();
            AddImageButton = new ToolStripMenuItem();
            AddAudioButton = new ToolStripMenuItem();
            Del_button = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            Paste_button = new ToolStripButton();
            Copy = new ToolStripButton();
            Rename = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            Undo_button = new ToolStripButton();
            Redo_button = new ToolStripButton();
            ToolStrip = new ToolStrip();
            Account_button = new ToolStripDropDownButton();
            AddAccButton = new ToolStripMenuItem();
            ClockUpdater = new Timer(components);
            TimeLabel = new Label();
            DateLabel = new Label();
            DateTimeBox = new TextBox();
            ContentPanel = new FlowLayoutPanel();
            AuthorBox = new TextBox();
            LogTitle = new TextBox();
            pictureBox1 = new PictureBox();
            LogPanel = new FlowLayoutPanel();
            MainPanel = new TableLayoutPanel();
            LeftPanel = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)Home_Beehive).BeginInit();
            ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MainPanel.SuspendLayout();
            LeftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Home_Beehive
            // 
            Home_Beehive.BackgroundImage = Resources.honey_jar;
            Home_Beehive.BackgroundImageLayout = ImageLayout.Zoom;
            Home_Beehive.Location = new Point(360, 70);
            Home_Beehive.Name = "Home_Beehive";
            Home_Beehive.Size = new Size(380, 460);
            Home_Beehive.TabIndex = 8;
            Home_Beehive.TabStop = false;
            Home_Beehive.Tag = "HomeDisplay";
            // 
            // Home_button
            // 
            Home_button.Font = new Font("Courier New", 14.2F);
            Home_button.Image = (Image)resources.GetObject("Home_button.Image");
            Home_button.ImageTransparentColor = Color.Magenta;
            Home_button.Name = "Home_button";
            Home_button.Size = new Size(102, 34);
            Home_button.Text = "Domů";
            Home_button.Click += Home_button_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 37);
            // 
            // Add_button
            // 
            Add_button.DropDownItems.AddRange(new ToolStripItem[] { Add_LogButton, toolStripSeparator5, AddTextButton, AddImageButton, AddAudioButton });
            Add_button.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Add_button.Image = (Image)resources.GetObject("Add_button.Image");
            Add_button.ImageTransparentColor = Color.Magenta;
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(118, 34);
            Add_button.Text = "Přidat";
            // 
            // Add_LogButton
            // 
            Add_LogButton.Name = "Add_LogButton";
            Add_LogButton.Size = new Size(212, 26);
            Add_LogButton.Text = "Protokol";
            Add_LogButton.Click += Add_LogButton_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(209, 6);
            // 
            // AddTextButton
            // 
            AddTextButton.Name = "AddTextButton";
            AddTextButton.Size = new Size(212, 26);
            AddTextButton.Text = "Textové pole";
            AddTextButton.Click += Add_TextClick;
            // 
            // AddImageButton
            // 
            AddImageButton.Name = "AddImageButton";
            AddImageButton.Size = new Size(212, 26);
            AddImageButton.Text = "Obrázek";
            AddImageButton.Click += Add_ImageClick;
            // 
            // AddAudioButton
            // 
            AddAudioButton.Name = "AddAudioButton";
            AddAudioButton.Size = new Size(212, 26);
            AddAudioButton.Text = "Nahrávka";
            AddAudioButton.Click += Add_AudioClick;
            // 
            // Del_button
            // 
            Del_button.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Del_button.Image = (Image)resources.GetObject("Del_button.Image");
            Del_button.ImageTransparentColor = Color.Magenta;
            Del_button.Name = "Del_button";
            Del_button.Size = new Size(113, 34);
            Del_button.Text = "Odebrat";
            Del_button.Click += Del_button_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(0, 34);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 37);
            // 
            // Paste_button
            // 
            Paste_button.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Paste_button.Image = (Image)resources.GetObject("Paste_button.Image");
            Paste_button.ImageTransparentColor = Color.Magenta;
            Paste_button.Name = "Paste_button";
            Paste_button.Size = new Size(103, 34);
            Paste_button.Text = "Vložit";
            Paste_button.Click += Paste_button_Click;
            // 
            // Copy
            // 
            Copy.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Copy.Image = (Image)resources.GetObject("Copy.Image");
            Copy.ImageTransparentColor = Color.Magenta;
            Copy.Name = "Copy";
            Copy.Size = new Size(133, 34);
            Copy.Text = "Kopírovat";
            Copy.Click += Copy_Click;
            // 
            // Rename
            // 
            Rename.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Rename.Image = (Image)resources.GetObject("Rename.Image");
            Rename.ImageTransparentColor = Color.Magenta;
            Rename.Name = "Rename";
            Rename.Size = new Size(153, 34);
            Rename.Text = "Přejmenovat";
            Rename.Click += Rename_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 37);
            // 
            // Undo_button
            // 
            Undo_button.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Undo_button.Image = Resources.Undo;
            Undo_button.ImageTransparentColor = Color.Magenta;
            Undo_button.Name = "Undo_button";
            Undo_button.Size = new Size(83, 34);
            Undo_button.Text = "Zpět";
            Undo_button.Click += Undo_button_Click;
            // 
            // Redo_button
            // 
            Redo_button.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Redo_button.Image = Resources.redo;
            Redo_button.ImageTransparentColor = Color.Magenta;
            Redo_button.Name = "Redo_button";
            Redo_button.Size = new Size(93, 34);
            Redo_button.Text = "Znovu";
            Redo_button.Click += Redo_button_Click;
            // 
            // ToolStrip
            // 
            ToolStrip.BackColor = SystemColors.ControlLight;
            ToolStrip.ImageScalingSize = new Size(30, 30);
            ToolStrip.Items.AddRange(new ToolStripItem[] { Home_button, toolStripSeparator1, Add_button, Del_button, toolStripLabel1, toolStripSeparator2, Paste_button, Copy, Rename, toolStripSeparator3, Undo_button, Redo_button, Account_button });
            ToolStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            ToolStrip.Location = new Point(0, 0);
            ToolStrip.Margin = new Padding(0, 0, 0, 20);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.Padding = new Padding(0);
            ToolStrip.RenderMode = ToolStripRenderMode.Professional;
            ToolStrip.Size = new Size(1440, 37);
            ToolStrip.TabIndex = 2;
            ToolStrip.Text = "toolStrip1";
            // 
            // Account_button
            // 
            Account_button.Alignment = ToolStripItemAlignment.Right;
            Account_button.DropDownItems.AddRange(new ToolStripItem[] { AddAccButton });
            Account_button.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Account_button.Image = (Image)resources.GetObject("Account_button.Image");
            Account_button.ImageTransparentColor = Color.Magenta;
            Account_button.Name = "Account_button";
            Account_button.Size = new Size(173, 34);
            Account_button.Text = "Přihlásit se";
            // 
            // AddAccButton
            // 
            AddAccButton.Image = Resources.add;
            AddAccButton.Name = "AddAccButton";
            AddAccButton.Size = new Size(202, 26);
            AddAccButton.Text = "Přidat účet";
            AddAccButton.Click += AddAccButton_Click;
            // 
            // ClockUpdater
            // 
            ClockUpdater.Enabled = true;
            ClockUpdater.Interval = 1000;
            ClockUpdater.Tick += ClockUpdater_Tick;
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Font = new Font("Courier New", 36.2F);
            TimeLabel.Location = new Point(394, 570);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(324, 66);
            TimeLabel.TabIndex = 9;
            TimeLabel.Tag = "HomeDisplay";
            TimeLabel.Text = "00:00:00";
            TimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Courier New", 20.2F);
            DateLabel.Location = new Point(365, 640);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(377, 37);
            DateLabel.TabIndex = 10;
            DateLabel.Tag = "HomeDisplay";
            DateLabel.Text = "pondělí 31.08.2025";
            DateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DateTimeBox
            // 
            DateTimeBox.BackColor = SystemColors.ControlLight;
            DateTimeBox.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            DateTimeBox.Location = new Point(264, 196);
            DateTimeBox.Margin = new Padding(6);
            DateTimeBox.Name = "DateTimeBox";
            DateTimeBox.ReadOnly = true;
            DateTimeBox.Size = new Size(374, 27);
            DateTimeBox.TabIndex = 7;
            DateTimeBox.Tag = "LogDisplay";
            DateTimeBox.Text = "Datum:";
            // 
            // ContentPanel
            // 
            ContentPanel.AutoScroll = true;
            ContentPanel.BorderStyle = BorderStyle.Fixed3D;
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.FlowDirection = FlowDirection.TopDown;
            ContentPanel.Location = new Point(10, 282);
            ContentPanel.Margin = new Padding(10);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(994, 568);
            ContentPanel.TabIndex = 3;
            ContentPanel.Tag = "LogDisplay";
            ContentPanel.WrapContents = false;
            // 
            // AuthorBox
            // 
            AuthorBox.BackColor = SystemColors.ControlLight;
            AuthorBox.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            AuthorBox.Location = new Point(264, 157);
            AuthorBox.Margin = new Padding(6);
            AuthorBox.Name = "AuthorBox";
            AuthorBox.ReadOnly = true;
            AuthorBox.Size = new Size(374, 27);
            AuthorBox.TabIndex = 6;
            AuthorBox.TabStop = false;
            AuthorBox.Tag = "LogDisplay";
            AuthorBox.Text = "Autor:";
            // 
            // LogTitle
            // 
            LogTitle.BackColor = SystemColors.ControlLight;
            LogTitle.Font = new Font("Courier New", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LogTitle.Location = new Point(264, 100);
            LogTitle.Margin = new Padding(6);
            LogTitle.Name = "LogTitle";
            LogTitle.ReadOnly = true;
            LogTitle.Size = new Size(520, 45);
            LogTitle.TabIndex = 5;
            LogTitle.Tag = "LogDisplay";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(35, 60);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "LogDisplay";
            // 
            // LogPanel
            // 
            LogPanel.AutoScroll = true;
            LogPanel.BackColor = SystemColors.Control;
            LogPanel.BorderStyle = BorderStyle.Fixed3D;
            LogPanel.Dock = DockStyle.Fill;
            LogPanel.FlowDirection = FlowDirection.TopDown;
            LogPanel.Location = new Point(1030, 44);
            LogPanel.Margin = new Padding(10);
            LogPanel.MaximumSize = new Size(400, 10000);
            LogPanel.MinimumSize = new Size(400, 100);
            LogPanel.Name = "LogPanel";
            LogPanel.Padding = new Padding(10, 50, 10, 10);
            LogPanel.Size = new Size(400, 846);
            LogPanel.TabIndex = 0;
            LogPanel.WrapContents = false;
            // 
            // MainPanel
            // 
            MainPanel.ColumnCount = 2;
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 420F));
            MainPanel.Controls.Add(LogPanel, 1, 1);
            MainPanel.Controls.Add(LeftPanel, 0, 1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.RowCount = 2;
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainPanel.Size = new Size(1440, 900);
            MainPanel.TabIndex = 11;
            // 
            // LeftPanel
            // 
            LeftPanel.ColumnCount = 1;
            LeftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LeftPanel.Controls.Add(ContentPanel, 0, 1);
            LeftPanel.Dock = DockStyle.Fill;
            LeftPanel.Location = new Point(3, 37);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.RowCount = 2;
            LeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 31.6554813F));
            LeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 68.34452F));
            LeftPanel.Size = new Size(1014, 860);
            LeftPanel.TabIndex = 1;
            LeftPanel.Tag = "LogDisplay";
            // 
            // Logbook
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Zoom;
            MinimumSize = new Size(1280, 800);
            Controls.Add(DateLabel);
            Controls.Add(TimeLabel);
            Controls.Add(Home_Beehive);
            Controls.Add(ToolStrip);
            Controls.Add(AuthorBox);
            Controls.Add(LogTitle);
            Controls.Add(DateTimeBox);
            Controls.Add(pictureBox1);
            Controls.Add(MainPanel);
            Font = new Font("Courier New", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "Logbook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logbook v.1.15";
            Load += OnLoad;
            ClientSizeChanged += ResizeOnClientSizeChanged;
            ((System.ComponentModel.ISupportInitialize)Home_Beehive).EndInit();
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MainPanel.ResumeLayout(false);
            LeftPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private ToolStripButton Home_button;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSplitButton Add_button;
        private ToolStripMenuItem Add_LogButton;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem AddTextButton;
        private ToolStripMenuItem AddImageButton;
        private ToolStripMenuItem AddAudioButton;
        private ToolStripButton Del_button;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton Paste_button;
        private ToolStripButton Copy;
        private ToolStripButton Rename;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton Undo_button;
        private ToolStripButton Redo_button;
        private ToolStrip ToolStrip;
        private Timer ClockUpdater;
        private PictureBox Home_Beehive;
        private Label TimeLabel;
        private Label DateLabel;
        private ToolStripMenuItem AddAccButton;
        public ToolStripDropDownButton Account_button;
        public TextBox DateTimeBox;
        public FlowLayoutPanel ContentPanel;
        public TextBox AuthorBox;
        public TextBox LogTitle;
        private PictureBox pictureBox1;
        public FlowLayoutPanel LogPanel;
        private TableLayoutPanel MainPanel;
        private TableLayoutPanel LeftPanel;
    }
}