namespace CapaPresentacion
{
    partial class ProductosVista
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProductos = new System.Windows.Forms.Label();
            this.tbBuscarProductos = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.TablaProductos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblProductos);
            this.panel1.Controls.Add(this.tbBuscarProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 74);
            this.panel1.TabIndex = 0;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(13, 12);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(69, 15);
            this.lblProductos.TabIndex = 1;
            this.lblProductos.Text = "/ Productos";
            // 
            // tbBuscarProductos
            // 
            this.tbBuscarProductos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscarProductos.Location = new System.Drawing.Point(12, 34);
            this.tbBuscarProductos.MaxLength = 200;
            this.tbBuscarProductos.Name = "tbBuscarProductos";
            this.tbBuscarProductos.Size = new System.Drawing.Size(293, 25);
            this.tbBuscarProductos.TabIndex = 0;
            this.tbBuscarProductos.TextChanged += new System.EventHandler(this.tbBuscarProductos_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 584);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 60);
            this.panel2.TabIndex = 1;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(820, 10);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 38);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(938, 10);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 38);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // TablaProductos
            // 
            this.TablaProductos.AllowUserToAddRows = false;
            this.TablaProductos.AllowUserToDeleteRows = false;
            this.TablaProductos.AllowUserToResizeRows = false;
            this.TablaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaProductos.Location = new System.Drawing.Point(0, 74);
            this.TablaProductos.MultiSelect = false;
            this.TablaProductos.Name = "TablaProductos";
            this.TablaProductos.ReadOnly = true;
            this.TablaProductos.RowHeadersVisible = false;
            this.TablaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaProductos.Size = new System.Drawing.Size(1044, 510);
            this.TablaProductos.TabIndex = 2;
            // 
            // ProductosVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 644);
            this.Controls.Add(this.TablaProductos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductosVista";
            this.Text = "ProductosVista";
            this.Load += new System.EventHandler(this.ProductosVista_Load);
            this.Shown += new System.EventHandler(this.ProductosVista_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView TablaProductos;
        private System.Windows.Forms.TextBox tbBuscarProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblProductos;
    }
}