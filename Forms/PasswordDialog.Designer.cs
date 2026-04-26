using Logbook.Properties;

namespace Logbook.Forms
{
    partial class PasswordDialog
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

        public Log log;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            BackButton = new System.Windows.Forms.Button();
            OKButton = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            LogTitleBox = new System.Windows.Forms.Label();
            HintBox = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            PasswordBox = new System.Windows.Forms.TextBox();
            HiddenButton = new System.Windows.Forms.Button();
            WarningLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.Enabled = false;
            pictureBox1.Image = Resources.locked;
            pictureBox1.Location = new System.Drawing.Point(27, 151);
            pictureBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(200, 250);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "LogDisplay";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 238);
            label1.Location = new System.Drawing.Point(214, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(392, 41);
            label1.TabIndex = 6;
            label1.Text = "Zašifrovaný zápis";
            // 
            // BackButton
            // 
            BackButton.BackgroundImage = Resources.home;
            BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            BackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            BackButton.Location = new System.Drawing.Point(38, 464);
            BackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            OKButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            OKButton.Cursor = System.Windows.Forms.Cursors.Hand;
            OKButton.Location = new System.Drawing.Point(702, 464);
            OKButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            OKButton.Name = "OKButton";
            OKButton.Size = new System.Drawing.Size(70, 70);
            OKButton.TabIndex = 7;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = false;
            OKButton.Click += OKButton_Click;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label2.Location = new System.Drawing.Point(22, 14);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 22);
            label2.TabIndex = 9;
            label2.Text = "Název:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.3209F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.6791F));
            tableLayoutPanel1.Controls.Add(LogTitleBox, 1, 0);
            tableLayoutPanel1.Controls.Add(HintBox, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Location = new System.Drawing.Point(236, 151);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayoutPanel1.Size = new System.Drawing.Size(536, 250);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // LogTitleBox
            // 
            LogTitleBox.AutoSize = true;
            LogTitleBox.Dock = System.Windows.Forms.DockStyle.Fill;
            LogTitleBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            LogTitleBox.Location = new System.Drawing.Point(129, 1);
            LogTitleBox.Name = "LogTitleBox";
            LogTitleBox.Size = new System.Drawing.Size(403, 49);
            LogTitleBox.TabIndex = 15;
            LogTitleBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HintBox
            // 
            HintBox.AutoSize = true;
            HintBox.Dock = System.Windows.Forms.DockStyle.Fill;
            HintBox.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            HintBox.Location = new System.Drawing.Point(129, 101);
            HintBox.Name = "HintBox";
            HintBox.Size = new System.Drawing.Size(403, 148);
            HintBox.TabIndex = 14;
            HintBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label4.Location = new System.Drawing.Point(4, 164);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(118, 22);
            label4.TabIndex = 13;
            label4.Text = "Nápověda:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(PasswordBox, 0, 0);
            tableLayoutPanel2.Controls.Add(HiddenButton, 1, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(129, 55);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            tableLayoutPanel2.Size = new System.Drawing.Size(403, 41);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // PasswordBox
            // 
            PasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            PasswordBox.BackColor = System.Drawing.SystemColors.Window;
            PasswordBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            PasswordBox.Location = new System.Drawing.Point(3, 7);
            PasswordBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new System.Drawing.Size(356, 27);
            PasswordBox.TabIndex = 11;
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // HiddenButton
            // 
            HiddenButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            HiddenButton.BackgroundImage = Resources.hidden;
            HiddenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            HiddenButton.Location = new System.Drawing.Point(365, 4);
            HiddenButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            HiddenButton.Name = "HiddenButton";
            HiddenButton.Size = new System.Drawing.Size(35, 33);
            HiddenButton.TabIndex = 11;
            HiddenButton.UseVisualStyleBackColor = true;
            HiddenButton.Click += HiddenButton_Click;
            // 
            // WarningLabel
            // 
            WarningLabel.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            WarningLabel.ForeColor = System.Drawing.Color.Red;
            WarningLabel.Location = new System.Drawing.Point(114, 464);
            WarningLabel.Name = "WarningLabel";
            WarningLabel.Size = new System.Drawing.Size(580, 42);
            WarningLabel.TabIndex = 11;
            WarningLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PasswordDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(802, 566);
            Controls.Add(WarningLabel);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(BackButton);
            Controls.Add(OKButton);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "PasswordDialog";
            Text = "Logbook v.1.15 - Zašifrovaný zápis";
            Load += OnLoad;
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
        public System.Windows.Forms.Label HintBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label LogTitleBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button HiddenButton;
        public System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label WarningLabel;
    }
}
