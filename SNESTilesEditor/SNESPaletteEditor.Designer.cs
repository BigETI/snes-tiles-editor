namespace SNESTilesEditor
{
    partial class SNESPaletteEditor
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.selectColorButton = new MetroFramework.Controls.MetroButton();
            this.colorRGBLabel = new MetroFramework.Controls.MetroLabel();
            this.colorSNESLabel = new MetroFramework.Controls.MetroLabel();
            this.selectedColorPanel = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.paletteControl = new SNESTilesEditor.SNESPaletteControl();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.paletteControl);
            this.mainPanel.Controls.Add(this.selectColorButton);
            this.mainPanel.Controls.Add(this.colorRGBLabel);
            this.mainPanel.Controls.Add(this.colorSNESLabel);
            this.mainPanel.Controls.Add(this.selectedColorPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 8;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(450, 488);
            this.mainPanel.Style = MetroFramework.MetroColorStyle.Lime;
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 8;
            // 
            // selectColorButton
            // 
            this.selectColorButton.Location = new System.Drawing.Point(335, 44);
            this.selectColorButton.Name = "selectColorButton";
            this.selectColorButton.Size = new System.Drawing.Size(30, 23);
            this.selectColorButton.Style = MetroFramework.MetroColorStyle.Lime;
            this.selectColorButton.TabIndex = 6;
            this.selectColorButton.Text = "...";
            this.selectColorButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.selectColorButton.UseSelectable = true;
            this.selectColorButton.Click += new System.EventHandler(this.selectColorButton_Click);
            // 
            // colorRGBLabel
            // 
            this.colorRGBLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorRGBLabel.Location = new System.Drawing.Point(265, 93);
            this.colorRGBLabel.Name = "colorRGBLabel";
            this.colorRGBLabel.Size = new System.Drawing.Size(182, 19);
            this.colorRGBLabel.Style = MetroFramework.MetroColorStyle.Lime;
            this.colorRGBLabel.TabIndex = 5;
            this.colorRGBLabel.Text = "RGB: 0x000000";
            this.colorRGBLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // colorSNESLabel
            // 
            this.colorSNESLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorSNESLabel.Location = new System.Drawing.Point(265, 70);
            this.colorSNESLabel.Name = "colorSNESLabel";
            this.colorSNESLabel.Size = new System.Drawing.Size(182, 23);
            this.colorSNESLabel.Style = MetroFramework.MetroColorStyle.Lime;
            this.colorSNESLabel.TabIndex = 4;
            this.colorSNESLabel.Text = "SNES: 0x0000";
            this.colorSNESLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // selectedColorPanel
            // 
            this.selectedColorPanel.Location = new System.Drawing.Point(265, 3);
            this.selectedColorPanel.Name = "selectedColorPanel";
            this.selectedColorPanel.Size = new System.Drawing.Size(64, 64);
            this.selectedColorPanel.TabIndex = 3;
            // 
            // paletteControl
            // 
            this.paletteControl.Location = new System.Drawing.Point(3, 3);
            this.paletteControl.Name = "paletteControl";
            this.paletteControl.Size = new System.Drawing.Size(256, 256);
            this.paletteControl.TabIndex = 7;
            // 
            // SNESPaletteEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SNESPaletteEditor";
            this.Size = new System.Drawing.Size(450, 488);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mainPanel;
        private System.Windows.Forms.Panel selectedColorPanel;
        private MetroFramework.Controls.MetroLabel colorRGBLabel;
        private MetroFramework.Controls.MetroLabel colorSNESLabel;
        private MetroFramework.Controls.MetroButton selectColorButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private SNESPaletteControl paletteControl;
    }
}
