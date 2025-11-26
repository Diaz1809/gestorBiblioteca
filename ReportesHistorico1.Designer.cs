namespace PROYECTO_BIBLIOTECA
{
    partial class ReportesHistorico1 : UserControl 
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
            comboBox1 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            nro = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Distrito = new DataGridViewTextBoxColumn();
            Encargado = new DataGridViewTextBoxColumn();
            Fecha_Inicio = new DataGridViewTextBoxColumn();
            Fecha_Fin = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(19, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 28);
            comboBox1.TabIndex = 0;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(478, 56);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(171, 28);
            comboBox3.TabIndex = 2;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(251, 56);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(171, 28);
            comboBox4.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(703, 56);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(171, 28);
            comboBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(22, 12);
            label1.Name = "label1";
            label1.Size = new Size(185, 24);
            label1.TabIndex = 5;
            label1.Text = "Reporte Historico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 33);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 6;
            label2.Text = "Tipo de Libro";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 33);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 7;
            label3.Text = "Encargado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(703, 33);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 8;
            label4.Text = "Fecha de Fin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(478, 33);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 8;
            label5.Text = "Fecha de Inicio";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(22, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(893, 159);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Biblioteca Digital";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(727, 105);
            button2.Name = "button2";
            button2.Size = new Size(147, 39);
            button2.TabIndex = 10;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.MidnightBlue;
            button1.Location = new Point(547, 105);
            button1.Name = "button1";
            button1.Size = new Size(147, 39);
            button1.TabIndex = 9;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumAquamarine;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(41, 211);
            button3.Name = "button3";
            button3.Size = new Size(155, 39);
            button3.TabIndex = 10;
            button3.Text = "Exportar";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nro, Cliente, Tipo, DNI, Distrito, Encargado, Fecha_Inicio, Fecha_Fin });
            dataGridView1.Location = new Point(22, 263);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(896, 259);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nro
            // 
            nro.HeaderText = "#";
            nro.Name = "nro";
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            // 
            // Distrito
            // 
            Distrito.HeaderText = "Distrito";
            Distrito.Name = "Distrito";
            // 
            // Encargado
            // 
            Encargado.HeaderText = "Encargado";
            Encargado.Name = "Encargado";
            // 
            // Fecha_Inicio
            // 
            Fecha_Inicio.HeaderText = "Fecha Inicio";
            Fecha_Inicio.Name = "Fecha_Inicio";
            // 
            // Fecha_Fin
            // 
            Fecha_Fin.HeaderText = "Fecha Fin";
            Fecha_Fin.Name = "Fecha_Fin";
            // 
            // ReportesHistorico1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ReportesHistorico1";
            Size = new Size(938, 534);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nro;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Distrito;
        private DataGridViewTextBoxColumn Encargado;
        private DataGridViewTextBoxColumn Fecha_Inicio;
        private DataGridViewTextBoxColumn Fecha_Fin;
    }
}
