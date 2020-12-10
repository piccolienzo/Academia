namespace UI.Desktop
{
    partial class ModulosUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DataGridViewMU = new System.Windows.Forms.DataGridView();
            this.BotonModificar = new UI.Desktop.CicButton();
            this.BotonBorrar = new UI.Desktop.CicButton();
            this.BotonActualizar = new UI.Desktop.CicButton();
            this.BotonAgregar = new UI.Desktop.CicButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmodulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.baja = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.modificacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.consulta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMU)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DataGridViewMU, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.56808F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(994, 542);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DataGridViewMU
            // 
            this.DataGridViewMU.AllowUserToAddRows = false;
            this.DataGridViewMU.AllowUserToDeleteRows = false;
            this.DataGridViewMU.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewMU.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewMU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.idusuario,
            this.idmodulo,
            this.alta,
            this.baja,
            this.modificacion,
            this.consulta});
            this.DataGridViewMU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewMU.GridColor = System.Drawing.Color.White;
            this.DataGridViewMU.Location = new System.Drawing.Point(3, 3);
            this.DataGridViewMU.MultiSelect = false;
            this.DataGridViewMU.Name = "DataGridViewMU";
            this.DataGridViewMU.ReadOnly = true;
            this.DataGridViewMU.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewMU.Size = new System.Drawing.Size(988, 536);
            this.DataGridViewMU.TabIndex = 1;
            // 
            // BotonModificar
            // 
            this.BotonModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonModificar.BackColor = System.Drawing.Color.Transparent;
            this.BotonModificar.BorderColor = System.Drawing.Color.Black;
            this.BotonModificar.ButtonColor = System.Drawing.Color.White;
            this.BotonModificar.FlatAppearance.BorderSize = 0;
            this.BotonModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BotonModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BotonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonModificar.Location = new System.Drawing.Point(316, 593);
            this.BotonModificar.Name = "BotonModificar";
            this.BotonModificar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BotonModificar.OnHoverButtonColor = System.Drawing.Color.White;
            this.BotonModificar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BotonModificar.Size = new System.Drawing.Size(160, 40);
            this.BotonModificar.TabIndex = 4;
            this.BotonModificar.Text = "Modificar";
            this.BotonModificar.TextColor = System.Drawing.Color.Black;
            this.BotonModificar.UseVisualStyleBackColor = false;
            this.BotonModificar.Click += new System.EventHandler(this.BotonModificar_Click);
            // 
            // BotonBorrar
            // 
            this.BotonBorrar.BackColor = System.Drawing.Color.White;
            this.BotonBorrar.BorderColor = System.Drawing.Color.Black;
            this.BotonBorrar.ButtonColor = System.Drawing.Color.White;
            this.BotonBorrar.FlatAppearance.BorderSize = 0;
            this.BotonBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BotonBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BotonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonBorrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBorrar.Location = new System.Drawing.Point(519, 593);
            this.BotonBorrar.Name = "BotonBorrar";
            this.BotonBorrar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BotonBorrar.OnHoverButtonColor = System.Drawing.Color.White;
            this.BotonBorrar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BotonBorrar.Size = new System.Drawing.Size(160, 40);
            this.BotonBorrar.TabIndex = 5;
            this.BotonBorrar.Text = "Borrar";
            this.BotonBorrar.TextColor = System.Drawing.Color.Black;
            this.BotonBorrar.UseVisualStyleBackColor = false;
            this.BotonBorrar.Click += new System.EventHandler(this.BotonBorrar_Click);
            // 
            // BotonActualizar
            // 
            this.BotonActualizar.BackColor = System.Drawing.Color.White;
            this.BotonActualizar.BorderColor = System.Drawing.Color.Black;
            this.BotonActualizar.ButtonColor = System.Drawing.Color.White;
            this.BotonActualizar.FlatAppearance.BorderSize = 0;
            this.BotonActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BotonActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BotonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonActualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonActualizar.Location = new System.Drawing.Point(729, 593);
            this.BotonActualizar.Name = "BotonActualizar";
            this.BotonActualizar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BotonActualizar.OnHoverButtonColor = System.Drawing.Color.White;
            this.BotonActualizar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BotonActualizar.Size = new System.Drawing.Size(160, 40);
            this.BotonActualizar.TabIndex = 7;
            this.BotonActualizar.Text = "Actualizar";
            this.BotonActualizar.TextColor = System.Drawing.Color.Black;
            this.BotonActualizar.UseVisualStyleBackColor = false;
            this.BotonActualizar.Click += new System.EventHandler(this.BotonActualizar_Click);
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.BackColor = System.Drawing.Color.White;
            this.BotonAgregar.BorderColor = System.Drawing.Color.Black;
            this.BotonAgregar.ButtonColor = System.Drawing.Color.White;
            this.BotonAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BotonAgregar.FlatAppearance.BorderSize = 0;
            this.BotonAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BotonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BotonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BotonAgregar.Location = new System.Drawing.Point(93, 593);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BotonAgregar.OnHoverButtonColor = System.Drawing.Color.White;
            this.BotonAgregar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BotonAgregar.Size = new System.Drawing.Size(160, 40);
            this.BotonAgregar.TabIndex = 6;
            this.BotonAgregar.Text = "Nuevo";
            this.BotonAgregar.TextColor = System.Drawing.Color.Black;
            this.BotonAgregar.UseVisualStyleBackColor = false;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonNuevo_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 110;
            // 
            // idusuario
            // 
            this.idusuario.DataPropertyName = "idusuario";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.idusuario.DefaultCellStyle = dataGridViewCellStyle3;
            this.idusuario.HeaderText = "ID Usuario";
            this.idusuario.Name = "idusuario";
            this.idusuario.ReadOnly = true;
            this.idusuario.Width = 135;
            // 
            // idmodulo
            // 
            this.idmodulo.DataPropertyName = "idmodulo";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.idmodulo.DefaultCellStyle = dataGridViewCellStyle4;
            this.idmodulo.HeaderText = "ID Modulo";
            this.idmodulo.Name = "idmodulo";
            this.idmodulo.ReadOnly = true;
            this.idmodulo.Width = 135;
            // 
            // alta
            // 
            this.alta.DataPropertyName = "permitealta";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.NullValue = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.alta.DefaultCellStyle = dataGridViewCellStyle5;
            this.alta.HeaderText = "Alta";
            this.alta.Name = "alta";
            this.alta.ReadOnly = true;
            this.alta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.alta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.alta.Width = 140;
            // 
            // baja
            // 
            this.baja.DataPropertyName = "permitebaja";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.NullValue = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.baja.DefaultCellStyle = dataGridViewCellStyle6;
            this.baja.HeaderText = "Baja";
            this.baja.Name = "baja";
            this.baja.ReadOnly = true;
            this.baja.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.baja.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.baja.Width = 140;
            // 
            // modificacion
            // 
            this.modificacion.DataPropertyName = "permitemodificacion";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.NullValue = false;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.modificacion.DefaultCellStyle = dataGridViewCellStyle7;
            this.modificacion.HeaderText = "Modificacion";
            this.modificacion.Name = "modificacion";
            this.modificacion.ReadOnly = true;
            this.modificacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.modificacion.Width = 140;
            // 
            // consulta
            // 
            this.consulta.DataPropertyName = "permiteconsulta";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.NullValue = false;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.consulta.DefaultCellStyle = dataGridViewCellStyle8;
            this.consulta.HeaderText = "Consulta";
            this.consulta.Name = "consulta";
            this.consulta.ReadOnly = true;
            this.consulta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.consulta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.consulta.Width = 140;
            // 
            // ModulosUsuarios
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
            this.Name = "ModulosUsuarios";
            this.Text = "ModulosUsuarios";
            this.Load += new System.EventHandler(this.ModulosUsuarios_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DataGridViewMU;
        private CicButton BotonModificar;
        private CicButton BotonBorrar;
        private CicButton BotonActualizar;
        private CicButton BotonAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmodulo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn alta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn baja;
        private System.Windows.Forms.DataGridViewCheckBoxColumn modificacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn consulta;
    }
}