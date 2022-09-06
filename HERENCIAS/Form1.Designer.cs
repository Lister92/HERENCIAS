
namespace HERENCIA
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textArea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioRect = new System.Windows.Forms.RadioButton();
            this.radioTri = new System.Windows.Forms.RadioButton();
            this.radioCirculo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Do it";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(432, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Do it Random";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textArea
            // 
            this.textArea.Location = new System.Drawing.Point(170, 286);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(117, 22);
            this.textArea.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Area";
            // 
            // radioRect
            // 
            this.radioRect.AutoSize = true;
            this.radioRect.Location = new System.Drawing.Point(7, 21);
            this.radioRect.Name = "radioRect";
            this.radioRect.Size = new System.Drawing.Size(101, 21);
            this.radioRect.TabIndex = 8;
            this.radioRect.TabStop = true;
            this.radioRect.Text = "Rectangulo";
            this.radioRect.UseVisualStyleBackColor = true;
            this.radioRect.CheckedChanged += new System.EventHandler(this.radioRect_CheckedChanged);
            // 
            // radioTri
            // 
            this.radioTri.AutoSize = true;
            this.radioTri.Location = new System.Drawing.Point(7, 60);
            this.radioTri.Name = "radioTri";
            this.radioTri.Size = new System.Drawing.Size(89, 21);
            this.radioTri.TabIndex = 9;
            this.radioTri.TabStop = true;
            this.radioTri.Text = "Triangulo";
            this.radioTri.UseVisualStyleBackColor = true;
            this.radioTri.CheckedChanged += new System.EventHandler(this.radioTri_CheckedChanged);
            // 
            // radioCirculo
            // 
            this.radioCirculo.AutoSize = true;
            this.radioCirculo.Location = new System.Drawing.Point(7, 98);
            this.radioCirculo.Name = "radioCirculo";
            this.radioCirculo.Size = new System.Drawing.Size(72, 21);
            this.radioCirculo.TabIndex = 10;
            this.radioCirculo.TabStop = true;
            this.radioCirculo.Text = "Circulo";
            this.radioCirculo.UseVisualStyleBackColor = true;
            this.radioCirculo.CheckedChanged += new System.EventHandler(this.radioCirculo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioRect);
            this.groupBox1.Controls.Add(this.radioCirculo);
            this.groupBox1.Controls.Add(this.radioTri);
            this.groupBox1.Location = new System.Drawing.Point(432, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 134);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formas 2D";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioRect;
        private System.Windows.Forms.RadioButton radioTri;
        private System.Windows.Forms.RadioButton radioCirculo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

