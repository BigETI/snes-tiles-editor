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
            this.mainTabControl = new MetroFramework.Controls.MetroTabControl();
            this.projectsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.settingsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.languagesPanel.SuspendLayout();
            this.mainTabControl.SuspendLayout();
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
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.projectsTabPage);
            this.mainTabControl.Controls.Add(this.settingsTabPage);
            this.mainTabControl.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.mainTabControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.mainTabControl.Location = new System.Drawing.Point(15, 63);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 1;
            this.mainTabControl.Size = new System.Drawing.Size(570, 363);
            this.mainTabControl.Style = MetroFramework.MetroColorStyle.Lime;
            this.mainTabControl.TabIndex = 1;
            this.mainTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mainTabControl.UseSelectable = true;
            // 
            // projectsTabPage
            // 
            this.projectsTabPage.HorizontalScrollbarBarColor = true;
            this.projectsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.projectsTabPage.HorizontalScrollbarSize = 10;
            this.projectsTabPage.Location = new System.Drawing.Point(4, 38);
            this.projectsTabPage.Name = "projectsTabPage";
            this.projectsTabPage.Size = new System.Drawing.Size(562, 321);
            this.projectsTabPage.Style = MetroFramework.MetroColorStyle.Lime;
            this.projectsTabPage.TabIndex = 0;
            this.projectsTabPage.Text = "{$PROJECTS$}";
            this.projectsTabPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.projectsTabPage.VerticalScrollbarBarColor = true;
            this.projectsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.projectsTabPage.VerticalScrollbarSize = 10;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.HorizontalScrollbarBarColor = true;
            this.settingsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.settingsTabPage.HorizontalScrollbarSize = 10;
            this.settingsTabPage.Location = new System.Drawing.Point(4, 38);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Size = new System.Drawing.Size(562, 321);
            this.settingsTabPage.Style = MetroFramework.MetroColorStyle.Lime;
            this.settingsTabPage.TabIndex = 1;
            this.settingsTabPage.Text = "{$SETTINGS$}";
            this.settingsTabPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.settingsTabPage.VerticalScrollbarBarColor = true;
            this.settingsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.settingsTabPage.VerticalScrollbarSize = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 488);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.languagesPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "{$SNES_TILES_EDITOR$}";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.languagesPanel.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel languagesPanel;
        private MetroFramework.Controls.MetroComboBox languagesComboBox;
        private MetroFramework.Controls.MetroTabControl mainTabControl;
        private MetroFramework.Controls.MetroTabPage projectsTabPage;
        private MetroFramework.Controls.MetroTabPage settingsTabPage;
    }
}

