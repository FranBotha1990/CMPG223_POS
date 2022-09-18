
namespace POS_Group5_CMPG223
{
    partial class FrmSettings
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.gbxBusinessSettings = new System.Windows.Forms.GroupBox();
            this.pnlBusinessName = new System.Windows.Forms.Panel();
            this.txtBusinessName = new System.Windows.Forms.TextBox();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.gbxGUISettings = new System.Windows.Forms.GroupBox();
            this.pnlColorScheme = new System.Windows.Forms.Panel();
            this.cbxColorScheme = new System.Windows.Forms.ComboBox();
            this.lblColorScheme = new System.Windows.Forms.Label();
            this.gbxBusinessSettings.SuspendLayout();
            this.pnlBusinessName.SuspendLayout();
            this.gbxGUISettings.SuspendLayout();
            this.pnlColorScheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(0, 150);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(800, 50);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Location = new System.Drawing.Point(0, 100);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(800, 50);
            this.btnSaveSettings.TabIndex = 6;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // gbxBusinessSettings
            // 
            this.gbxBusinessSettings.Controls.Add(this.pnlBusinessName);
            this.gbxBusinessSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxBusinessSettings.Location = new System.Drawing.Point(0, 50);
            this.gbxBusinessSettings.Name = "gbxBusinessSettings";
            this.gbxBusinessSettings.Size = new System.Drawing.Size(800, 50);
            this.gbxBusinessSettings.TabIndex = 5;
            this.gbxBusinessSettings.TabStop = false;
            this.gbxBusinessSettings.Text = "Business Settings";
            // 
            // pnlBusinessName
            // 
            this.pnlBusinessName.Controls.Add(this.txtBusinessName);
            this.pnlBusinessName.Controls.Add(this.lblBusinessName);
            this.pnlBusinessName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusinessName.Location = new System.Drawing.Point(3, 16);
            this.pnlBusinessName.Name = "pnlBusinessName";
            this.pnlBusinessName.Size = new System.Drawing.Size(794, 25);
            this.pnlBusinessName.TabIndex = 1;
            // 
            // txtBusinessName
            // 
            this.txtBusinessName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBusinessName.Location = new System.Drawing.Point(250, 0);
            this.txtBusinessName.Name = "txtBusinessName";
            this.txtBusinessName.Size = new System.Drawing.Size(142, 20);
            this.txtBusinessName.TabIndex = 2;
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBusinessName.Location = new System.Drawing.Point(0, 0);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblBusinessName.Size = new System.Drawing.Size(250, 25);
            this.lblBusinessName.TabIndex = 1;
            this.lblBusinessName.Text = "Business Name:";
            this.lblBusinessName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbxGUISettings
            // 
            this.gbxGUISettings.Controls.Add(this.pnlColorScheme);
            this.gbxGUISettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxGUISettings.Location = new System.Drawing.Point(0, 0);
            this.gbxGUISettings.Name = "gbxGUISettings";
            this.gbxGUISettings.Size = new System.Drawing.Size(800, 50);
            this.gbxGUISettings.TabIndex = 4;
            this.gbxGUISettings.TabStop = false;
            this.gbxGUISettings.Text = "GUI Settings";
            // 
            // pnlColorScheme
            // 
            this.pnlColorScheme.Controls.Add(this.cbxColorScheme);
            this.pnlColorScheme.Controls.Add(this.lblColorScheme);
            this.pnlColorScheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlColorScheme.Location = new System.Drawing.Point(3, 16);
            this.pnlColorScheme.Name = "pnlColorScheme";
            this.pnlColorScheme.Size = new System.Drawing.Size(794, 25);
            this.pnlColorScheme.TabIndex = 0;
            // 
            // cbxColorScheme
            // 
            this.cbxColorScheme.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxColorScheme.FormattingEnabled = true;
            this.cbxColorScheme.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.cbxColorScheme.Location = new System.Drawing.Point(250, 0);
            this.cbxColorScheme.Name = "cbxColorScheme";
            this.cbxColorScheme.Size = new System.Drawing.Size(142, 21);
            this.cbxColorScheme.TabIndex = 1;
            this.cbxColorScheme.Text = "Select a Color Scheme";
            // 
            // lblColorScheme
            // 
            this.lblColorScheme.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblColorScheme.Location = new System.Drawing.Point(0, 0);
            this.lblColorScheme.Name = "lblColorScheme";
            this.lblColorScheme.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblColorScheme.Size = new System.Drawing.Size(250, 25);
            this.lblColorScheme.TabIndex = 0;
            this.lblColorScheme.Text = "Color Scheme:";
            this.lblColorScheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.gbxBusinessSettings);
            this.Controls.Add(this.gbxGUISettings);
            this.Name = "FrmSettings";
            this.Text = "FrmSettings";
            this.gbxBusinessSettings.ResumeLayout(false);
            this.pnlBusinessName.ResumeLayout(false);
            this.pnlBusinessName.PerformLayout();
            this.gbxGUISettings.ResumeLayout(false);
            this.pnlColorScheme.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.GroupBox gbxBusinessSettings;
        private System.Windows.Forms.Panel pnlBusinessName;
        private System.Windows.Forms.TextBox txtBusinessName;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.GroupBox gbxGUISettings;
        private System.Windows.Forms.Panel pnlColorScheme;
        private System.Windows.Forms.ComboBox cbxColorScheme;
        private System.Windows.Forms.Label lblColorScheme;
    }
}