namespace Comercial_Solutions.Forms.Areas.Logistica
{
    partial class frm_asignacion_vehiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_vehiculos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_usovehiculo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_ubicacion = new System.Windows.Forms.ComboBox();
            this.cmb_ruta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.barra1 = new Navegador.Barra();
            this.dt_VxR = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_VxR)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_vehiculos
            // 
            this.cmb_vehiculos.FormattingEnabled = true;
            this.cmb_vehiculos.Location = new System.Drawing.Point(105, 70);
            this.cmb_vehiculos.Name = "cmb_vehiculos";
            this.cmb_vehiculos.Size = new System.Drawing.Size(121, 21);
            this.cmb_vehiculos.TabIndex = 0;
            this.cmb_vehiculos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(43, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vehiculos:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_usovehiculo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_ubicacion);
            this.groupBox1.Controls.Add(this.cmb_ruta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 96);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descripcion de Ruta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Uso:";
            // 
            // cmb_usovehiculo
            // 
            this.cmb_usovehiculo.FormattingEnabled = true;
            this.cmb_usovehiculo.Items.AddRange(new object[] {
            "Ruta",
            "Apoyo",
            "Emergencia"});
            this.cmb_usovehiculo.Location = new System.Drawing.Point(257, 29);
            this.cmb_usovehiculo.Name = "cmb_usovehiculo";
            this.cmb_usovehiculo.Size = new System.Drawing.Size(121, 21);
            this.cmb_usovehiculo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ubicacion:";
            // 
            // cmb_ubicacion
            // 
            this.cmb_ubicacion.FormattingEnabled = true;
            this.cmb_ubicacion.Location = new System.Drawing.Point(87, 29);
            this.cmb_ubicacion.Name = "cmb_ubicacion";
            this.cmb_ubicacion.Size = new System.Drawing.Size(121, 21);
            this.cmb_ubicacion.TabIndex = 10;
            this.cmb_ubicacion.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cmb_ruta
            // 
            this.cmb_ruta.FormattingEnabled = true;
            this.cmb_ruta.Location = new System.Drawing.Point(87, 59);
            this.cmb_ruta.Name = "cmb_ruta";
            this.cmb_ruta.Size = new System.Drawing.Size(121, 21);
            this.cmb_ruta.TabIndex = 8;
            this.cmb_ruta.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ruta:";
            this.label2.Visible = false;
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Transparent;
            this.barra1.Location = new System.Drawing.Point(11, 11);
            this.barra1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(268, 42);
            this.barra1.TabIndex = 8;
            this.barra1.click_guardar_button += new Navegador.Barra.delegadoButton(this.barra1_click_guardar_button);
            this.barra1.click_buscar_button += new Navegador.Barra.delegadoButton(this.barra1_click_buscar_button);
            this.barra1.click_actualizar_button += new Navegador.Barra.delegadoButton(this.barra1_click_actualizar_button);
            // 
            // dt_VxR
            // 
            this.dt_VxR.AllowUserToAddRows = false;
            this.dt_VxR.AllowUserToDeleteRows = false;
            this.dt_VxR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_VxR.Enabled = false;
            this.dt_VxR.Location = new System.Drawing.Point(20, 222);
            this.dt_VxR.Name = "dt_VxR";
            this.dt_VxR.Size = new System.Drawing.Size(259, 75);
            this.dt_VxR.TabIndex = 9;
            this.dt_VxR.Visible = false;
            // 
            // frm_asignacion_vehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(424, 311);
            this.Controls.Add(this.dt_VxR);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_vehiculos);
            this.DoubleBuffered = true;
            this.Name = "frm_asignacion_vehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion de vehiculos";
            this.Load += new System.EventHandler(this.frm_asignacion_vehiculo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_VxR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_vehiculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_ubicacion;
        private System.Windows.Forms.ComboBox cmb_ruta;
        private System.Windows.Forms.Label label2;
        private Navegador.Barra barra1;
        private System.Windows.Forms.DataGridView dt_VxR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_usovehiculo;
    }
}