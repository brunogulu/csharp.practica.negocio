namespace CapaPresentacion
{
    partial class ClientesVista
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
            this.TablaClientes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbBuscarClientes = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblClientes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablaClientes
            // 
            this.TablaClientes.AllowUserToAddRows = false;
            this.TablaClientes.AllowUserToDeleteRows = false;
            this.TablaClientes.AllowUserToResizeRows = false;
            this.TablaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaClientes.Location = new System.Drawing.Point(0, 74);
            this.TablaClientes.MultiSelect = false;
            this.TablaClientes.Name = "TablaClientes";
            this.TablaClientes.ReadOnly = true;
            this.TablaClientes.RowHeadersVisible = false;
            this.TablaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaClientes.Size = new System.Drawing.Size(1044, 510);
            this.TablaClientes.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblClientes);
            this.panel1.Controls.Add(this.tbBuscarClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 74);
            this.panel1.TabIndex = 1;
            // 
            // tbBuscarClientes
            // 
            this.tbBuscarClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscarClientes.Location = new System.Drawing.Point(12, 34);
            this.tbBuscarClientes.MaxLength = 200;
            this.tbBuscarClientes.Name = "tbBuscarClientes";
            this.tbBuscarClientes.Size = new System.Drawing.Size(293, 25);
            this.tbBuscarClientes.TabIndex = 0;
            this.tbBuscarClientes.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(938, 10);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 38);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 584);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 60);
            this.panel2.TabIndex = 2;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(820, 10);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 38);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(13, 12);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(57, 15);
            this.lblClientes.TabIndex = 1;
            this.lblClientes.Text = "/ Clientes";
            // 
            // ClientesVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 644);
            this.Controls.Add(this.TablaClientes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientesVista";
            this.Text = "ClienteVista";
            this.Load += new System.EventHandler(this.ClienteVista_Load);
            this.Shown += new System.EventHandler(this.ClientesVista_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.TablaClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbBuscarClientes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblClientes;
    }
}