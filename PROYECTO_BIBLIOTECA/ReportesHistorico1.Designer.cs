namespace PROYECTO_BIBLIOTECA
{
    partial class ReportesHistorico1
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnlimpiar = new Button();
            btnbuscar = new Button();
            btnexportar = new Button();
            cmbTipoLibro = new ComboBox();
            cmbEncargado = new ComboBox();
            cmbFechaInicio = new ComboBox();
            cmbFechaFin = new ComboBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            dgvReporte = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Distrito = new DataGridViewTextBoxColumn();
            Encargado = new DataGridViewTextBoxColumn();
            Fecha_Inicio = new DataGridViewTextBoxColumn();
            Fecha_Fin = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 20);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Reporte Historico";
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(912, 63);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(115, 32);
            btnlimpiar.TabIndex = 1;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(1047, 63);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(114, 32);
            btnbuscar.TabIndex = 2;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btnexportar
            // 
            btnexportar.Location = new Point(39, 209);
            btnexportar.Name = "btnexportar";
            btnexportar.Size = new Size(134, 31);
            btnexportar.TabIndex = 3;
            btnexportar.Text = "Exportar";
            btnexportar.UseVisualStyleBackColor = true;
            // 
            // cmbTipoLibro
            // 
            cmbTipoLibro.FormattingEnabled = true;
            cmbTipoLibro.Location = new Point(9, 67);
            cmbTipoLibro.Name = "cmbTipoLibro";
            cmbTipoLibro.Size = new Size(201, 28);
            cmbTipoLibro.TabIndex = 4;
            // 
            // cmbEncargado
            // 
            cmbEncargado.FormattingEnabled = true;
            cmbEncargado.Location = new Point(228, 67);
            cmbEncargado.Name = "cmbEncargado";
            cmbEncargado.Size = new Size(201, 28);
            cmbEncargado.TabIndex = 10;
            // 
            // cmbFechaInicio
            // 
            cmbFechaInicio.FormattingEnabled = true;
            cmbFechaInicio.Location = new Point(450, 67);
            cmbFechaInicio.Name = "cmbFechaInicio";
            cmbFechaInicio.Size = new Size(201, 28);
            cmbFechaInicio.TabIndex = 11;
            // 
            // cmbFechaFin
            // 
            cmbFechaFin.FormattingEnabled = true;
            cmbFechaFin.Location = new Point(673, 67);
            cmbFechaFin.Name = "cmbFechaFin";
            cmbFechaFin.Size = new Size(201, 28);
            cmbFechaFin.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(673, 44);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 14;
            label5.Text = "Fecha de Fin";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cmbFechaFin);
            groupBox1.Controls.Add(cmbFechaInicio);
            groupBox1.Controls.Add(cmbEncargado);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbTipoLibro);
            groupBox1.Controls.Add(btnbuscar);
            groupBox1.Controls.Add(btnlimpiar);
            groupBox1.Location = new Point(39, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1176, 136);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Biblioteca Digital";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(450, 44);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 13;
            label8.Text = "Fecha Inicio";
            label8.Click += label4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(228, 44);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 9;
            label7.Text = "Encargado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 44);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 8;
            label6.Text = "Tipo de Libro";
            // 
            // dgvReporte
            // 
            dgvReporte.AllowUserToDeleteRows = false;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Columns.AddRange(new DataGridViewColumn[] { ID, Cliente, Tipo, DNI, Distrito, Encargado, Fecha_Inicio, Fecha_Fin });
            dgvReporte.Location = new Point(16, 259);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporte.Size = new Size(1199, 312);
            dgvReporte.TabIndex = 16;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            DNI.ReadOnly = true;
            // 
            // Distrito
            // 
            Distrito.HeaderText = "Distrito";
            Distrito.Name = "Distrito";
            Distrito.ReadOnly = true;
            // 
            // Encargado
            // 
            Encargado.HeaderText = "Encargado";
            Encargado.Name = "Encargado";
            Encargado.ReadOnly = true;
            // 
            // Fecha_Inicio
            // 
            Fecha_Inicio.HeaderText = "Fecha de Inicio";
            Fecha_Inicio.Name = "Fecha_Inicio";
            Fecha_Inicio.ReadOnly = true;
            // 
            // Fecha_Fin
            // 
            Fecha_Fin.HeaderText = "Fecha de Fin";
            Fecha_Fin.Name = "Fecha_Fin";
            Fecha_Fin.ReadOnly = true;
            // 
            // ReportesHistorico1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvReporte);
            Controls.Add(groupBox1);
            Controls.Add(btnexportar);
            Controls.Add(label1);
            Name = "ReportesHistorico1";
            Size = new Size(1233, 585);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnlimpiar;
        private Button btnbuscar;
        private Button btnexportar;
        private ComboBox cmbTipoLibro;
        private ComboBox cmbEncargado;
        private ComboBox cmbFechaInicio;
        private ComboBox cmbFechaFin;
        private Label label5;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private DataGridView dgvReporte;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Distrito;
        private DataGridViewTextBoxColumn Encargado;
        private DataGridViewTextBoxColumn Fecha_Inicio;
        private DataGridViewTextBoxColumn Fecha_Fin;
    }
}
