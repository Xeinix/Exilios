namespace Exilios.Windows_Forms
{
    partial class ExiliosGUI
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabMainTab = new System.Windows.Forms.TabPage();
            this.tabNoClueYet = new System.Windows.Forms.TabPage();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabMainTab);
            this.tabMain.Controls.Add(this.tabNoClueYet);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(708, 634);
            this.tabMain.TabIndex = 0;
            // 
            // tabMainTab
            // 
            this.tabMainTab.BackColor = System.Drawing.Color.Gray;
            this.tabMainTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabMainTab.Location = new System.Drawing.Point(4, 22);
            this.tabMainTab.Name = "tabMainTab";
            this.tabMainTab.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainTab.Size = new System.Drawing.Size(700, 608);
            this.tabMainTab.TabIndex = 0;
            this.tabMainTab.Text = "Main Tab";
            // 
            // tabNoClueYet
            // 
            this.tabNoClueYet.Location = new System.Drawing.Point(4, 22);
            this.tabNoClueYet.Name = "tabNoClueYet";
            this.tabNoClueYet.Padding = new System.Windows.Forms.Padding(3);
            this.tabNoClueYet.Size = new System.Drawing.Size(700, 608);
            this.tabNoClueYet.TabIndex = 1;
            this.tabNoClueYet.Text = "tabPage2";
            this.tabNoClueYet.UseVisualStyleBackColor = true;
            // 
            // ExiliosGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 632);
            this.Controls.Add(this.tabMain);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(726, 671);
            this.MinimumSize = new System.Drawing.Size(726, 671);
            this.Name = "ExiliosGUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExiliosGUI";
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabMainTab;
        private System.Windows.Forms.TabPage tabNoClueYet;
    }
}