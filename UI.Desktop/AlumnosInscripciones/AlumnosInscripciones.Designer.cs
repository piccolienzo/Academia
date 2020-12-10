namespace UI.Desktop
{
    partial class AlumnosInscripciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DataGridViewInscripciones = new System.Windows.Forms.DataGridView();
            this.BotonModificar = new UI.Desktop.CicButton();
            this.BotonBorrar = new UI.Desktop.CicButton();
            this.BotonActualizar = new UI.Desktop.CicButton();
            this.BotonAgregar = new UI.Desktop.CicButton();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInscripciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DataGridViewInscripciones, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(994, 569);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // DataGridViewInscripciones
            // 
            this.DataGridViewInscripciones.AllowUserToAddRows = false;
            this.DataGridViewInscripciones.AllowUserToDeleteRows = false;
            this.DataGridViewInscripciones.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewInscripciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewInscripciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewInscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.id,
            this.apellido,
            this.usuario,
            this.email});
            this.DataGridViewInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewInscripciones.GridColor = System.Drawing.Color.White;
            this.DataGridViewInscripciones.Location = new System.Drawing.Point(3, 3);
            this.DataGridViewInscripciones.MultiSelect = false;
            this.DataGridViewInscripciones.Name = "DataGridViewInscripciones";
            this.DataGridViewInscripciones.ReadOnly = true;
            this.DataGridViewInscripciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewInscripciones.Size = new System.Drawing.Size(988, 563);
            this.DataGridViewInscripciones.TabIndex = 0;
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
            this.BotonModificar.Location = new System.Drawing.Point(302, 609);
            this.BotonModificar.Name = "BotonModificar";
            this.BotonModificar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BotonModificar.OnHoverButtonColor = System.Drawing.Color.White;
            this.BotonModificar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BotonModificar.Size = new System.Drawing.Size(160, 40);
            this.BotonModificar.TabIndex = 9;
            this.BotonModificar.Text = "Modificar";
            this.BotonModificar.TextColor = System.Drawing.Color.Black;
            this.BotonModificar.UseVisualStyleBackColor = true;
            this.BotonModificar.Click += new System.EventHandler(this.BotonModificar_Click);
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
            this.BotonBorrar.Location = new System.Drawing.Point(522, 609);
            this.BotonBorrar.Name = "BotonBorrar";
            this.BotonBorrar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BotonBorrar.OnHoverButtonColor = System.Drawing.Color.White;
            this.BotonBorrar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BotonBorrar.Size = new System.Drawing.Size(160, 40);
            this.BotonBorrar.TabIndex = 10;
            this.BotonBorrar.Text = "Borrar";
            this.BotonBorrar.TextColor = System.Drawing.Color.Black;
            this.BotonBorrar.UseVisualStyleBackColor = true;
            this.BotonBorrar.Click += new System.EventHandler(this.BotonBorrar_Click);
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
            this.BotonActualizar.Location = new System.Drawing.Point(727, 609);
            this.BotonActualizar.Name = "BotonActualizar";
            this.BotonActualizar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BotonActualizar.OnHoverButtonColor = System.Drawing.Color.White;
            this.BotonActualizar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BotonActualizar.Size = new System.Drawing.Size(160, 40);
            this.BotonActualizar.TabIndex = 12;
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
            this.BotonAgregar.Location = new System.Drawing.Point(92, 609);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BotonAgregar.OnHoverButtonColor = System.Drawing.Color.White;
            this.BotonAgregar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BotonAgregar.Size = new System.Drawing.Size(160, 40);
            this.BotonAgregar.TabIndex = 11;
            this.BotonAgregar.Text = "Nuevo";
            this.BotonAgregar.TextColor = System.Drawing.Color.Black;
            this.BotonAgregar.UseVisualStyleBackColor = true;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "id";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.nombre.DefaultCellStyle = dataGridViewCellStyle8;
            this.nombre.HeaderText = "Inscripcion";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // id
            // 
            this.id.DataPropertyName = "idalumno";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.id.DefaultCellStyle = dataGridViewCellStyle9;
            this.id.HeaderText = "Alumno";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 120;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "idcurso";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.apellido.DefaultCellStyle = dataGridViewCellStyle10;
            this.apellido.HeaderText = "Curso";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 150;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "nota";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.NullValue = "No contiene";
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.usuario.DefaultCellStyle = dataGridViewCellStyle11;
            this.usuario.HeaderText = "Nota";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 200;
            // 
            // email
            // 
            this.email.DataPropertyName = "condicion";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.NullValue = "No contiene";
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.email.DefaultCellStyle = dataGridViewCellStyle12;
            this.email.HeaderText = "Condicion";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 200;
            // 
            // AlumnosInscripciones
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
            this.Name = "AlumnosInscripciones";
            this.Text = "AlumnosInscripciones";
            this.Load += new System.EventHandler(this.AlumnosInscripciones_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInscripciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CicButton BotonModificar;
        private CicButton BotonBorrar;
        private CicButton BotonActualizar;
        private CicButton BotonAgregar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DataGridViewInscripciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}