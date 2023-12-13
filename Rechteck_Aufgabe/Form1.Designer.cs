namespace Rechteck_Aufgabe
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.widthTextbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.heightTextbox = new System.Windows.Forms.TextBox();
            this.berechnen = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // widthTextbox
            // 
            this.widthTextbox.Location = new System.Drawing.Point(561, 122);
            this.widthTextbox.Name = "widthTextbox";
            this.widthTextbox.Size = new System.Drawing.Size(435, 26);
            this.widthTextbox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(561, 664);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(435, 26);
            this.textBox1.TabIndex = 2;
            // 
            // heightTextbox
            // 
            this.heightTextbox.Location = new System.Drawing.Point(561, 223);
            this.heightTextbox.Name = "heightTextbox";
            this.heightTextbox.Size = new System.Drawing.Size(435, 26);
            this.heightTextbox.TabIndex = 3;
            this.heightTextbox.TextChanged += new System.EventHandler(this.heightTextbox_TextChanged);
            // 
            // berechnen
            // 
            this.berechnen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.berechnen.Location = new System.Drawing.Point(1259, 122);
            this.berechnen.Name = "berechnen";
            this.berechnen.Size = new System.Drawing.Size(252, 133);
            this.berechnen.TabIndex = 4;
            this.berechnen.Text = "Berechne";
            this.berechnen.UseVisualStyleBackColor = true;
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(1259, 340);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(252, 150);
            this.end.TabIndex = 5;
            this.end.Text = "end";
            this.end.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 1060);
            this.Controls.Add(this.end);
            this.Controls.Add(this.berechnen);
            this.Controls.Add(this.heightTextbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.widthTextbox);
            this.Name = "Form1";
            this.Text = "Hallo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox widthTextbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox heightTextbox;
        private System.Windows.Forms.Button berechnen;
        private System.Windows.Forms.Button end;
    }
}

