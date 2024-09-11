namespace SubirFTP.Pantallas
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            tabSh = new TabPage();
            panel2 = new Panel();
            btnArmaCampa = new Button();
            label4 = new Label();
            btnArma3Basic = new Button();
            btnConfig = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            btnStartTs3 = new Button();
            btnRestart = new Button();
            btnCargarSSH = new Button();
            btnSelectSh = new Button();
            btnCargarPBO = new Button();
            txtBox = new RichTextBox();
            pictureBox1 = new PictureBox();
            Tabs = new TabControl();
            tabSh.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Tabs.SuspendLayout();
            SuspendLayout();
            // 
            // tabSh
            // 
            tabSh.Controls.Add(panel2);
            tabSh.Controls.Add(btnConfig);
            tabSh.Controls.Add(label2);
            tabSh.Controls.Add(label1);
            tabSh.Controls.Add(panel1);
            tabSh.Controls.Add(btnCargarSSH);
            tabSh.Controls.Add(btnSelectSh);
            tabSh.Controls.Add(btnCargarPBO);
            tabSh.Controls.Add(txtBox);
            tabSh.Controls.Add(pictureBox1);
            tabSh.Location = new Point(4, 24);
            tabSh.Name = "tabSh";
            tabSh.Padding = new Padding(3);
            tabSh.Size = new Size(469, 581);
            tabSh.TabIndex = 1;
            tabSh.Text = "Opciones";
            tabSh.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(btnArmaCampa);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnArma3Basic);
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(196, 161);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 63);
            panel2.TabIndex = 11;
            // 
            // btnArmaCampa
            // 
            btnArmaCampa.Location = new Point(3, 21);
            btnArmaCampa.Name = "btnArmaCampa";
            btnArmaCampa.Size = new Size(121, 23);
            btnArmaCampa.TabIndex = 14;
            btnArmaCampa.Text = "Campaña actual";
            btnArmaCampa.UseVisualStyleBackColor = true;
            btnArmaCampa.Click += btnArmaCampa_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 3);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 13;
            label4.Text = "Arma 3 Server:";
            // 
            // btnArma3Basic
            // 
            btnArma3Basic.Location = new Point(140, 21);
            btnArma3Basic.Name = "btnArma3Basic";
            btnArma3Basic.Size = new Size(93, 23);
            btnArma3Basic.TabIndex = 8;
            btnArma3Basic.Text = "Lista Basica";
            btnArma3Basic.UseVisualStyleBackColor = true;
            btnArma3Basic.Click += btnArma3Basic_Click;
            // 
            // btnConfig
            // 
            btnConfig.Location = new Point(364, 16);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(93, 23);
            btnConfig.TabIndex = 10;
            btnConfig.Text = "Configuraciones";
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 12);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 9;
            label2.Text = "Opciones:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 227);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 8;
            label1.Text = "CONSOLA:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnStartTs3);
            panel1.Controls.Add(btnRestart);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(196, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 63);
            panel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 12;
            label3.Text = "Opciones generales:";
            // 
            // btnStartTs3
            // 
            btnStartTs3.Location = new Point(140, 21);
            btnStartTs3.Name = "btnStartTs3";
            btnStartTs3.Size = new Size(93, 23);
            btnStartTs3.TabIndex = 10;
            btnStartTs3.Text = "TeamSpeak";
            btnStartTs3.UseVisualStyleBackColor = true;
            btnStartTs3.Click += btnStartTs3_Click;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(0, 21);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(134, 23);
            btnRestart.TabIndex = 8;
            btnRestart.Text = "Reiniciar Server";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnCargarSSH
            // 
            btnCargarSSH.Location = new Point(199, 63);
            btnCargarSSH.Name = "btnCargarSSH";
            btnCargarSSH.Size = new Size(93, 23);
            btnCargarSSH.TabIndex = 6;
            btnCargarSSH.Text = "Cargar SH";
            btnCargarSSH.UseVisualStyleBackColor = true;
            btnCargarSSH.Click += btnCargarSSH_Click;
            // 
            // btnSelectSh
            // 
            btnSelectSh.Location = new Point(196, 34);
            btnSelectSh.Name = "btnSelectSh";
            btnSelectSh.Size = new Size(134, 23);
            btnSelectSh.TabIndex = 5;
            btnSelectSh.Text = "Seleccionar archivo";
            btnSelectSh.UseVisualStyleBackColor = true;
            btnSelectSh.Click += button1_Click;
            // 
            // btnCargarPBO
            // 
            btnCargarPBO.Location = new Point(364, 63);
            btnCargarPBO.Name = "btnCargarPBO";
            btnCargarPBO.Size = new Size(93, 23);
            btnCargarPBO.TabIndex = 4;
            btnCargarPBO.Text = "Cargar PBO";
            btnCargarPBO.UseVisualStyleBackColor = true;
            btnCargarPBO.Click += btnCargarSH_Click;
            // 
            // txtBox
            // 
            txtBox.Location = new Point(7, 248);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(450, 327);
            txtBox.TabIndex = 2;
            txtBox.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Griffon;
            pictureBox1.Location = new Point(7, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Tabs
            // 
            Tabs.Controls.Add(tabSh);
            Tabs.Location = new Point(1, 0);
            Tabs.Name = "Tabs";
            Tabs.RightToLeftLayout = true;
            Tabs.SelectedIndex = 0;
            Tabs.Size = new Size(477, 609);
            Tabs.TabIndex = 0;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 613);
            Controls.Add(Tabs);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuPrincipal";
            Text = "Griffon App";
            tabSh.ResumeLayout(false);
            tabSh.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Tabs.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private TabPage tabSh;
        private Button btnSelectSh;
        private Button btnCargarPBO;
        private RichTextBox txtBox;
        private PictureBox pictureBox1;
        private TabControl Tabs;
        private Button btnCargarSSH;
        private Button btnStartTs3;
        private Button btnRestart;
        private Button btnConfig;
        private Label label2;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button btnArma3Basic;
        private Label label4;
        private Label label3;
        private Button btnArmaCampa;
    }
}