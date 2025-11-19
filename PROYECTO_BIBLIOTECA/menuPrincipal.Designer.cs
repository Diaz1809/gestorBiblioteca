namespace PROYECTO_BIBLIOTECA
{
    partial class menuPrincipal
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
            splitContainer1 = new SplitContainer();
            reports = new Label();
            panel1 = new Panel();
            label1 = new Label();
            agregar = new Button();
            panel2 = new Panel();
            buscar = new Button();
            limpiar = new Button();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            Cliente = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Distrito = new DataGridViewTextBoxColumn();
            Encargado = new DataGridViewTextBoxColumn();
            Tipolibro = new DataGridViewTextBoxColumn();
            Nombrelibro = new DataGridViewTextBoxColumn();
            Fechainicio = new DataGridViewTextBoxColumn();
            Fechafin = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.DarkBlue;
            splitContainer1.Panel1.Controls.Add(reports);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(agregar);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 172;
            splitContainer1.TabIndex = 1;
            // 
            // reports
            // 
            reports.AutoSize = true;
            reports.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reports.ForeColor = SystemColors.ControlLightLight;
            reports.Location = new Point(12, 103);
            reports.Name = "reports";
            reports.Size = new Size(120, 17);
            reports.TabIndex = 0;
            reports.Text = "Reportes historico";
            reports.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.sise;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(3, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(166, 46);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 3;
            label1.Text = "Gestión de clientes";
            // 
            // agregar
            // 
            agregar.Location = new Point(3, 170);
            agregar.Name = "agregar";
            agregar.Size = new Size(93, 29);
            agregar.TabIndex = 2;
            agregar.Text = "Agregar";
            agregar.UseVisualStyleBackColor = true;
            agregar.Click += agregar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(buscar);
            panel2.Controls.Add(limpiar);
            panel2.Controls.Add(comboBox4);
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(3, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(618, 96);
            panel2.TabIndex = 1;
            panel2.Paint += splitContainer1_Panel2_Paint;
            // 
            // buscar
            // 
            buscar.Location = new Point(534, 58);
            buscar.Name = "buscar";
            buscar.Size = new Size(75, 23);
            buscar.TabIndex = 6;
            buscar.Text = "Buscar";
            buscar.UseVisualStyleBackColor = true;
            buscar.Click += buscar_Click;
            // 
            // limpiar
            // 
            limpiar.Location = new Point(440, 58);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(75, 23);
            limpiar.TabIndex = 5;
            limpiar.Text = "Limpiar";
            limpiar.UseVisualStyleBackColor = true;
            limpiar.Click += limpiar_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(488, 15);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 3;
            comboBox4.Text = "Estado";
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(336, 15);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(136, 23);
            comboBox3.TabIndex = 2;
            comboBox3.Text = "Tipo de libro";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(170, 15);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(150, 23);
            comboBox2.TabIndex = 1;
            comboBox2.Text = "Encargado";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(13, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Cliente";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cliente, Tipo, DNI, Distrito, Encargado, Tipolibro, Nombrelibro, Fechainicio, Fechafin, Estado });
            dataGridView1.Location = new Point(3, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(618, 234);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            DNI.HeaderText = "Dni";
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
            // Tipolibro
            // 
            Tipolibro.HeaderText = "Tipo de libro";
            Tipolibro.Name = "Tipolibro";
            Tipolibro.ReadOnly = true;
            // 
            // Nombrelibro
            // 
            Nombrelibro.HeaderText = "Nombre del libro";
            Nombrelibro.Name = "Nombrelibro";
            Nombrelibro.ReadOnly = true;
            // 
            // Fechainicio
            // 
            Fechainicio.HeaderText = "Fecha inicio";
            Fechainicio.Name = "Fechainicio";
            Fechainicio.ReadOnly = true;
            // 
            // Fechafin
            // 
            Fechafin.HeaderText = "Fecha fin";
            Fechafin.Name = "Fechafin";
            Fechafin.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // menuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "menuPrincipal";
            Text = "menuPrincipal";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Label reports;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Distrito;
        private DataGridViewTextBoxColumn Encargado;
        private DataGridViewTextBoxColumn Tipolibro;
        private DataGridViewTextBoxColumn Nombrelibro;
        private DataGridViewTextBoxColumn Fechainicio;
        private DataGridViewTextBoxColumn Fechafin;
        private DataGridViewTextBoxColumn Estado;
        private Panel panel2;
        private ComboBox comboBox1;
        private Button buscar;
        private Button limpiar;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Label label1;
        private Button agregar;
    }
}