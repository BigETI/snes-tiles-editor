﻿namespace SNESTilesEditor
{
    partial class SNESPaletteControl
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
            this.SuspendLayout();
            // 
            // SNESPaletteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DoubleBuffered = true;
            this.Name = "SNESPaletteControl";
            this.Size = new System.Drawing.Size(256, 256);
            this.Click += new System.EventHandler(this.SNESPaletteControl_Click);
            this.Leave += new System.EventHandler(this.SNESPaletteControl_Leave);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SNESPaletteControl_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}