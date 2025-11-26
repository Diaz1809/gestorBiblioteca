namespace PROYECTO_BIBLIOTECA
{
    partial class Form1
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
            panelIzquierdo = new Panel();
            panelDerecho = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            label1 = new Label();
            panelDerecho.SuspendLayout();
            SuspendLayout();
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackgroundImage = Properties.Resources.blog_reporting_190625_820x930;
            panelIzquierdo.BackgroundImageLayout = ImageLayout.Stretch;
            panelIzquierdo.Dock = DockStyle.Left;
            panelIzquierdo.Location = new Point(0, 0);
            panelIzquierdo.Margin = new Padding(3, 2, 3, 2);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Size = new Size(394, 346);
            panelIzquierdo.TabIndex = 1;
            // 
            // panelDerecho
            // 
            panelDerecho.Controls.Add(label4);
            panelDerecho.Controls.Add(label3);
            panelDerecho.Controls.Add(label2);
            panelDerecho.Controls.Add(btnLogin);
            panelDerecho.Controls.Add(txtContraseña);
            panelDerecho.Controls.Add(txtUsuario);
            panelDerecho.Controls.Add(label1);
            panelDerecho.Dock = DockStyle.Fill;
            panelDerecho.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelDerecho.Location = new Point(394, 0);
            panelDerecho.Margin = new Padding(3, 2, 3, 2);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.Size = new Size(380, 346);
            panelDerecho.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 125);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 85);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 6;
            label3.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(145, 175);
            label2.Name = "label2";
            label2.Size = new Size(223, 15);
            label2.TabIndex = 5;
            label2.Text = "¿Olvidaste tu contraseña? Recuperar aquí";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkOrange;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(50, 218);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(290, 35);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Subida a GitHub";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(50, 139);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(291, 22);
            txtContraseña.TabIndex = 3;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(50, 98);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(291, 22);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(95, 19);
            label1.Name = "label1";
            label1.Size = new Size(247, 58);
            label1.TabIndex = 1;
            label1.Text = "Gestor de Biblioteca\r\n          Digital";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 346);
            Controls.Add(panelDerecho);
            Controls.Add(panelIzquierdo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de Biblioteca Digital";
            Load += Form1_Load;
            panelDerecho.ResumeLayout(false);
            panelDerecho.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelIzquierdo;
        private Panel panelDerecho;
        private Label label2;
        private Button btnLogin;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label label1;
        private Label label4;
        private Label label3;
    }
}