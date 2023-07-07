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
            this.tabSh = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStartTs3 = new System.Windows.Forms.Button();
            this.btnStartArma = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnCargarSSH = new System.Windows.Forms.Button();
            this.btnSelectSh = new System.Windows.Forms.Button();
            this.btnCargarPBO = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabSh.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSh
            // 
            this.tabSh.Controls.Add(this.label1);
            this.tabSh.Controls.Add(this.panel1);
            this.tabSh.Controls.Add(this.btnCargarSSH);
            this.tabSh.Controls.Add(this.btnSelectSh);
            this.tabSh.Controls.Add(this.btnCargarPBO);
            this.tabSh.Controls.Add(this.txtBox);
            this.tabSh.Controls.Add(this.pictureBox1);
            this.tabSh.Location = new System.Drawing.Point(4, 24);
            this.tabSh.Name = "tabSh";
            this.tabSh.Padding = new System.Windows.Forms.Padding(3);
            this.tabSh.Size = new System.Drawing.Size(629, 203);
            this.tabSh.TabIndex = 1;
            this.tabSh.Text = "Opciones";
            this.tabSh.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "CONSOLA:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.btnStartTs3);
            this.panel1.Controls.Add(this.btnStartArma);
            this.panel1.Controls.Add(this.btnRestart);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(196, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 63);
            this.panel1.TabIndex = 7;
            // 
            // btnStartTs3
            // 
            this.btnStartTs3.Location = new System.Drawing.Point(331, 21);
            this.btnStartTs3.Name = "btnStartTs3";
            this.btnStartTs3.Size = new System.Drawing.Size(93, 23);
            this.btnStartTs3.TabIndex = 10;
            this.btnStartTs3.Text = "3. TS3";
            this.btnStartTs3.UseVisualStyleBackColor = true;
            this.btnStartTs3.Click += new System.EventHandler(this.btnStartTs3_Click);
            // 
            // btnStartArma
            // 
            this.btnStartArma.Location = new System.Drawing.Point(171, 21);
            this.btnStartArma.Name = "btnStartArma";
            this.btnStartArma.Size = new System.Drawing.Size(93, 23);
            this.btnStartArma.TabIndex = 9;
            this.btnStartArma.Text = "2. Arma III";
            this.btnStartArma.UseVisualStyleBackColor = true;
            this.btnStartArma.Click += new System.EventHandler(this.btnStartArma_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(3, 21);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(93, 23);
            this.btnRestart.TabIndex = 8;
            this.btnRestart.Text = "1. Restar Server";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnCargarSSH
            // 
            this.btnCargarSSH.Location = new System.Drawing.Point(422, 101);
            this.btnCargarSSH.Name = "btnCargarSSH";
            this.btnCargarSSH.Size = new System.Drawing.Size(93, 23);
            this.btnCargarSSH.TabIndex = 6;
            this.btnCargarSSH.Text = "Cargar SH";
            this.btnCargarSSH.UseVisualStyleBackColor = true;
            this.btnCargarSSH.Click += new System.EventHandler(this.btnCargarSSH_Click);
            // 
            // btnSelectSh
            // 
            this.btnSelectSh.Location = new System.Drawing.Point(196, 101);
            this.btnSelectSh.Name = "btnSelectSh";
            this.btnSelectSh.Size = new System.Drawing.Size(134, 23);
            this.btnSelectSh.TabIndex = 5;
            this.btnSelectSh.Text = "Seleccionar archivo";
            this.btnSelectSh.UseVisualStyleBackColor = true;
            this.btnSelectSh.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCargarPBO
            // 
            this.btnCargarPBO.Location = new System.Drawing.Point(533, 101);
            this.btnCargarPBO.Name = "btnCargarPBO";
            this.btnCargarPBO.Size = new System.Drawing.Size(93, 23);
            this.btnCargarPBO.TabIndex = 4;
            this.btnCargarPBO.Text = "Cargar PBO";
            this.btnCargarPBO.UseVisualStyleBackColor = true;
            this.btnCargarPBO.Click += new System.EventHandler(this.btnCargarSH_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(196, 34);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(427, 61);
            this.txtBox.TabIndex = 2;
            this.txtBox.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SubirFTP.Properties.Resources.Griffon;
            this.pictureBox1.Location = new System.Drawing.Point(7, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tabSh);
            this.Tabs.Location = new System.Drawing.Point(1, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.RightToLeftLayout = true;
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(637, 231);
            this.Tabs.TabIndex = 0;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 230);
            this.Controls.Add(this.Tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "Griffon App";
            this.tabSh.ResumeLayout(false);
            this.tabSh.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Tabs.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}