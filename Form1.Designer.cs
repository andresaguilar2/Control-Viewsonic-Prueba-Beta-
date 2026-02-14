namespace ControlProyectorViewsonic2
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxAcciones = new System.Windows.Forms.GroupBox();
            this.btnDescongelar = new System.Windows.Forms.Button();
            this.btnCongelar = new System.Windows.Forms.Button();
            this.btnPantallaNegraOff = new System.Windows.Forms.Button();
            this.btnPantallaNegraOn = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEncender = new System.Windows.Forms.Button();
            this.groupBoxEntradas = new System.Windows.Forms.GroupBox();
            this.btnComputador = new System.Windows.Forms.Button();
            this.labelUniversidad = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxAcciones.SuspendLayout();
            this.groupBoxEntradas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAcciones
            // 
            this.groupBoxAcciones.Controls.Add(this.btnDescongelar);
            this.groupBoxAcciones.Controls.Add(this.btnCongelar);
            this.groupBoxAcciones.Controls.Add(this.btnPantallaNegraOff);
            this.groupBoxAcciones.Controls.Add(this.btnPantallaNegraOn);
            this.groupBoxAcciones.Controls.Add(this.btnApagar);
            this.groupBoxAcciones.Controls.Add(this.btnEncender);
            this.groupBoxAcciones.Location = new System.Drawing.Point(12, 22);
            this.groupBoxAcciones.Name = "groupBoxAcciones";
            this.groupBoxAcciones.Size = new System.Drawing.Size(260, 270);
            this.groupBoxAcciones.TabIndex = 0;
            this.groupBoxAcciones.TabStop = false;
            this.groupBoxAcciones.Text = "Acciones";
            // 
            // btnDescongelar
            // 
            this.btnDescongelar.Location = new System.Drawing.Point(20, 219);
            this.btnDescongelar.Name = "btnDescongelar";
            this.btnDescongelar.Size = new System.Drawing.Size(220, 34);
            this.btnDescongelar.TabIndex = 5;
            this.btnDescongelar.Text = "Descongelar Pantalla";
            this.btnDescongelar.UseVisualStyleBackColor = true;
            this.btnDescongelar.Click += new System.EventHandler(this.btnDescongelar_Click);
            // 
            // btnCongelar
            // 
            this.btnCongelar.Location = new System.Drawing.Point(20, 179);
            this.btnCongelar.Name = "btnCongelar";
            this.btnCongelar.Size = new System.Drawing.Size(220, 34);
            this.btnCongelar.TabIndex = 4;
            this.btnCongelar.Text = "Congelar Pantalla";
            this.btnCongelar.UseVisualStyleBackColor = true;
            this.btnCongelar.Click += new System.EventHandler(this.btnCongelar_Click);
            // 
            // btnPantallaNegraOff
            // 
            this.btnPantallaNegraOff.Location = new System.Drawing.Point(20, 139);
            this.btnPantallaNegraOff.Name = "btnPantallaNegraOff";
            this.btnPantallaNegraOff.Size = new System.Drawing.Size(220, 34);
            this.btnPantallaNegraOff.TabIndex = 3;
            this.btnPantallaNegraOff.Text = "Desactivar Pantalla Negra";
            this.btnPantallaNegraOff.UseVisualStyleBackColor = true;
            this.btnPantallaNegraOff.Click += new System.EventHandler(this.btnPantallaNegraOff_Click);
            // 
            // btnPantallaNegraOn
            // 
            this.btnPantallaNegraOn.Location = new System.Drawing.Point(20, 99);
            this.btnPantallaNegraOn.Name = "btnPantallaNegraOn";
            this.btnPantallaNegraOn.Size = new System.Drawing.Size(220, 34);
            this.btnPantallaNegraOn.TabIndex = 2;
            this.btnPantallaNegraOn.Text = "Activar Pantalla Negra";
            this.btnPantallaNegraOn.UseVisualStyleBackColor = true;
            this.btnPantallaNegraOn.Click += new System.EventHandler(this.btnPantallaNegraOn_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(20, 59);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(220, 34);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar Proyector";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEncender
            // 
            this.btnEncender.Location = new System.Drawing.Point(20, 19);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(220, 34);
            this.btnEncender.TabIndex = 0;
            this.btnEncender.Text = "Encender Proyector";
            this.btnEncender.UseVisualStyleBackColor = true;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // groupBoxEntradas
            // 
            this.groupBoxEntradas.Controls.Add(this.btnComputador);
            this.groupBoxEntradas.Location = new System.Drawing.Point(12, 298);
            this.groupBoxEntradas.Name = "groupBoxEntradas";
            this.groupBoxEntradas.Size = new System.Drawing.Size(260, 59);
            this.groupBoxEntradas.TabIndex = 1;
            this.groupBoxEntradas.TabStop = false;
            this.groupBoxEntradas.Text = "Entradas";
            // 
            // btnComputador
            // 
            this.btnComputador.Location = new System.Drawing.Point(20, 19);
            this.btnComputador.Name = "btnComputador";
            this.btnComputador.Size = new System.Drawing.Size(220, 34);
            this.btnComputador.TabIndex = 6;
            this.btnComputador.Text = "Computador";
            this.btnComputador.UseVisualStyleBackColor = true;
            this.btnComputador.Click += new System.EventHandler(this.btnComputador_Click);
            // 
            // labelUniversidad
            // 
            this.labelUniversidad.AutoSize = true;
            this.labelUniversidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUniversidad.Location = new System.Drawing.Point(12, 370);
            this.labelUniversidad.Name = "labelUniversidad";
            this.labelUniversidad.Size = new System.Drawing.Size(247, 17);
            this.labelUniversidad.TabIndex = 2;
            this.labelUniversidad.Text = "Pontificia Universidad Javeriana ";
            this.labelUniversidad.Click += new System.EventHandler(this.labelUniversidad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 420);
            this.Controls.Add(this.labelUniversidad);
            this.Controls.Add(this.groupBoxEntradas);
            this.Controls.Add(this.groupBoxAcciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Control Proyector";
            this.groupBoxAcciones.ResumeLayout(false);
            this.groupBoxEntradas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAcciones;
        private System.Windows.Forms.Button btnEncender;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnPantallaNegraOn;
        private System.Windows.Forms.Button btnPantallaNegraOff;
        private System.Windows.Forms.Button btnCongelar;
        private System.Windows.Forms.Button btnDescongelar;
        private System.Windows.Forms.GroupBox groupBoxEntradas;
        private System.Windows.Forms.Button btnComputador;
        private System.Windows.Forms.Label labelUniversidad;
        private System.IO.Ports.SerialPort serialPort1;
    }
}
