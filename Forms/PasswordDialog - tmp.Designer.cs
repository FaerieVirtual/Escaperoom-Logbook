namespace Logbook.Resources
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.HiddenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HintBox = new System.Windows.Forms.Label();
            this.HintContentBox = new System.Windows.Forms.Label();
            this.WarningBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordBox.Location = new System.Drawing.Point(138, 158);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.ReadOnly = true;
            this.passwordBox.Size = new System.Drawing.Size(345, 22);
            this.passwordBox.TabIndex = 0;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.SystemColors.Control;
            this.OKButton.BackgroundImage = global::Logbook.Properties.Resources.arrow_right;
            this.OKButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OKButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKButton.Location = new System.Drawing.Point(562, 210);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(70, 50);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = global::Logbook.Properties.Resources.home;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackButton.Location = new System.Drawing.Point(70, 210);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(70, 50);
            this.BackButton.TabIndex = 3;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // HiddenButton
            // 
            this.HiddenButton.BackgroundImage = global::Logbook.Properties.Resources.hidden;
            this.HiddenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HiddenButton.Location = new System.Drawing.Point(499, 155);
            this.HiddenButton.Name = "HiddenButton";
            this.HiddenButton.Size = new System.Drawing.Size(39, 29);
            this.HiddenButton.TabIndex = 4;
            this.HiddenButton.UseVisualStyleBackColor = true;
            this.HiddenButton.Click += new System.EventHandler(this.HiddenButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tento zápis je chráněný a označený jako soukromý. \r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HintBox
            // 
            this.HintBox.AutoSize = true;
            this.HintBox.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HintBox.Location = new System.Drawing.Point(66, 80);
            this.HintBox.Name = "HintBox";
            this.HintBox.Size = new System.Drawing.Size(108, 20);
            this.HintBox.TabIndex = 6;
            this.HintBox.Text = "Nápověda:";
            this.HintBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HintContentBox
            // 
            this.HintContentBox.AutoSize = true;
            this.HintContentBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HintContentBox.Location = new System.Drawing.Point(180, 80);
            this.HintContentBox.Name = "HintContentBox";
            this.HintContentBox.Size = new System.Drawing.Size(109, 20);
            this.HintContentBox.TabIndex = 7;
            this.HintContentBox.Text = "[nápověda]";
            // 
            // WarningBox
            // 
            this.WarningBox.AutoSize = true;
            this.WarningBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WarningBox.Location = new System.Drawing.Point(164, 193);
            this.WarningBox.Name = "WarningBox";
            this.WarningBox.Size = new System.Drawing.Size(0, 20);
            this.WarningBox.TabIndex = 8;
            // 
            // PasswordDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(685, 282);
            this.Controls.Add(this.WarningBox);
            this.Controls.Add(this.HintContentBox);
            this.Controls.Add(this.HintBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HiddenButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.passwordBox);
            this.Icon = global::Logbook.Properties.Resources.notepad_icon;
            this.Name = "PasswordDialog";
            this.Text = "Logbook v.1.15 - Zašifrovaný zápis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button HiddenButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HintBox;
        private System.Windows.Forms.Label HintContentBox;
        private System.Windows.Forms.Label WarningBox;
    }
}