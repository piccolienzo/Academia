namespace UI.Desktop
{
    partial class Usuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.DataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BotonModificar = new UI.Desktop.CicButton();
            this.BotonBorrar = new UI.Desktop.CicButton();
            this.BotonActualizar = new UI.Desktop.CicButton();
            this.BotonAgregar = new UI.Desktop.CicButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsuarios)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(928, 592);
            // 
            // DataGridViewUsuarios
            // 
            this.DataGridViewUsuarios.AllowUserToAddRows = false;
            this.DataGridViewUsuarios.AllowUserToDeleteRows = false;
            this.DataGridViewUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.DataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.apellido,
            this.usuario,
            this.email,
            this.habilitado});
            this.DataGridViewUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewUsuarios.GridColor = System.Drawing.Color.White;
            this.DataGridViewUsuarios.Location = new System.Drawing.Point(3, 3);
            this.DataGridViewUsuarios.MultiSelect = false;
            this.DataGridViewUsuarios.Name = "DataGridViewUsuarios";
            this.DataGridViewUsuarios.ReadOnly = true;
            this.DataGridViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewUsuarios.Size = new System.Drawing.Size(988, 563);
            this.DataGridViewUsuarios.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            this.id.DefaultCellStyle = dataGridViewCellStyle23;
            this.id.HeaderText = "ID Usuario";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 120;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            this.nombre.DefaultCellStyle = dataGridViewCellStyle24;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            this.apellido.DefaultCellStyle = dataGridViewCellStyle25;
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 150;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "nombreusuario";
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.NullValue = "No contiene";
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            this.usuario.DefaultCellStyle = dataGridViewCellStyle26;
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 200;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.NullValue = "No contiene";
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            this.email.DefaultCellStyle = dataGridViewCellStyle27;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 200;
            // 
            // habilitado
            // 
            this.habilitado.DataPropertyName = "habilitado";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.NullValue = false;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            this.habilitado.DefaultCellStyle = dataGridViewCellStyle28;
            this.habilitado.HeaderText = "Habilitado";
            this.habilitado.Name = "habilitado";
            this.habilitado.ReadOnly = true;
            this.habilitado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.habilitado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DataGridViewUsuarios, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(994, 569);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // BotonModificar
            // 
            this.BotonModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonModificar.BorderColor = System.Drawing.Color.Black;
            this.BotonModificar.ButtonColor = System.Drawing.Color.White;
            this.BotonModificar.FlatAppearance.BorderSize = 0;
            this.BotonModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BotonModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BotonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonModificar.Location = new System.Drawing.Point(294, 613);
            this.BotonModificar.Name = "BotonModificar";
            this.BotonModificar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BotonModificar.OnHoverButtonColor = System.Drawing.Color.White;
            this.BotonModificar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BotonModificar.Size = new System.Drawing.Size(160, 40);
            this.BotonModificar.TabIndex = 4;
            this.BotonModificar.Text = "Modificar";
            this.BotonModificar.TextColor = System.Drawing.Color.Black;
            this.BotonModificar.UseVisualStyleBackColor = true;
            this.BotonModificar.Click += new System.EventHandler(this.ToolStripButtonEditar_Click);
            // 
            // BotonBorrar
            // 
            this.BotonBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonBorrar.BorderColor = System.Drawing.Color.Black;
            this.BotonBorrar.ButtonColor = System.Drawing.Color.White;
            this.BotonBorrar.FlatAppearance.BorderSize = 0;
            this.BotonBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BotonBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BotonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonBorrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBorrar.Location = new System.Drawing.Point(514, 613);
            this.BotonBorrar.Name = "BotonBorrar";
            this.BotonBorrar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BotonBorrar.OnHoverButtonColor = System.Drawing.Color.White;
            this.BotonBorrar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BotonBorrar.Size = new System.Drawing.Size(160, 40);
            this.BotonBorrar.TabIndex = 5;
            this.BotonBorrar.Text = "Borrar";
            this.BotonBorrar.TextColor = System.Drawing.Color.Black;
            this.BotonBorrar.UseVisualStyleBackColor = true;
            this.BotonBorrar.Click += new System.EventHandler(this.ToolStripButtonBorrar_Click);
            // 
            // BotonActualizar
            // 
            this.BotonActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonActualizar.BorderColor = System.Drawing.Color.Black;
            this.BotonActualizar.ButtonColor = System.Drawing.Color.White;
            this.BotonActualizar.FlatAppearance.BorderSize = 0;
            this.BotonActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BotonActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BotonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonActualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonActualizar.Location = new System.Drawing.Point(719, 613);
            this.BotonActualizar.Name = "BotonActualizar";
            this.BotonActualizar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BotonActualizar.OnHoverButtonColor = System.Drawing.Color.White;
            this.BotonActualizar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BotonActualizar.Size = new System.Drawing.Size(160, 40);
            this.BotonActualizar.TabIndex = 7;
            this.BotonActualizar.Text = "Actualizar";
            this.BotonActualizar.TextColor = System.Drawing.Color.Black;
            this.BotonActualizar.UseVisualStyleBackColor = true;
            this.BotonActualizar.Click += new System.EventHandler(this.BotonActualizar_Click);
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonAgregar.BorderColor = System.Drawing.Color.Black;
            this.BotonAgregar.ButtonColor = System.Drawing.Color.White;
            this.BotonAgregar.FlatAppearance.BorderSize = 0;
            this.BotonAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BotonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BotonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgregar.Location = new System.Drawing.Point(84, 613);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BotonAgregar.OnHoverButtonColor = System.Drawing.Color.White;
            this.BotonAgregar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BotonAgregar.Size = new System.Drawing.Size(160, 40);
            this.BotonAgregar.TabIndex = 6;
            this.BotonAgregar.Text = "Nuevo";
            this.BotonAgregar.TextColor = System.Drawing.Color.Black;
            this.BotonAgregar.UseVisualStyleBackColor = true;
            this.BotonAgregar.Click += new System.EventHandler(this.ToolStripButtonNuevo_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 698);
            this.Controls.Add(this.BotonModificar);
            this.Controls.Add(this.BotonBorrar);
            this.Controls.Add(this.BotonActualizar);
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsuarios)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridViewUsuarios;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitado;
        private CicButton BotonModificar;
        private CicButton BotonBorrar;
        private CicButton BotonActualizar;
        private CicButton BotonAgregar;
    }
}

