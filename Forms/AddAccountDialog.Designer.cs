using Logbook.Properties;
using System.Windows.Forms;

namespace Logbook.Forms
{
    public partial class AddAccountDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            BackButton = new Button();
            OKButton = new Button();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            passwordBox = new TextBox();
            HiddenButton = new Button();
            label4 = new Label();
            NameBox = new TextBox();
            WarningLabel = new Label();
            hintBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Resources.pass;
            pictureBox1.Location = new System.Drawing.Point(27, 151);
            pictureBox1.Margin = new Padding(6, 8, 6, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(200, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "LogDisplay";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 238);
            label1.Location = new System.Drawing.Point(267, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(260, 41);
            label1.TabIndex = 6;
            label1.Text = "Přidat účet";
            // 
            // BackButton
            // 
            BackButton.BackgroundImage = Resources.home;
            BackButton.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton.Cursor = Cursors.Hand;
            BackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            BackButton.Location = new System.Drawing.Point(38, 464);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new System.Drawing.Size(70, 70);
            BackButton.TabIndex = 8;
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // OKButton
            // 
            OKButton.BackColor = System.Drawing.SystemColors.Control;
            OKButton.BackgroundImage = Resources.arrow_right;
            OKButton.BackgroundImageLayout = ImageLayout.Zoom;
            OKButton.Cursor = Cursors.Hand;
            OKButton.Location = new System.Drawing.Point(702, 464);
            OKButton.Margin = new Padding(3, 4, 3, 4);
            OKButton.Name = "OKButton";
            OKButton.Size = new System.Drawing.Size(70, 70);
            OKButton.TabIndex = 7;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = false;
            OKButton.Click += OKButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label2.Location = new System.Drawing.Point(4, 1);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(118, 49);
            label2.TabIndex = 9;
            label2.Text = "Jméno:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label3.Location = new System.Drawing.Point(22, 64);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(82, 22);
            label3.TabIndex = 10;
            label3.Text = "Heslo:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.3209F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.6791F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(NameBox, 1, 0);
            tableLayoutPanel1.Controls.Add(hintBox, 1, 2);
            tableLayoutPanel1.Location = new System.Drawing.Point(236, 151);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(536, 250);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(passwordBox, 0, 0);
            tableLayoutPanel2.Controls.Add(HiddenButton, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(129, 55);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel2.Size = new System.Drawing.Size(403, 41);
            tableLayoutPanel2.TabIndex = 17;
            // 
            // passwordBox
            // 
            passwordBox.Anchor = AnchorStyles.None;
            passwordBox.BackColor = System.Drawing.SystemColors.Window;
            passwordBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            passwordBox.Location = new System.Drawing.Point(3, 7);
            passwordBox.Margin = new Padding(3, 4, 3, 4);
            passwordBox.MaxLength = 25;
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new System.Drawing.Size(356, 27);
            passwordBox.TabIndex = 11;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // HiddenButton
            // 
            HiddenButton.BackgroundImage = Resources.hidden;
            HiddenButton.BackgroundImageLayout = ImageLayout.Zoom;
            HiddenButton.Dock = DockStyle.Fill;
            HiddenButton.Location = new System.Drawing.Point(365, 4);
            HiddenButton.Margin = new Padding(3, 4, 3, 4);
            HiddenButton.Name = "HiddenButton";
            HiddenButton.Size = new System.Drawing.Size(35, 33);
            HiddenButton.TabIndex = 11;
            HiddenButton.UseVisualStyleBackColor = true;
            HiddenButton.Click += HiddenButton_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label4.Location = new System.Drawing.Point(4, 164);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(118, 22);
            label4.TabIndex = 13;
            label4.Text = "Nápověda:";
            // 
            // NameBox
            // 
            NameBox.Anchor = AnchorStyles.None;
            NameBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            NameBox.Location = new System.Drawing.Point(129, 10);
            NameBox.Margin = new Padding(3, 4, 3, 4);
            NameBox.Name = "NameBox";
            NameBox.Size = new System.Drawing.Size(403, 30);
            NameBox.TabIndex = 11;
            // 
            // WarningLabel
            // 
            WarningLabel.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            WarningLabel.ForeColor = System.Drawing.Color.Red;
            WarningLabel.Location = new System.Drawing.Point(116, 464);
            WarningLabel.Name = "WarningLabel";
            WarningLabel.Size = new System.Drawing.Size(580, 42);
            WarningLabel.TabIndex = 11;
            WarningLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hintBox
            // 
            hintBox.Dock = DockStyle.Fill;
            hintBox.Location = new System.Drawing.Point(129, 104);
            hintBox.Multiline = true;
            hintBox.Name = "hintBox";
            hintBox.Size = new System.Drawing.Size(403, 142);
            hintBox.TabIndex = 18;
            // 
            // AddAccountDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(802, 566);
            Controls.Add(WarningLabel);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(BackButton);
            Controls.Add(OKButton);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddAccountDialog";
            Text = "Logbook v.1.15 - Přihlášení";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private Button HiddenButton;
        public TextBox passwordBox;
        private Label WarningLabel;
        private TextBox hintBox;
    }
}