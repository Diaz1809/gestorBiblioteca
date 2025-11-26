namespace PROYECTO_BIBLIOTECA
{
    partial class RegistroSolicitud
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
            comboBoxCliente = new ComboBox();
            comboBoxtipodocument = new ComboBox();
            comboBoxTipoClient = new ComboBox();
            comboBoxTipoLibro = new ComboBox();
            comboBoxNameLibro = new ComboBox();
            textNroDocument = new TextBox();
            textFechaInicio = new TextBox();
            textFechaFin = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(12, 23);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(138, 23);
            comboBoxCliente.TabIndex = 0;
            comboBoxCliente.Text = "Cliente";
            comboBoxCliente.SelectedIndexChanged += comboBoxCliente_SelectedIndexChanged;
            // 
            // comboBoxtipodocument
            // 
            comboBoxtipodocument.FormattingEnabled = true;
            comboBoxtipodocument.Location = new Point(184, 23);
            comboBoxtipodocument.Name = "comboBoxtipodocument";
            comboBoxtipodocument.Size = new Size(121, 23);
            comboBoxtipodocument.TabIndex = 1;
            comboBoxtipodocument.Text = "Tipo documento";
            comboBoxtipodocument.SelectedIndexChanged += comboBoxtipodocument_SelectedIndexChanged;
            // 
            // comboBoxTipoClient
            // 
            comboBoxTipoClient.FormattingEnabled = true;
            comboBoxTipoClient.Location = new Point(12, 84);
            comboBoxTipoClient.Name = "comboBoxTipoClient";
            comboBoxTipoClient.Size = new Size(138, 23);
            comboBoxTipoClient.TabIndex = 2;
            comboBoxTipoClient.Text = "Tipo";
            comboBoxTipoClient.SelectedIndexChanged += comboBoxTipoClient_SelectedIndexChanged;
            // 
            // comboBoxTipoLibro
            // 
            comboBoxTipoLibro.FormattingEnabled = true;
            comboBoxTipoLibro.Location = new Point(184, 84);
            comboBoxTipoLibro.Name = "comboBoxTipoLibro";
            comboBoxTipoLibro.Size = new Size(121, 23);
            comboBoxTipoLibro.TabIndex = 3;
            comboBoxTipoLibro.Text = "Tipo de libro";
            comboBoxTipoLibro.SelectedIndexChanged += comboBoxTipoLibro_SelectedIndexChanged;
            // 
            // comboBoxNameLibro
            // 
            comboBoxNameLibro.FormattingEnabled = true;
            comboBoxNameLibro.Location = new Point(327, 84);
            comboBoxNameLibro.Name = "comboBoxNameLibro";
            comboBoxNameLibro.Size = new Size(121, 23);
            comboBoxNameLibro.TabIndex = 4;
            comboBoxNameLibro.Text = "Nombre del libro";
            comboBoxNameLibro.SelectedIndexChanged += comboBoxNameLibro_SelectedIndexChanged;
            // 
            // textNroDocument
            // 
            textNroDocument.Location = new Point(332, 23);
            textNroDocument.Name = "textNroDocument";
            textNroDocument.Size = new Size(116, 23);
            textNroDocument.TabIndex = 5;
            textNroDocument.Text = "Nro";
            textNroDocument.TextChanged += textNroDocument_TextChanged;
            // 
            // textFechaInicio
            // 
            textFechaInicio.Location = new Point(12, 142);
            textFechaInicio.Name = "textFechaInicio";
            textFechaInicio.Size = new Size(138, 23);
            textFechaInicio.TabIndex = 6;
            textFechaInicio.Text = "Fecha inicio";
            textFechaInicio.TextChanged += textFechaInicio_TextChanged;
            // 
            // textFechaFin
            // 
            textFechaFin.Location = new Point(184, 142);
            textFechaFin.Name = "textFechaFin";
            textFechaFin.Size = new Size(121, 23);
            textFechaFin.TabIndex = 7;
            textFechaFin.Text = "Fecha fin";
            textFechaFin.TextChanged += textFechaFin_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(230, 217);
            button1.Name = "button1";
            button1.Size = new Size(90, 38);
            button1.TabIndex = 8;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(102, 217);
            button2.Name = "button2";
            button2.Size = new Size(88, 38);
            button2.TabIndex = 9;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // RegistroSolicitud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 308);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textFechaFin);
            Controls.Add(textFechaInicio);
            Controls.Add(textNroDocument);
            Controls.Add(comboBoxNameLibro);
            Controls.Add(comboBoxTipoLibro);
            Controls.Add(comboBoxTipoClient);
            Controls.Add(comboBoxtipodocument);
            Controls.Add(comboBoxCliente);
            Name = "RegistroSolicitud";
            Text = "RegistroSolicitud";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCliente;
        private ComboBox comboBoxtipodocument;
        private ComboBox comboBoxTipoClient;
        private ComboBox comboBoxTipoLibro;
        private ComboBox comboBoxNameLibro;
        private TextBox textNroDocument;
        private TextBox textFechaInicio;
        private TextBox textFechaFin;
        private Button button1;
        private Button button2;
    }
}