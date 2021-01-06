namespace Login
{
    partial class CRUD_Platos
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
            this.img_plato = new System.Windows.Forms.PictureBox();
            this.txt_nomPlato = new System.Windows.Forms.TextBox();
            this.txt_precioPlato = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.Panel_Insertar_Plato = new System.Windows.Forms.Panel();
            this.lbl_idPlato = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Panel_Principal_platos = new System.Windows.Forms.Panel();
            this.tabla_platos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_plato)).BeginInit();
            this.Panel_Insertar_Plato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Panel_Principal_platos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_platos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // img_plato
            // 
            this.img_plato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_plato.Location = new System.Drawing.Point(35, 35);
            this.img_plato.Name = "img_plato";
            this.img_plato.Size = new System.Drawing.Size(207, 152);
            this.img_plato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_plato.TabIndex = 0;
            this.img_plato.TabStop = false;
            // 
            // txt_nomPlato
            // 
            this.txt_nomPlato.Location = new System.Drawing.Point(314, 51);
            this.txt_nomPlato.Name = "txt_nomPlato";
            this.txt_nomPlato.Size = new System.Drawing.Size(201, 22);
            this.txt_nomPlato.TabIndex = 1;
            // 
            // txt_precioPlato
            // 
            this.txt_precioPlato.Location = new System.Drawing.Point(314, 112);
            this.txt_precioPlato.Name = "txt_precioPlato";
            this.txt_precioPlato.Size = new System.Drawing.Size(74, 22);
            this.txt_precioPlato.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(192, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "........";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione una imagen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(111, 256);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Panel_Insertar_Plato
            // 
            this.Panel_Insertar_Plato.Controls.Add(this.lbl_idPlato);
            this.Panel_Insertar_Plato.Controls.Add(this.button2);
            this.Panel_Insertar_Plato.Controls.Add(this.pictureBox2);
            this.Panel_Insertar_Plato.Controls.Add(this.img_plato);
            this.Panel_Insertar_Plato.Controls.Add(this.btn_guardar);
            this.Panel_Insertar_Plato.Controls.Add(this.txt_nomPlato);
            this.Panel_Insertar_Plato.Controls.Add(this.label3);
            this.Panel_Insertar_Plato.Controls.Add(this.txt_precioPlato);
            this.Panel_Insertar_Plato.Controls.Add(this.label2);
            this.Panel_Insertar_Plato.Controls.Add(this.button1);
            this.Panel_Insertar_Plato.Controls.Add(this.label1);
            this.Panel_Insertar_Plato.Location = new System.Drawing.Point(116, 137);
            this.Panel_Insertar_Plato.Name = "Panel_Insertar_Plato";
            this.Panel_Insertar_Plato.Size = new System.Drawing.Size(523, 302);
            this.Panel_Insertar_Plato.TabIndex = 8;
            // 
            // lbl_idPlato
            // 
            this.lbl_idPlato.AutoSize = true;
            this.lbl_idPlato.Location = new System.Drawing.Point(254, 21);
            this.lbl_idPlato.Name = "lbl_idPlato";
            this.lbl_idPlato.Size = new System.Drawing.Size(46, 17);
            this.lbl_idPlato.TabIndex = 10;
            this.lbl_idPlato.Text = "label4";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(494, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 24);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Panel_Principal_platos
            // 
            this.Panel_Principal_platos.Controls.Add(this.panel1);
            this.Panel_Principal_platos.Controls.Add(this.Panel_Insertar_Plato);
            this.Panel_Principal_platos.Controls.Add(this.tabla_platos);
            this.Panel_Principal_platos.Location = new System.Drawing.Point(112, 59);
            this.Panel_Principal_platos.Name = "Panel_Principal_platos";
            this.Panel_Principal_platos.Size = new System.Drawing.Size(815, 498);
            this.Panel_Principal_platos.TabIndex = 9;
            // 
            // tabla_platos
            // 
            this.tabla_platos.AllowUserToAddRows = false;
            this.tabla_platos.AllowUserToDeleteRows = false;
            this.tabla_platos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_platos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabla_platos.Location = new System.Drawing.Point(0, 0);
            this.tabla_platos.Name = "tabla_platos";
            this.tabla_platos.ReadOnly = true;
            this.tabla_platos.RowTemplate.Height = 24;
            this.tabla_platos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_platos.Size = new System.Drawing.Size(815, 498);
            this.tabla_platos.TabIndex = 9;
            this.tabla_platos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_platos_CellClick_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(732, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 498);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(1, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 72);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CRUD_Platos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 606);
            this.Controls.Add(this.Panel_Principal_platos);
            this.Name = "CRUD_Platos";
            this.Text = "CRUD_Platos";
            this.Load += new System.EventHandler(this.CRUD_Platos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_plato)).EndInit();
            this.Panel_Insertar_Plato.ResumeLayout(false);
            this.Panel_Insertar_Plato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Panel_Principal_platos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_platos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_plato;
        private System.Windows.Forms.TextBox txt_nomPlato;
        private System.Windows.Forms.TextBox txt_precioPlato;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Panel Panel_Insertar_Plato;
        private System.Windows.Forms.Panel Panel_Principal_platos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_idPlato;
        private System.Windows.Forms.DataGridView tabla_platos;
    }
}