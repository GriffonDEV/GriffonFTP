namespace SubirFTP.Pantallas
{
    partial class UsuarioSSH
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
            label1 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            btnLimpiar = new Button();
            btnRegistrar = new Button();
            label5 = new Label();
            txtPuerto = new TextBox();
            label4 = new Label();
            txtHost = new TextBox();
            txtPass = new TextBox();
            label3 = new Label();
            dropRegistrados = new DomainUpDown();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(142, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 40);
            label1.TabIndex = 6;
            label1.Text = "Datos SSH";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(161, 19);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "root";
            txtUsuario.Size = new Size(155, 23);
            txtUsuario.TabIndex = 7;
            txtUsuario.Tag = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 21);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 8;
            label2.Text = "Usuario:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPuerto);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtHost);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUsuario);
            panel1.Location = new Point(44, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 192);
            panel1.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(282, 162);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(0, 162);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 15;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(39, 108);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 14;
            label5.Text = "Puerto:";
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(161, 106);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.PlaceholderText = "22";
            txtPuerto.Size = new Size(155, 23);
            txtPuerto.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 79);
            label4.Name = "label4";
            label4.Size = new Size(26, 21);
            label4.TabIndex = 12;
            label4.Text = "IP:";
            // 
            // txtHost
            // 
            txtHost.Location = new Point(161, 77);
            txtHost.Name = "txtHost";
            txtHost.PlaceholderText = "127.0.0.1";
            txtHost.Size = new Size(155, 23);
            txtHost.TabIndex = 11;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(161, 48);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(155, 23);
            txtPass.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 50);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 9;
            label3.Text = "Contraseña:";
            // 
            // dropRegistrados
            // 
            dropRegistrados.Location = new Point(142, 52);
            dropRegistrados.Name = "dropRegistrados";
            dropRegistrados.Size = new Size(150, 23);
            dropRegistrados.TabIndex = 10;
            dropRegistrados.Text = "Usuarios registrados";
            // 
            // UsuarioSSH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 288);
            Controls.Add(dropRegistrados);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "UsuarioSSH";
            Text = "UsuarioSSH";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private Label label2;
        private Panel panel1;
        private Button btnLimpiar;
        private Button btnRegistrar;
        private Label label5;
        private TextBox txtPuerto;
        private Label label4;
        private TextBox txtHost;
        private TextBox txtPass;
        private Label label3;
        private DomainUpDown dropRegistrados;
    }
}