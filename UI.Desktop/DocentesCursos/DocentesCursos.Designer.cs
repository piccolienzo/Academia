namespace UI.Desktop
{
    partial class DocentesCursos
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
            this.DataGridViewDocentesCursos = new System.Windows.Forms.DataGridView();
            this.BotonModificar = new UI.Desktop.CicButton();
            this.BotonBorrar = new UI.Desktop.CicButton();
            this.BotonActualizar = new UI.Desktop.CicButton();
            this.BotonAgregar = new UI.Desktop.CicButton();
            this.idPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDocentesCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewDocentesCursos
            // 
            this.DataGridViewDocentesCursos.AllowUserToAddRows = false;
            this.DataGridViewDocentesCursos.AllowUserToDeleteRows = false;
            this.DataGridViewDocentesCursos.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewDocentesCursos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDocentesCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewDocentesCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDocentesCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPlan,
            this.desc_plan,
            this.idEsp,
            this.cargo});
            this.DataGridViewDocentesCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGridViewDocentesCursos.GridColor = System.Drawing.Color.White;
            this.DataGridViewDocentesCursos.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewDocentesCursos.MultiSelect = false;
            this.DataGridViewDocentesCursos.Name = "DataGridViewDocentesCursos";
            this.DataGridViewDocentesCursos.ReadOnly = true;
            this.DataGridViewDocentesCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewDocentesCursos.Size = new System.Drawing.Size(994, 563);
            this.DataGridViewDocentesCursos.TabIndex = 1;
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
            this.BotonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonModificar.Location = new System.Drawing.Point(312, 580);
            this.BotonModificar.Name = "BotonModificar";
            this.BotonModificar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BotonModificar.OnHoverButtonColor = System.Drawing.Color.White;
            this.BotonModificar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BotonModificar.Size = new System.Drawing.Size(160, 40);
            this.BotonModificar.TabIndex = 8;
            this.BotonModificar.Text = "Modificar";
            this.BotonModificar.TextColor = System.Drawing.Color.Black;
            this.BotonModificar.UseVisualStyleBackColor = false;
            this.BotonModificar.Click += new System.EventHandler(this.BotonEditar_Click);
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
            this.BotonBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBorrar.Location = new System.Drawing.Point(516, 580);
            this.BotonBorrar.Name = "BotonBorrar";
            this.BotonBorrar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BotonBorrar.OnHoverButtonColor = System.Drawing.Color.White;
            this.BotonBorrar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BotonBorrar.Size = new System.Drawing.Size(160, 40);
            this.BotonBorrar.TabIndex = 9;
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
            this.BotonActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonActualizar.Location = new System.Drawing.Point(728, 580);
            this.BotonActualizar.Name = "BotonActualizar";
            this.BotonActualizar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BotonActualizar.OnHoverButtonColor = System.Drawing.Color.White;
            this.BotonActualizar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BotonActualizar.Size = new System.Drawing.Size(160, 40);
            this.BotonActualizar.TabIndex = 11;
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
            this.BotonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BotonAgregar.Location = new System.Drawing.Point(92, 580);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BotonAgregar.OnHoverButtonColor = System.Drawing.Color.White;
            this.BotonAgregar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BotonAgregar.Size = new System.Drawing.Size(160, 40);
            this.BotonAgregar.TabIndex = 10;
            this.BotonAgregar.Text = "Nuevo";
            this.BotonAgregar.TextColor = System.Drawing.Color.Black;
            this.BotonAgregar.UseVisualStyleBackColor = false;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // idPlan
            // 
            this.idPlan.DataPropertyName = "id";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.idPlan.DefaultCellStyle = dataGridViewCellStyle2;
            this.idPlan.HeaderText = "ID Dictado";
            this.idPlan.Name = "idPlan";
            this.idPlan.ReadOnly = true;
            this.idPlan.Width = 150;
            // 
            // desc_plan
            // 
            this.desc_plan.DataPropertyName = "descripcion";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.desc_plan.DefaultCellStyle = dataGridViewCellStyle3;
            this.desc_plan.HeaderText = "ID Curso";
            this.desc_plan.Name = "desc_plan";
            this.desc_plan.ReadOnly = true;
            this.desc_plan.Width = 150;
            // 
            // idEsp
            // 
            this.idEsp.DataPropertyName = "idespecialidad";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.idEsp.DefaultCellStyle = dataGridViewCellStyle4;
            this.idEsp.HeaderText = "ID Docente";
            this.idEsp.Name = "idEsp";
            this.idEsp.ReadOnly = true;
            this.idEsp.Width = 150;
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 150;
            // 
            // DocentesCursos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 698);
            this.Controls.Add(this.BotonModificar);
            this.Controls.Add(this.BotonBorrar);
            this.Controls.Add(this.BotonActualizar);
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.DataGridViewDocentesCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DocentesCursos";
            this.Text = "DocentesCursos";
            this.Load += new System.EventHandler(this.DocentesCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDocentesCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewDocentesCursos;
        private CicButton BotonModificar;
        private CicButton BotonBorrar;
        private CicButton BotonActualizar;
        private CicButton BotonAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
    }
}