namespace SNESTilesEditor
{
    partial class MainForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.languagesPanel = new MetroFramework.Controls.MetroPanel();
            this.languagesComboBox = new MetroFramework.Controls.MetroComboBox();
            this.languagesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // languagesPanel
            // 
            this.languagesPanel.Controls.Add(this.languagesComboBox);
            this.languagesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.languagesPanel.HorizontalScrollbarBarColor = true;
            this.languagesPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.languagesPanel.HorizontalScrollbarSize = 10;
            this.languagesPanel.Location = new System.Drawing.Point(20, 530);
            this.languagesPanel.Name = "languagesPanel";
            this.languagesPanel.Size = new System.Drawing.Size(760, 50);
            this.languagesPanel.Style = MetroFramework.MetroColorStyle.Lime;
            this.languagesPanel.TabIndex = 0;
            this.languagesPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.languagesPanel.VerticalScrollbarBarColor = true;
            this.languagesPanel.VerticalScrollbarHighlightOnWheel = false;
            this.languagesPanel.VerticalScrollbarSize = 10;
            // 
            // languagesComboBox
            // 
            this.languagesComboBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.languagesComboBox.FormattingEnabled = true;
            this.languagesComboBox.ItemHeight = 24;
            this.languagesComboBox.Location = new System.Drawing.Point(510, 0);
            this.languagesComboBox.Name = "languagesComboBox";
            this.languagesComboBox.PromptText = "{$SELECT_LANGUAGE$}";
            this.languagesComboBox.Size = new System.Drawing.Size(250, 30);
            this.languagesComboBox.Style = MetroFramework.MetroColorStyle.Lime;
            this.languagesComboBox.TabIndex = 2;
            this.languagesComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.languagesComboBox.UseSelectable = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.languagesPanel);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "{$SNES_TILES_EDITOR$}";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.languagesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel languagesPanel;
        private MetroFramework.Controls.MetroComboBox languagesComboBox;
    }
}

