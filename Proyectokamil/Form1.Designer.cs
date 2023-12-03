namespace Proyectokamil
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAgregarE = new System.Windows.Forms.Button();
            this.btnVerE = new System.Windows.Forms.Button();
            this.btnAgregarD = new System.Windows.Forms.Button();
            this.btnVerD = new System.Windows.Forms.Button();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.btnVerC = new System.Windows.Forms.Button();
            this.lblDirectivos = new System.Windows.Forms.Label();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.lblCentros = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proyecto kamil";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.lblEmpleados);
            this.groupBox1.Controls.Add(this.btnVerE);
            this.groupBox1.Controls.Add(this.btnAgregarE);
            this.groupBox1.Location = new System.Drawing.Point(43, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 296);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleados";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox2.Controls.Add(this.lblDirectivos);
            this.groupBox2.Controls.Add(this.btnAgregarD);
            this.groupBox2.Controls.Add(this.btnVerD);
            this.groupBox2.Location = new System.Drawing.Point(328, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 296);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Directivos";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox3.Controls.Add(this.lblCentros);
            this.groupBox3.Controls.Add(this.btnVerC);
            this.groupBox3.Controls.Add(this.btnAgregarC);
            this.groupBox3.Location = new System.Drawing.Point(602, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 296);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Centros";
            // 
            // btnAgregarE
            // 
            this.btnAgregarE.BackColor = System.Drawing.Color.Yellow;
            this.btnAgregarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarE.Location = new System.Drawing.Point(25, 55);
            this.btnAgregarE.Name = "btnAgregarE";
            this.btnAgregarE.Size = new System.Drawing.Size(136, 57);
            this.btnAgregarE.TabIndex = 0;
            this.btnAgregarE.Text = "Agregar Empleados";
            this.btnAgregarE.UseVisualStyleBackColor = false;
            this.btnAgregarE.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVerE
            // 
            this.btnVerE.BackColor = System.Drawing.Color.Yellow;
            this.btnVerE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerE.Location = new System.Drawing.Point(25, 170);
            this.btnVerE.Name = "btnVerE";
            this.btnVerE.Size = new System.Drawing.Size(136, 57);
            this.btnVerE.TabIndex = 1;
            this.btnVerE.Text = "Ver Empleados";
            this.btnVerE.UseVisualStyleBackColor = false;
            // 
            // btnAgregarD
            // 
            this.btnAgregarD.BackColor = System.Drawing.Color.Yellow;
            this.btnAgregarD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarD.Location = new System.Drawing.Point(27, 55);
            this.btnAgregarD.Name = "btnAgregarD";
            this.btnAgregarD.Size = new System.Drawing.Size(136, 57);
            this.btnAgregarD.TabIndex = 2;
            this.btnAgregarD.Text = "Agregar Directivos";
            this.btnAgregarD.UseVisualStyleBackColor = false;
            // 
            // btnVerD
            // 
            this.btnVerD.BackColor = System.Drawing.Color.Yellow;
            this.btnVerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerD.Location = new System.Drawing.Point(27, 170);
            this.btnVerD.Name = "btnVerD";
            this.btnVerD.Size = new System.Drawing.Size(136, 57);
            this.btnVerD.TabIndex = 3;
            this.btnVerD.Text = "Ver Directivos";
            this.btnVerD.UseVisualStyleBackColor = false;
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.BackColor = System.Drawing.Color.Yellow;
            this.btnAgregarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarC.Location = new System.Drawing.Point(35, 55);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(136, 57);
            this.btnAgregarC.TabIndex = 4;
            this.btnAgregarC.Text = "Agregar Centros";
            this.btnAgregarC.UseVisualStyleBackColor = false;
            // 
            // btnVerC
            // 
            this.btnVerC.BackColor = System.Drawing.Color.Yellow;
            this.btnVerC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerC.Location = new System.Drawing.Point(35, 170);
            this.btnVerC.Name = "btnVerC";
            this.btnVerC.Size = new System.Drawing.Size(136, 57);
            this.btnVerC.TabIndex = 5;
            this.btnVerC.Text = "Ver Centros";
            this.btnVerC.UseVisualStyleBackColor = false;
            // 
            // lblDirectivos
            // 
            this.lblDirectivos.AutoSize = true;
            this.lblDirectivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectivos.Location = new System.Drawing.Point(61, 16);
            this.lblDirectivos.Name = "lblDirectivos";
            this.lblDirectivos.Size = new System.Drawing.Size(70, 15);
            this.lblDirectivos.TabIndex = 4;
            this.lblDirectivos.Text = "Directivos";
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.Location = new System.Drawing.Point(52, 16);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(79, 15);
            this.lblEmpleados.TabIndex = 5;
            this.lblEmpleados.Text = "Empleados";
            // 
            // lblCentros
            // 
            this.lblCentros.AutoSize = true;
            this.lblCentros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentros.Location = new System.Drawing.Point(67, 16);
            this.lblCentros.Name = "lblCentros";
            this.lblCentros.Size = new System.Drawing.Size(56, 15);
            this.lblCentros.TabIndex = 6;
            this.lblCentros.Text = "Centros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarD;
        private System.Windows.Forms.Button btnVerE;
        private System.Windows.Forms.Button btnAgregarE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVerC;
        private System.Windows.Forms.Button btnAgregarC;
        private System.Windows.Forms.Button btnVerD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Label lblDirectivos;
        private System.Windows.Forms.Label lblCentros;
    }
}

