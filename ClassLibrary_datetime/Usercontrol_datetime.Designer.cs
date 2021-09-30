namespace Usercontrol_datetime
{
    partial class Usercontrol_datetime
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
            this.tb_date_today = new System.Windows.Forms.TextBox();
            this.tb_set_date = new System.Windows.Forms.TextBox();
            this.btn_reset_date = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // tb_date_today
            // 
            this.tb_date_today.Location = new System.Drawing.Point(43, 37);
            this.tb_date_today.Name = "tb_date_today";
            this.tb_date_today.ReadOnly = true;
            this.tb_date_today.Size = new System.Drawing.Size(150, 20);
            this.tb_date_today.TabIndex = 0;
            // 
            // tb_set_date
            // 
            this.tb_set_date.Location = new System.Drawing.Point(43, 108);
            this.tb_set_date.Name = "tb_set_date";
            this.tb_set_date.Size = new System.Drawing.Size(150, 20);
            this.tb_set_date.TabIndex = 1;
            this.tb_set_date.Text = "01.01.2001";
            // 
            // btn_reset_date
            // 
            this.btn_reset_date.Location = new System.Drawing.Point(275, 33);
            this.btn_reset_date.Name = "btn_reset_date";
            this.btn_reset_date.Size = new System.Drawing.Size(75, 23);
            this.btn_reset_date.TabIndex = 2;
            this.btn_reset_date.Text = "reset date";
            this.btn_reset_date.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "set system date";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Usercontrol_datetime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_reset_date);
            this.Controls.Add(this.tb_set_date);
            this.Controls.Add(this.tb_date_today);
            this.Name = "Usercontrol_datetime";
            this.Size = new System.Drawing.Size(467, 392);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_date_today;
        private System.Windows.Forms.TextBox tb_set_date;
        private System.Windows.Forms.Button btn_reset_date;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
