namespace Lector_de_cv
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_carpeta = new System.Windows.Forms.Button();
            this.listaCv = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.list_acep = new System.Windows.Forms.ListBox();
            this.list_pend = new System.Windows.Forms.ListBox();
            this.list_desc = new System.Windows.Forms.ListBox();
            this.btn_sig = new System.Windows.Forms.Button();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Aceptados = new System.Windows.Forms.TabPage();
            this.Pendientes = new System.Windows.Forms.TabPage();
            this.Rechazados = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Aceptados.SuspendLayout();
            this.Pendientes.SuspendLayout();
            this.Rechazados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar carpeta:";
            // 
            // btn_carpeta
            // 
            this.btn_carpeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_carpeta.Location = new System.Drawing.Point(817, 24);
            this.btn_carpeta.Name = "btn_carpeta";
            this.btn_carpeta.Size = new System.Drawing.Size(124, 39);
            this.btn_carpeta.TabIndex = 1;
            this.btn_carpeta.Text = "Carpeta";
            this.btn_carpeta.UseVisualStyleBackColor = true;
            this.btn_carpeta.Click += new System.EventHandler(this.btn_carpeta_Click);
            // 
            // listaCv
            // 
            this.listaCv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaCv.FormattingEnabled = true;
            this.listaCv.HorizontalScrollbar = true;
            this.listaCv.ItemHeight = 20;
            this.listaCv.Location = new System.Drawing.Point(62, 172);
            this.listaCv.Name = "listaCv";
            this.listaCv.Size = new System.Drawing.Size(412, 384);
            this.listaCv.TabIndex = 3;
            this.listaCv.SelectedIndexChanged += new System.EventHandler(this.listaCv_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(204, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(466, 28);
            this.textBox1.TabIndex = 2;
            // 
            // list_acep
            // 
            this.list_acep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_acep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_acep.FormattingEnabled = true;
            this.list_acep.ItemHeight = 20;
            this.list_acep.Location = new System.Drawing.Point(3, 3);
            this.list_acep.Name = "list_acep";
            this.list_acep.Size = new System.Drawing.Size(415, 345);
            this.list_acep.TabIndex = 8;
            this.list_acep.TabStop = false;
            this.list_acep.SelectedIndexChanged += new System.EventHandler(this.list_acep_SelectedIndexChanged);
            // 
            // list_pend
            // 
            this.list_pend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_pend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_pend.FormattingEnabled = true;
            this.list_pend.ItemHeight = 20;
            this.list_pend.Location = new System.Drawing.Point(3, 3);
            this.list_pend.Name = "list_pend";
            this.list_pend.Size = new System.Drawing.Size(415, 345);
            this.list_pend.TabIndex = 7;
            this.list_pend.TabStop = false;
            // 
            // list_desc
            // 
            this.list_desc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_desc.FormattingEnabled = true;
            this.list_desc.ItemHeight = 20;
            this.list_desc.Location = new System.Drawing.Point(0, 0);
            this.list_desc.Name = "list_desc";
            this.list_desc.Size = new System.Drawing.Size(421, 351);
            this.list_desc.TabIndex = 6;
            this.list_desc.TabStop = false;
            // 
            // btn_sig
            // 
            this.btn_sig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sig.Location = new System.Drawing.Point(810, 578);
            this.btn_sig.Name = "btn_sig";
            this.btn_sig.Size = new System.Drawing.Size(124, 46);
            this.btn_sig.TabIndex = 5;
            this.btn_sig.Text = "Siguiente";
            this.btn_sig.UseVisualStyleBackColor = true;
            this.btn_sig.Click += new System.EventHandler(this.btn_sig_Click);
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_visualizar.Location = new System.Drawing.Point(651, 578);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(124, 46);
            this.btn_visualizar.TabIndex = 4;
            this.btn_visualizar.Text = "Visualizar";
            this.btn_visualizar.UseVisualStyleBackColor = true;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lista de CV";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Aceptados);
            this.tabControl1.Controls.Add(this.Pendientes);
            this.tabControl1.Controls.Add(this.Rechazados);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(512, 172);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(429, 384);
            this.tabControl1.TabIndex = 13;
            // 
            // Aceptados
            // 
            this.Aceptados.Controls.Add(this.list_acep);
            this.Aceptados.Location = new System.Drawing.Point(4, 29);
            this.Aceptados.Name = "Aceptados";
            this.Aceptados.Padding = new System.Windows.Forms.Padding(3);
            this.Aceptados.Size = new System.Drawing.Size(421, 351);
            this.Aceptados.TabIndex = 0;
            this.Aceptados.Text = "Aceptados";
            this.Aceptados.UseVisualStyleBackColor = true;
            // 
            // Pendientes
            // 
            this.Pendientes.Controls.Add(this.list_pend);
            this.Pendientes.Location = new System.Drawing.Point(4, 29);
            this.Pendientes.Name = "Pendientes";
            this.Pendientes.Padding = new System.Windows.Forms.Padding(3);
            this.Pendientes.Size = new System.Drawing.Size(421, 351);
            this.Pendientes.TabIndex = 1;
            this.Pendientes.Text = "Pendiente";
            this.Pendientes.UseVisualStyleBackColor = true;
            // 
            // Rechazados
            // 
            this.Rechazados.Controls.Add(this.list_desc);
            this.Rechazados.Location = new System.Drawing.Point(4, 29);
            this.Rechazados.Name = "Rechazados";
            this.Rechazados.Size = new System.Drawing.Size(421, 351);
            this.Rechazados.TabIndex = 2;
            this.Rechazados.Text = "Rechazados";
            this.Rechazados.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "CV vistos";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(687, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 636);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_visualizar);
            this.Controls.Add(this.btn_sig);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listaCv);
            this.Controls.Add(this.btn_carpeta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Aceptados.ResumeLayout(false);
            this.Pendientes.ResumeLayout(false);
            this.Rechazados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_carpeta;
        private System.Windows.Forms.ListBox listaCv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox list_acep;
        private System.Windows.Forms.ListBox list_pend;
        private System.Windows.Forms.ListBox list_desc;
        private System.Windows.Forms.Button btn_sig;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Aceptados;
        private System.Windows.Forms.TabPage Pendientes;
        private System.Windows.Forms.TabPage Rechazados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

