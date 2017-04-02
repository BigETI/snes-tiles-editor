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
            this.snesPaletteEditor1 = new SNESTilesEditor.SNESPaletteEditor();
            this.languagesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // languagesPanel
            // 
            this.languagesPanel.Controls.Add(this.languagesComboBox);
            this.languagesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.languagesPanel.HorizontalScrollbarBarColor = true;
            this.languagesPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.languagesPanel.HorizontalScrollbarSize = 8;
            this.languagesPanel.Location = new System.Drawing.Point(15, 431);
            this.languagesPanel.Margin = new System.Windows.Forms.Padding(2);
            this.languagesPanel.Name = "languagesPanel";
            this.languagesPanel.Size = new System.Drawing.Size(570, 41);
            this.languagesPanel.Style = MetroFramework.MetroColorStyle.Lime;
            this.languagesPanel.TabIndex = 0;
            this.languagesPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.languagesPanel.VerticalScrollbarBarColor = true;
            this.languagesPanel.VerticalScrollbarHighlightOnWheel = false;
            this.languagesPanel.VerticalScrollbarSize = 8;
            // 
            // languagesComboBox
            // 
            this.languagesComboBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.languagesComboBox.FormattingEnabled = true;
            this.languagesComboBox.ItemHeight = 23;
            this.languagesComboBox.Location = new System.Drawing.Point(382, 0);
            this.languagesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.languagesComboBox.Name = "languagesComboBox";
            this.languagesComboBox.PromptText = "{$SELECT_LANGUAGE$}";
            this.languagesComboBox.Size = new System.Drawing.Size(188, 29);
            this.languagesComboBox.Style = MetroFramework.MetroColorStyle.Lime;
            this.languagesComboBox.TabIndex = 2;
            this.languagesComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.languagesComboBox.UseSelectable = true;
            // 
            // snesPaletteEditor1
            // 
            this.snesPaletteEditor1.Location = new System.Drawing.Point(15, 62);
            this.snesPaletteEditor1.Margin = new System.Windows.Forms.Padding(2);
            this.snesPaletteEditor1.Name = "snesPaletteEditor1";
            this.snesPaletteEditor1.Size = new System.Drawing.Size(568, 365);
            this.snesPaletteEditor1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 488);
            this.Controls.Add(this.snesPaletteEditor1);
            this.Controls.Add(this.languagesPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "{$SNES_TILES_EDITOR$}";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.languagesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel languagesPanel;
        private MetroFramework.Controls.MetroComboBox languagesComboBox;
        private SNESPaletteEditor snesPaletteEditor1;
    }
}

