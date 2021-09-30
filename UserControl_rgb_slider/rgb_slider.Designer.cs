namespace UserControl_rgb_slider
{
    partial class rgb_slider
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
            this.tb_red = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_green = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_blue = new System.Windows.Forms.TrackBar();
            this.panel_color = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_blue)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_red
            // 
            this.tb_red.Location = new System.Drawing.Point(111, 112);
            this.tb_red.Maximum = 255;
            this.tb_red.Name = "tb_red";
            this.tb_red.Size = new System.Drawing.Size(407, 45);
            this.tb_red.TabIndex = 0;
            this.tb_red.TickFrequency = 5;
            this.tb_red.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "green";
            // 
            // tb_green
            // 
            this.tb_green.Location = new System.Drawing.Point(111, 165);
            this.tb_green.Maximum = 255;
            this.tb_green.Name = "tb_green";
            this.tb_green.Size = new System.Drawing.Size(407, 45);
            this.tb_green.TabIndex = 2;
            this.tb_green.TickFrequency = 5;
            this.tb_green.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "blue";
            // 
            // tb_blue
            // 
            this.tb_blue.Location = new System.Drawing.Point(111, 218);
            this.tb_blue.Maximum = 255;
            this.tb_blue.Name = "tb_blue";
            this.tb_blue.Size = new System.Drawing.Size(407, 45);
            this.tb_blue.TabIndex = 4;
            this.tb_blue.TickFrequency = 5;
            this.tb_blue.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // panel_color
            // 
            this.panel_color.BackColor = System.Drawing.Color.Black;
            this.panel_color.Location = new System.Drawing.Point(111, 269);
            this.panel_color.Name = "panel_color";
            this.panel_color.Size = new System.Drawing.Size(407, 70);
            this.panel_color.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Simple RGB Slider";
            // 
            // rgb_slider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel_color);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_blue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_green);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_red);
            this.Name = "rgb_slider";
            this.Size = new System.Drawing.Size(700, 400);
            ((System.ComponentModel.ISupportInitialize)(this.tb_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tb_red;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tb_green;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tb_blue;
        private System.Windows.Forms.Panel panel_color;
        private System.Windows.Forms.Label label4;
    }
}
