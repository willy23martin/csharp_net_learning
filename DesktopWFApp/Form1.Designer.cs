namespace DesktopWFApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ScoreFirstDeliveryButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ScoreFirstDeliveryButton
            // 
            this.ScoreFirstDeliveryButton.Location = new System.Drawing.Point(231, 36);
            this.ScoreFirstDeliveryButton.Name = "ScoreFirstDeliveryButton";
            this.ScoreFirstDeliveryButton.Size = new System.Drawing.Size(142, 26);
            this.ScoreFirstDeliveryButton.TabIndex = 0;
            this.ScoreFirstDeliveryButton.Text = "Score First Delivery";
            this.ScoreFirstDeliveryButton.UseVisualStyleBackColor = true;
            this.ScoreFirstDeliveryButton.Click += new System.EventHandler(this.Score_First_Delivery_Click);
            this.ScoreFirstDeliveryButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Score_First_Delivery_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(253, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ScoreFirstDeliveryButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ScoreFirstDeliveryButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

