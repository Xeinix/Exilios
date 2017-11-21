namespace Exilios.Windows_Forms
{
    partial class Configuration
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTwitchSettings = new System.Windows.Forms.Label();
            this.lblbotToken = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBotToken = new System.Windows.Forms.TextBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBotUsername = new System.Windows.Forms.TextBox();
            this.lblBotUsername = new System.Windows.Forms.Label();
            this.txtChannelName = new System.Windows.Forms.TextBox();
            this.lblChannelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(13, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(184, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(199, 413);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 36);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTwitchSettings
            // 
            this.lblTwitchSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTwitchSettings.AutoSize = true;
            this.lblTwitchSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTwitchSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwitchSettings.Location = new System.Drawing.Point(149, 9);
            this.lblTwitchSettings.Name = "lblTwitchSettings";
            this.lblTwitchSettings.Size = new System.Drawing.Size(108, 18);
            this.lblTwitchSettings.TabIndex = 2;
            this.lblTwitchSettings.Text = "Twitch Settings";
            this.lblTwitchSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblbotToken
            // 
            this.lblbotToken.AutoSize = true;
            this.lblbotToken.Location = new System.Drawing.Point(14, 46);
            this.lblbotToken.Name = "lblbotToken";
            this.lblbotToken.Size = new System.Drawing.Size(72, 13);
            this.lblbotToken.TabIndex = 3;
            this.lblbotToken.Text = "Twitch OAuth";
            this.lblbotToken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Client Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBotToken
            // 
            this.txtBotToken.Location = new System.Drawing.Point(92, 43);
            this.txtBotToken.Name = "txtBotToken";
            this.txtBotToken.PasswordChar = '-';
            this.txtBotToken.Size = new System.Drawing.Size(300, 20);
            this.txtBotToken.TabIndex = 5;
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(92, 71);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.PasswordChar = '-';
            this.txtClientId.Size = new System.Drawing.Size(300, 20);
            this.txtClientId.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Exilios Settings";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoCheck = false;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(121, 190);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Connect On Startup";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBotUsername
            // 
            this.txtBotUsername.Location = new System.Drawing.Point(92, 97);
            this.txtBotUsername.Name = "txtBotUsername";
            this.txtBotUsername.Size = new System.Drawing.Size(300, 20);
            this.txtBotUsername.TabIndex = 11;
            // 
            // lblBotUsername
            // 
            this.lblBotUsername.AutoSize = true;
            this.lblBotUsername.Location = new System.Drawing.Point(12, 100);
            this.lblBotUsername.Name = "lblBotUsername";
            this.lblBotUsername.Size = new System.Drawing.Size(74, 13);
            this.lblBotUsername.TabIndex = 10;
            this.lblBotUsername.Text = "Bot Username";
            this.lblBotUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtChannelName
            // 
            this.txtChannelName.Location = new System.Drawing.Point(92, 123);
            this.txtChannelName.Name = "txtChannelName";
            this.txtChannelName.Size = new System.Drawing.Size(300, 20);
            this.txtChannelName.TabIndex = 13;
            // 
            // lblChannelName
            // 
            this.lblChannelName.AutoSize = true;
            this.lblChannelName.Location = new System.Drawing.Point(9, 126);
            this.lblChannelName.Name = "lblChannelName";
            this.lblChannelName.Size = new System.Drawing.Size(77, 13);
            this.lblChannelName.TabIndex = 12;
            this.lblChannelName.Text = "Channel Name";
            this.lblChannelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Configuration
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(404, 461);
            this.Controls.Add(this.txtChannelName);
            this.Controls.Add(this.lblChannelName);
            this.Controls.Add(this.txtBotUsername);
            this.Controls.Add(this.lblBotUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.txtBotToken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblbotToken);
            this.Controls.Add(this.lblTwitchSettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 500);
            this.Name = "Configuration";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Exilios Configuration";
            this.Load += new System.EventHandler(this.Configuration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTwitchSettings;
        private System.Windows.Forms.Label lblbotToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBotToken;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBotUsername;
        private System.Windows.Forms.Label lblBotUsername;
        private System.Windows.Forms.TextBox txtChannelName;
        private System.Windows.Forms.Label lblChannelName;
    }
}