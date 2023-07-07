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
            label1 = new Label();
            panel1 = new Panel();
            btnStartTs3 = new Button();
            btnStartArma = new Button();
            btnRestart = new Button();
            btnCargarSSH = new Button();
            btnSelectSh = new Button();
            btnCargarPBO = new Button();
            txtBox = new RichTextBox();
            pictureBox1 = new PictureBox();
            Tabs = new TabControl();
            label2 = new Label();
            btnConfig = new Button();
            tabSh.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Tabs.SuspendLayout();
            SuspendLayout();
            // 
            // tabSh
            // 
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
            tabSh.Size = new Size(629, 581);
            tabSh.TabIndex = 1;
            tabSh.Text = "Opciones";
            tabSh.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 196);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 8;
            label1.Text = "CONSOLA:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(btnStartTs3);
            panel1.Controls.Add(btnStartArma);
            panel1.Controls.Add(btnRestart);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(196, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 63);
            panel1.TabIndex = 7;
            // 
            // btnStartTs3
            // 
            btnStartTs3.Location = new Point(331, 21);
            btnStartTs3.Name = "btnStartTs3";
            btnStartTs3.Size = new Size(93, 23);
            btnStartTs3.TabIndex = 10;
            btnStartTs3.Text = "3. TS3";
            btnStartTs3.UseVisualStyleBackColor = true;
            btnStartTs3.Click += btnStartTs3_Click;
            // 
            // btnStartArma
            // 
            btnStartArma.Location = new Point(171, 21);
            btnStartArma.Name = "btnStartArma";
            btnStartArma.Size = new Size(93, 23);
            btnStartArma.TabIndex = 9;
            btnStartArma.Text = "2. Arma III";
            btnStartArma.UseVisualStyleBackColor = true;
            btnStartArma.Click += btnStartArma_Click;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(3, 21);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(93, 23);
            btnRestart.TabIndex = 8;
            btnRestart.Text = "1. Restar Server";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnCargarSSH
            // 
            btnCargarSSH.Location = new Point(196, 72);
            btnCargarSSH.Name = "btnCargarSSH";
            btnCargarSSH.Size = new Size(93, 23);
            btnCargarSSH.TabIndex = 6;
            btnCargarSSH.Text = "Cargar SH";
            btnCargarSSH.UseVisualStyleBackColor = true;
            btnCargarSSH.Click += btnCargarSSH_Click;
            // 
            // btnSelectSh
            // 
            btnSelectSh.Location = new Point(196, 43);
            btnSelectSh.Name = "btnSelectSh";
            btnSelectSh.Size = new Size(134, 23);
            btnSelectSh.TabIndex = 5;
            btnSelectSh.Text = "Seleccionar archivo";
            btnSelectSh.UseVisualStyleBackColor = true;
            btnSelectSh.Click += button1_Click;
            // 
            // btnCargarPBO
            // 
            btnCargarPBO.Location = new Point(196, 101);
            btnCargarPBO.Name = "btnCargarPBO";
            btnCargarPBO.Size = new Size(93, 23);
            btnCargarPBO.TabIndex = 4;
            btnCargarPBO.Text = "Cargar PBO";
            btnCargarPBO.UseVisualStyleBackColor = true;
            btnCargarPBO.Click += btnCargarSH_Click;
            // 
            // txtBox
            // 
            txtBox.Location = new Point(7, 214);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(615, 361);
            txtBox.TabIndex = 2;
            txtBox.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Griffon;
            pictureBox1.Location = new Point(7, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 177);
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
            Tabs.Size = new Size(637, 609);
            Tabs.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 16);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 9;
            label2.Text = "Opciones:";
            // 
            // btnConfig
            // 
            btnConfig.Location = new Point(527, 43);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(93, 23);
            btnConfig.TabIndex = 10;
            btnConfig.Text = "Configuraciones";
            btnConfig.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 613);
            Controls.Add(Tabs);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuPrincipal";
            Text = "Griffon App";
            tabSh.ResumeLayout(false);
            tabSh.PerformLayout();
            panel1.ResumeLayout(false);
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
        private Button btnStartArma;
        private Button btnRestart;
        private Button btnConfig;
        private Label label2;
    }
}