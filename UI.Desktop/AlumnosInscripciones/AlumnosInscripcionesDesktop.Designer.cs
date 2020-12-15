namespace UI.Desktop
{
    partial class AlumnosInscripcionesDesktop
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxIdComision = new System.Windows.Forms.TextBox();
            this.ComboComision = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxIdAlumno = new System.Windows.Forms.TextBox();
            this.ComboAlumno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxId = new System.Windows.Forms.TextBox();
            this.TextBoxNota = new System.Windows.Forms.TextBox();
            this.TextBoxCondicion = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxNota, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxCondicion, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 210);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Inscripcion";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.TextBoxIdComision, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ComboComision, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(153, 70);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 50);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // TextBoxIdComision
            // 
            this.TextBoxIdComision.Location = new System.Drawing.Point(3, 3);
            this.TextBoxIdComision.Name = "TextBoxIdComision";
            this.TextBoxIdComision.ReadOnly = true;
            this.TextBoxIdComision.Size = new System.Drawing.Size(94, 20);
            this.TextBoxIdComision.TabIndex = 10;
            this.TextBoxIdComision.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxComision_Validating);
            this.TextBoxIdComision.Validated += new System.EventHandler(this.TextBoxComision_Validated);
            // 
            // ComboComision
            // 
            this.ComboComision.FormattingEnabled = true;
            this.ComboComision.Location = new System.Drawing.Point(103, 3);
            this.ComboComision.Name = "ComboComision";
            this.ComboComision.Size = new System.Drawing.Size(94, 21);
            this.ComboComision.TabIndex = 11;
            this.ComboComision.SelectedValueChanged += new System.EventHandler(this.ComboComision_SelectedValueChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BotonCancelar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BotonAceptar, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(153, 178);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(202, 26);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BotonCancelar.Location = new System.Drawing.Point(104, 3);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(75, 20);
            this.BotonCancelar.TabIndex = 10;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonAceptar.Location = new System.Drawing.Point(23, 3);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(75, 20);
            this.BotonAceptar.TabIndex = 9;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.TextBoxIdAlumno, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ComboAlumno, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(153, 29);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 35);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // TextBoxIdAlumno
            // 
            this.TextBoxIdAlumno.Location = new System.Drawing.Point(3, 3);
            this.TextBoxIdAlumno.Name = "TextBoxIdAlumno";
            this.TextBoxIdAlumno.ReadOnly = true;
            this.TextBoxIdAlumno.Size = new System.Drawing.Size(94, 20);
            this.TextBoxIdAlumno.TabIndex = 10;
            this.TextBoxIdAlumno.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxAlumno_Validating);
            this.TextBoxIdAlumno.Validated += new System.EventHandler(this.TextBoxAlumno_Validated);
            // 
            // ComboAlumno
            // 
            this.ComboAlumno.FormattingEnabled = true;
            this.ComboAlumno.Location = new System.Drawing.Point(103, 3);
            this.ComboAlumno.Name = "ComboAlumno";
            this.ComboAlumno.Size = new System.Drawing.Size(94, 21);
            this.ComboAlumno.TabIndex = 11;
            this.ComboAlumno.SelectedValueChanged += new System.EventHandler(this.ComboAlumno_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Comision";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Condicion";
            // 
            // TextBoxId
            // 
            this.TextBoxId.Location = new System.Drawing.Point(153, 3);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.ReadOnly = true;
            this.TextBoxId.Size = new System.Drawing.Size(100, 20);
            this.TextBoxId.TabIndex = 9;
            // 
            // TextBoxNota
            // 
            this.TextBoxNota.Location = new System.Drawing.Point(153, 126);
            this.TextBoxNota.MaxLength = 2;
            this.TextBoxNota.Name = "TextBoxNota";
            this.TextBoxNota.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNota.TabIndex = 10;
            this.TextBoxNota.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNota_Validating);
            this.TextBoxNota.Validated += new System.EventHandler(this.TextBoxNota_Validated);
            // 
            // TextBoxCondicion
            // 
            this.TextBoxCondicion.Location = new System.Drawing.Point(153, 152);
            this.TextBoxCondicion.Name = "TextBoxCondicion";
            this.TextBoxCondicion.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCondicion.TabIndex = 11;
            this.TextBoxCondicion.Text = "Inscripto";
            this.TextBoxCondicion.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxDescripcion_Validating);
            this.TextBoxCondicion.Validated += new System.EventHandler(this.TextBoxDescripcion_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AlumnosInscripcionesDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(358, 215);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AlumnosInscripcionesDesktop";
            this.Text = "AlumnosInscripcionesDesktop";
            this.Load += new System.EventHandler(this.AlumnosInscripcionesDesktop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox TextBoxIdComision;
        private System.Windows.Forms.ComboBox ComboComision;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox TextBoxIdAlumno;
        private System.Windows.Forms.ComboBox ComboAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxId;
        private System.Windows.Forms.TextBox TextBoxNota;
        private System.Windows.Forms.TextBox TextBoxCondicion;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}