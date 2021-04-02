
namespace Actividad_Integradora_4_Problema_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCaptura = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNombreSueldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCaptura
            // 
            this.btnCaptura.Location = new System.Drawing.Point(178, 338);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(188, 58);
            this.btnCaptura.TabIndex = 0;
            this.btnCaptura.Text = "Capturar";
            this.btnCaptura.UseVisualStyleBackColor = true;
            this.btnCaptura.Click += new System.EventHandler(this.btnCaptura_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(261, 99);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 47);
            this.txtNombre.TabIndex = 1;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(261, 213);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(250, 47);
            this.txtSalario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Salario:";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContador.Location = new System.Drawing.Point(682, 135);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(77, 89);
            this.lblContador.TabIndex = 5;
            this.lblContador.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(642, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1144, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 41);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total a Pagar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(996, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(497, 41);
            this.label5.TabIndex = 8;
            this.label5.Text = "Empleado Mayor ingreso Generado:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1180, 183);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 41);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "0";
            // 
            // lblNombreSueldo
            // 
            this.lblNombreSueldo.AutoSize = true;
            this.lblNombreSueldo.Location = new System.Drawing.Point(1117, 319);
            this.lblNombreSueldo.Name = "lblNombreSueldo";
            this.lblNombreSueldo.Size = new System.Drawing.Size(128, 41);
            this.lblNombreSueldo.TabIndex = 10;
            this.lblNombreSueldo.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 538);
            this.Controls.Add(this.lblNombreSueldo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCaptura);
            this.Name = "Form1";
            this.Text = "  ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCaptura;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNombreSueldo;
    }
}

