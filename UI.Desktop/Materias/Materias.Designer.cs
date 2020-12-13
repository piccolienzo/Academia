namespace UI.Desktop
{
    partial class Materias
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DataGridViewMaterias = new System.Windows.Forms.DataGridView();
            this.idMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsSemanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BotonModificar = new UI.Desktop.CicButton();
            this.BotonBorrar = new UI.Desktop.CicButton();
            this.BotonAgregar = new UI.Desktop.CicButton();
            this.BotonActualizar = new UI.Desktop.CicButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DataGridViewMaterias, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.50246F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(994, 569);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DataGridViewMaterias
            // 
            this.DataGridViewMaterias.AllowUserToAddRows = false;
            this.DataGridViewMaterias.AllowUserToDeleteRows = false;
            this.DataGridViewMaterias.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewMaterias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewMaterias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMateria,
            this.descripcionMateria,
            this.idPlan,
            this.hsSemanales,
            this.hsTotales});
            this.DataGridViewMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewMaterias.GridColor = System.Drawing.Color.White;
            this.DataGridViewMaterias.Location = new System.Drawing.Point(3, 3);
            this.DataGridViewMaterias.MultiSelect = false;
            this.DataGridViewMaterias.Name = "DataGridViewMaterias";
            this.DataGridViewMaterias.ReadOnly = true;
            this.DataGridViewMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewMaterias.Size = new System.Drawing.Size(988, 563);
            this.DataGridViewMaterias.TabIndex = 1;
            // 
            // idMateria
            // 
            this.idMateria.DataPropertyName = "id";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.idMateria.DefaultCellStyle = dataGridViewCellStyle2;
            this.idMateria.HeaderText = "ID Materia";
            this.idMateria.Name = "idMateria";
            this.idMateria.ReadOnly = true;
            this.idMateria.Width = 130;
            // 
            // descripcionMateria
            // 
            this.descripcionMateria.DataPropertyName = "descripcion";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.descripcionMateria.DefaultCellStyle = dataGridViewCellStyle3;
            this.descripcionMateria.HeaderText = "Descripcion";
            this.descripcionMateria.Name = "descripcionMateria";
            this.descripcionMateria.ReadOnly = true;
            this.descripcionMateria.Width = 480;
            // 
            // idPlan
            // 
            this.idPlan.DataPropertyName = "idplan";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.idPlan.DefaultCellStyle = dataGridViewCellStyle4;
            this.idPlan.HeaderText = "ID Plan";
            this.idPlan.Name = "idPlan";
            this.idPlan.ReadOnly = true;
            // 
            // hsSemanales
            // 
            this.hsSemanales.DataPropertyName = "hssemanales";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.hsSemanales.DefaultCellStyle = dataGridViewCellStyle5;
            this.hsSemanales.HeaderText = "HS. Sem.";
            this.hsSemanales.Name = "hsSemanales";
            this.hsSemanales.ReadOnly = true;
            this.hsSemanales.Width = 110;
            // 
            // hsTotales
            // 
            this.hsTotales.DataPropertyName = "hstotales";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.hsTotales.DefaultCellStyle = dataGridViewCellStyle6;
            this.hsTotales.HeaderText = "HS. Total";
            this.hsTotales.Name = "hsTotales";
            this.hsTotales.ReadOnly = true;
            this.hsTotales.Width = 110;
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
            this.BotonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonModificar.Location = new System.Drawing.Point(305, 619);
            this.BotonModificar.Name = "BotonModificar";
            this.BotonModificar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BotonModificar.OnHoverButtonColor = System.Drawing.Color.White;
            this.BotonModificar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BotonModificar.Size = new System.Drawing.Size(160, 40);
            this.BotonModificar.TabIndex = 0;
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
            this.BotonBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBorrar.Location = new System.Drawing.Point(525, 619);
            this.BotonBorrar.Name = "BotonBorrar";
            this.BotonBorrar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BotonBorrar.OnHoverButtonColor = System.Drawing.Color.White;
            this.BotonBorrar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BotonBorrar.Size = new System.Drawing.Size(160, 40);
            this.BotonBorrar.TabIndex = 1;
            this.BotonBorrar.Text = "Borrar";
            this.BotonBorrar.TextColor = System.Drawing.Color.Black;
            this.BotonBorrar.UseVisualStyleBackColor = true;
            this.BotonBorrar.Click += new System.EventHandler(this.BotonBorrar_Click);
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
            this.BotonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgregar.Location = new System.Drawing.Point(95, 619);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BotonAgregar.OnHoverButtonColor = System.Drawing.Color.White;
            this.BotonAgregar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BotonAgregar.Size = new System.Drawing.Size(160, 40);
            this.BotonAgregar.TabIndex = 2;
            this.BotonAgregar.Text = "Nuevo";
            this.BotonAgregar.TextColor = System.Drawing.Color.Black;
            this.BotonAgregar.UseVisualStyleBackColor = true;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
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
            this.BotonActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonActualizar.Location = new System.Drawing.Point(730, 619);
            this.BotonActualizar.Name = "BotonActualizar";
            this.BotonActualizar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BotonActualizar.OnHoverButtonColor = System.Drawing.Color.White;
            this.BotonActualizar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BotonActualizar.Size = new System.Drawing.Size(160, 40);
            this.BotonActualizar.TabIndex = 3;
            this.BotonActualizar.Text = "Actualizar";
            this.BotonActualizar.TextColor = System.Drawing.Color.Black;
            this.BotonActualizar.UseVisualStyleBackColor = true;
            this.BotonActualizar.Click += new System.EventHandler(this.BotonActualizar_Click);
            // 
            // Materias
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 698);
            this.Controls.Add(this.BotonModificar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BotonBorrar);
            this.Controls.Add(this.BotonActualizar);
            this.Controls.Add(this.BotonAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Materias";
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.Materias_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMaterias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DataGridViewMaterias;
        private CicButton BotonModificar;
        private CicButton BotonBorrar;
        private CicButton BotonAgregar;
        private CicButton BotonActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsSemanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsTotales;
    }
}