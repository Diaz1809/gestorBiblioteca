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
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(linkLabel2);
            splitContainer1.Panel1.Controls.Add(linkLabel1);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 172;
            splitContainer1.TabIndex = 1;
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
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.DarkBlue;
            linkLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = SystemColors.ControlText;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(12, 108);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.RightToLeft = RightToLeft.No;
            linkLabel1.Size = new Size(125, 17);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Gestion de clientes";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.DisabledLinkColor = Color.DarkBlue;
            linkLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.ForeColor = SystemColors.ControlText;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(12, 142);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.RightToLeft = RightToLeft.No;
            linkLabel2.Size = new Size(62, 17);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Reportes";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
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
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}