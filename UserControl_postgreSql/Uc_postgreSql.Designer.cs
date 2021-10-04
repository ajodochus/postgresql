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
            this.button1 = new System.Windows.Forms.Button();
            this.start_sqlServer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mydatagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mydatagrid)).BeginInit();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "load data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // start_sqlServer
            // 
            this.start_sqlServer.Location = new System.Drawing.Point(45, 52);
            this.start_sqlServer.Name = "start_sqlServer";
            this.start_sqlServer.Size = new System.Drawing.Size(134, 23);
            this.start_sqlServer.TabIndex = 2;
            this.start_sqlServer.Text = "start sql server";
            this.start_sqlServer.UseVisualStyleBackColor = true;
            this.start_sqlServer.Click += new System.EventHandler(this.start_sqlServer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "stop sql server";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mydatagrid
            // 
            this.mydatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mydatagrid.Location = new System.Drawing.Point(45, 102);
            this.mydatagrid.Name = "mydatagrid";
            this.mydatagrid.Size = new System.Drawing.Size(436, 191);
            this.mydatagrid.TabIndex = 4;
            // 
            // Uc_postgreSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mydatagrid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.start_sqlServer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_postgreSql);
            this.Name = "Uc_postgreSql";
            this.Size = new System.Drawing.Size(700, 400);
            ((System.ComponentModel.ISupportInitialize)(this.mydatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_postgreSql;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button start_sqlServer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView mydatagrid;
    }
}
