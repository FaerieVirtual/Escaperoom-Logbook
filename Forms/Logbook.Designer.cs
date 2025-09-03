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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logbook));
            this.ContentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Home_Beehive = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Home_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Add_button = new System.Windows.Forms.ToolStripSplitButton();
            this.Add_LogButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.AddTextButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddImageButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAudioButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Del_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Paste_button = new System.Windows.Forms.ToolStripButton();
            this.Copy = new System.Windows.Forms.ToolStripButton();
            this.Rename = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Read_button = new System.Windows.Forms.ToolStripButton();
            this.Edit_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Mail_button = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.Account_button = new System.Windows.Forms.ToolStripDropDownButton();
            this.KaterinaAccButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SonaAccButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DavidAccButton = new System.Windows.Forms.ToolStripMenuItem();
            this.JakubAccButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAccButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ClockUpdater = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LogPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Home_Beehive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ToolStrip.SuspendLayout();
            this.LogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Enabled = false;
            this.ContentPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ContentPanel.Location = new System.Drawing.Point(32, 291);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(6);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(958, 578);
            this.ContentPanel.TabIndex = 3;
            this.ContentPanel.Tag = "LogDisplay";
            this.ContentPanel.Visible = false;
            this.ContentPanel.WrapContents = false;
            // 
            // Home_Beehive
            // 
            this.Home_Beehive.BackgroundImage = global::Logbook.Properties.Resources.honey_jar;
            this.Home_Beehive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Home_Beehive.Location = new System.Drawing.Point(360, 70);
            this.Home_Beehive.Name = "Home_Beehive";
            this.Home_Beehive.Size = new System.Drawing.Size(380, 460);
            this.Home_Beehive.TabIndex = 8;
            this.Home_Beehive.TabStop = false;
            this.Home_Beehive.Tag = "HomeDisplay";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(32, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "LogDisplay";
            this.pictureBox1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(269, 69);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(520, 45);
            this.textBox1.TabIndex = 5;
            this.textBox1.Tag = "LogDisplay";
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(269, 135);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(374, 27);
            this.textBox2.TabIndex = 6;
            this.textBox2.TabStop = false;
            this.textBox2.Tag = "LogDisplay";
            this.textBox2.Text = "Autor:";
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(269, 174);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(374, 27);
            this.textBox3.TabIndex = 7;
            this.textBox3.Tag = "LogDisplay";
            this.textBox3.Text = "Datum:";
            this.textBox3.Visible = false;
            // 
            // Home_button
            // 
            this.Home_button.Font = new System.Drawing.Font("Courier New", 14.2F);
            this.Home_button.Image = ((System.Drawing.Image)(resources.GetObject("Home_button.Image")));
            this.Home_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Home_button.Name = "Home_button";
            this.Home_button.Size = new System.Drawing.Size(102, 34);
            this.Home_button.Text = "Domů";
            this.Home_button.Click += new System.EventHandler(this.Home_button_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // Add_button
            // 
            this.Add_button.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_LogButton,
            this.toolStripSeparator5,
            this.AddTextButton,
            this.AddImageButton,
            this.AddAudioButton});
            this.Add_button.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add_button.Image = ((System.Drawing.Image)(resources.GetObject("Add_button.Image")));
            this.Add_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(118, 34);
            this.Add_button.Text = "Přidat";
            // 
            // Add_LogButton
            // 
            this.Add_LogButton.Name = "Add_LogButton";
            this.Add_LogButton.Size = new System.Drawing.Size(212, 26);
            this.Add_LogButton.Text = "Protokol";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(209, 6);
            // 
            // AddTextButton
            // 
            this.AddTextButton.Name = "AddTextButton";
            this.AddTextButton.Size = new System.Drawing.Size(212, 26);
            this.AddTextButton.Text = "Textové pole";
            this.AddTextButton.Click += new System.EventHandler(this.Add_TextClick);
            // 
            // AddImageButton
            // 
            this.AddImageButton.Name = "AddImageButton";
            this.AddImageButton.Size = new System.Drawing.Size(212, 26);
            this.AddImageButton.Text = "Obrázek";
            this.AddImageButton.Click += new System.EventHandler(this.Add_ImageClick);
            // 
            // AddAudioButton
            // 
            this.AddAudioButton.Name = "AddAudioButton";
            this.AddAudioButton.Size = new System.Drawing.Size(212, 26);
            this.AddAudioButton.Text = "Nahrávka";
            // 
            // Del_button
            // 
            this.Del_button.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Del_button.Image = ((System.Drawing.Image)(resources.GetObject("Del_button.Image")));
            this.Del_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Del_button.Name = "Del_button";
            this.Del_button.Size = new System.Drawing.Size(113, 34);
            this.Del_button.Text = "Odebrat";
            this.Del_button.Click += new System.EventHandler(this.Del_button_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 34);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // Paste_button
            // 
            this.Paste_button.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Paste_button.Image = ((System.Drawing.Image)(resources.GetObject("Paste_button.Image")));
            this.Paste_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Paste_button.Name = "Paste_button";
            this.Paste_button.Size = new System.Drawing.Size(103, 34);
            this.Paste_button.Text = "Vložit";
            this.Paste_button.Click += new System.EventHandler(this.Paste_button_Click);
            // 
            // Copy
            // 
            this.Copy.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Copy.Image = ((System.Drawing.Image)(resources.GetObject("Copy.Image")));
            this.Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(133, 34);
            this.Copy.Text = "Kopírovat";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Rename
            // 
            this.Rename.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rename.Image = ((System.Drawing.Image)(resources.GetObject("Rename.Image")));
            this.Rename.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rename.Name = "Rename";
            this.Rename.Size = new System.Drawing.Size(153, 34);
            this.Rename.Text = "Přejmenovat";
            this.Rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
            // 
            // Read_button
            // 
            this.Read_button.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Read_button.Image = ((System.Drawing.Image)(resources.GetObject("Read_button.Image")));
            this.Read_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Read_button.Name = "Read_button";
            this.Read_button.Size = new System.Drawing.Size(83, 34);
            this.Read_button.Text = "Číst";
            this.Read_button.Click += new System.EventHandler(this.Read_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Edit_button.Image = ((System.Drawing.Image)(resources.GetObject("Edit_button.Image")));
            this.Edit_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(133, 34);
            this.Edit_button.Text = "Upravovat";
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 37);
            // 
            // Mail_button
            // 
            this.Mail_button.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Mail_button.Image = ((System.Drawing.Image)(resources.GetObject("Mail_button.Image")));
            this.Mail_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Mail_button.Name = "Mail_button";
            this.Mail_button.Size = new System.Drawing.Size(103, 34);
            this.Mail_button.Text = "Zprávy";
            this.Mail_button.Click += new System.EventHandler(this.Mail_Click);
            // 
            // ToolStrip
            // 
            this.ToolStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Home_button,
            this.toolStripSeparator1,
            this.Add_button,
            this.Del_button,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.Paste_button,
            this.Copy,
            this.Rename,
            this.toolStripSeparator3,
            this.Read_button,
            this.Edit_button,
            this.toolStripSeparator4,
            this.Mail_button,
            this.Account_button});
            this.ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ToolStrip.Size = new System.Drawing.Size(1440, 37);
            this.ToolStrip.TabIndex = 2;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // Account_button
            // 
            this.Account_button.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KaterinaAccButton,
            this.SonaAccButton,
            this.DavidAccButton,
            this.JakubAccButton,
            this.AddAccButton});
            this.Account_button.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Account_button.Image = ((System.Drawing.Image)(resources.GetObject("Account_button.Image")));
            this.Account_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Account_button.Name = "Account_button";
            this.Account_button.Size = new System.Drawing.Size(173, 34);
            this.Account_button.Text = "Přihlásit se";
            // 
            // KaterinaAccButton
            // 
            this.KaterinaAccButton.Image = global::Logbook.Properties.Resources.pass;
            this.KaterinaAccButton.Name = "KaterinaAccButton";
            this.KaterinaAccButton.Size = new System.Drawing.Size(332, 26);
            this.KaterinaAccButton.Text = "Ing. Kateřina Havránková";
            this.KaterinaAccButton.Click += new System.EventHandler(this.KaterinaAccButton_Click);
            // 
            // SonaAccButton
            // 
            this.SonaAccButton.Image = ((System.Drawing.Image)(resources.GetObject("SonaAccButton.Image")));
            this.SonaAccButton.Name = "SonaAccButton";
            this.SonaAccButton.Size = new System.Drawing.Size(332, 26);
            this.SonaAccButton.Text = "Dr. Soňa Zahradníková";
            this.SonaAccButton.Click += new System.EventHandler(this.SonaAccButton_Click);
            // 
            // DavidAccButton
            // 
            this.DavidAccButton.Image = ((System.Drawing.Image)(resources.GetObject("DavidAccButton.Image")));
            this.DavidAccButton.Name = "DavidAccButton";
            this.DavidAccButton.Size = new System.Drawing.Size(332, 26);
            this.DavidAccButton.Text = "Prof. David Vykukal";
            this.DavidAccButton.Click += new System.EventHandler(this.DavidAccButton_Click);
            // 
            // JakubAccButton
            // 
            this.JakubAccButton.Image = ((System.Drawing.Image)(resources.GetObject("JakubAccButton.Image")));
            this.JakubAccButton.Name = "JakubAccButton";
            this.JakubAccButton.Size = new System.Drawing.Size(332, 26);
            this.JakubAccButton.Text = "Dr. Jakub Beránek";
            this.JakubAccButton.Click += new System.EventHandler(this.JakubAccButton_Click);
            // 
            // AddAccButton
            // 
            this.AddAccButton.Image = global::Logbook.Properties.Resources.add;
            this.AddAccButton.Name = "AddAccButton";
            this.AddAccButton.Size = new System.Drawing.Size(332, 26);
            this.AddAccButton.Text = "Přidat účet";
            this.AddAccButton.Click += new System.EventHandler(this.AddAccButton_Click);
            // 
            // ClockUpdater
            // 
            this.ClockUpdater.Enabled = true;
            this.ClockUpdater.Interval = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 36.2F);
            this.label1.Location = new System.Drawing.Point(394, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 66);
            this.label1.TabIndex = 9;
            this.label1.Tag = "HomeDisplay";
            this.label1.Text = "00:00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 20.2F);
            this.label2.Location = new System.Drawing.Point(365, 640);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 37);
            this.label2.TabIndex = 10;
            this.label2.Tag = "HomeDisplay";
            this.label2.Text = "pondělí 31.08.2025";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(330, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 42);
            this.label3.TabIndex = 11;
            this.label3.Tag = "MessageDisplay";
            this.label3.Text = "Žádné nové zprávy";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // LogPanel
            // 
            this.LogPanel.AutoScroll = true;
            this.LogPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LogPanel.ColumnCount = 2;
            this.LogPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LogPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.LogPanel.Controls.Add(this.button2, 0, 0);
            this.LogPanel.Controls.Add(this.button1, 1, 0);
            this.LogPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.LogPanel.Location = new System.Drawing.Point(1020, 70);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.RowCount = 2;
            this.LogPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.LogPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.LogPanel.Size = new System.Drawing.Size(400, 800);
            this.LogPanel.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(83, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Logbook.Properties.Resources.locked;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 74);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Logbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.LogPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Home_Beehive);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.ToolStrip);
            this.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Logbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logbook v.1.15";
            this.Load += new System.EventHandler(this.Logbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Home_Beehive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.LogPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FlowLayoutPanel ContentPanel;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
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
        private ToolStripButton Read_button;
        private ToolStripButton Edit_button;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton Mail_button;
        private ToolStrip ToolStrip;
        private Timer ClockUpdater;
        private PictureBox Home_Beehive;
        private Label label1;
        private Label label2;
        private Label label3;
        private ToolStripDropDownButton Account_button;
        private ToolStripMenuItem KaterinaAccButton;
        private ToolStripMenuItem SonaAccButton;
        private ToolStripMenuItem DavidAccButton;
        private ToolStripMenuItem JakubAccButton;
        private ToolStripMenuItem AddAccButton;
        public TableLayoutPanel LogPanel;
        private Button button2;
        private Button button1;
    }
}

