namespace ObligatorioProgramacionII.Vista
{
    partial class PanelListaActores
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
            this.tablaActores = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscadorNombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filtroActorNacionalidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaActores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tablaActores);
            this.panel1.Controls.Add(this.buscadorNombres);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.filtroActorNacionalidad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // tablaActores
            // 
            this.tablaActores.AllowUserToAddRows = false;
            this.tablaActores.AllowUserToDeleteRows = false;
            this.tablaActores.AllowUserToResizeColumns = false;
            this.tablaActores.AllowUserToResizeRows = false;
            this.tablaActores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaActores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaActores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaActores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.apellido,
            this.nacimiento,
            this.nacionalidad,
            this.telefono});
            this.tablaActores.Location = new System.Drawing.Point(0, 79);
            this.tablaActores.Name = "tablaActores";
            this.tablaActores.RowHeadersVisible = false;
            this.tablaActores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaActores.Size = new System.Drawing.Size(802, 371);
            this.tablaActores.TabIndex = 1;
            this.tablaActores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaActores_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nacimiento
            // 
            this.nacimiento.HeaderText = "Fecha de nacimiento";
            this.nacimiento.Name = "nacimiento";
            this.nacimiento.ReadOnly = true;
            this.nacimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nacionalidad
            // 
            this.nacionalidad.HeaderText = "Nacionalidad";
            this.nacionalidad.Name = "nacionalidad";
            this.nacionalidad.ReadOnly = true;
            this.nacionalidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.telefono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // buscadorNombres
            // 
            this.buscadorNombres.Location = new System.Drawing.Point(512, 48);
            this.buscadorNombres.Name = "buscadorNombres";
            this.buscadorNombres.Size = new System.Drawing.Size(146, 20);
            this.buscadorNombres.TabIndex = 20;
            this.buscadorNombres.TextChanged += new System.EventHandler(this.buscadorNombres_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Buscar por nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filtrar actores según la nacionalidad";
            // 
            // filtroActorNacionalidad
            // 
            this.filtroActorNacionalidad.FormattingEnabled = true;
            this.filtroActorNacionalidad.Items.AddRange(new object[] {
            "Todos",
            "Estados Unidos",
            "Canadá",
            "Reino Unido",
            "Australia",
            "India",
            "Alemania",
            "Francia",
            "España",
            "Italia",
            "México",
            "Brasil",
            "Uruguay",
            "China",
            "Japón",
            "Corea del Sur",
            "Rusia",
            "Sudáfrica",
            "Argentina",
            "Chile",
            "Colombia",
            "Perú"});
            this.filtroActorNacionalidad.Location = new System.Drawing.Point(223, 47);
            this.filtroActorNacionalidad.Name = "filtroActorNacionalidad";
            this.filtroActorNacionalidad.Size = new System.Drawing.Size(165, 21);
            this.filtroActorNacionalidad.TabIndex = 1;
            this.filtroActorNacionalidad.Text = "Todos";
            this.filtroActorNacionalidad.SelectedIndexChanged += new System.EventHandler(this.filtroActorNacionalidad_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de actores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelListaActores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelListaActores";
            this.Text = "PanelListaActores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaActores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tablaActores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox filtroActorNacionalidad;
        private System.Windows.Forms.TextBox buscadorNombres;
        private System.Windows.Forms.Label label4;
    }
}