namespace UserControl_postgreSql
{
    partial class Uc_postgreSql
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
            this.lbl_postgreSql = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_postgreSql
            // 
            this.lbl_postgreSql.AutoSize = true;
            this.lbl_postgreSql.Location = new System.Drawing.Point(3, 0);
            this.lbl_postgreSql.Name = "lbl_postgreSql";
            this.lbl_postgreSql.Size = new System.Drawing.Size(57, 13);
            this.lbl_postgreSql.TabIndex = 0;
            this.lbl_postgreSql.Text = "postgreSql";
            // 
            // Uc_postgreSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_postgreSql);
            this.Name = "Uc_postgreSql";
            this.Size = new System.Drawing.Size(700, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_postgreSql;
    }
}
