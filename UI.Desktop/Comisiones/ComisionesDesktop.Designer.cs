namespace UI.Desktop
{
    partial class ComisionesDesktop
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
            this.TextBoxAñoEsp = new System.Windows.Forms.TextBox();
            this.TextBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxIdPlan = new System.Windows.Forms.TextBox();
            this.ComboBoxPlanes = new System.Windows.Forms.ComboBox();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.56436F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.43565F));
            this.tableLayoutPanel1.Controls.Add(this.TextBoxAñoEsp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxDescripcion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxID, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(404, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TextBoxAñoEsp
            // 
            this.TextBoxAñoEsp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBoxAñoEsp.Location = new System.Drawing.Point(78, 187);
            this.TextBoxAñoEsp.Name = "TextBoxAñoEsp";
            this.TextBoxAñoEsp.Size = new System.Drawing.Size(100, 20);
            this.TextBoxAñoEsp.TabIndex = 6;
            this.TextBoxAñoEsp.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxAñoEsp_Validating);
            this.TextBoxAñoEsp.Validated += new System.EventHandler(this.TextBoxAñoEsp_Validated);
            // 
            // TextBoxDescripcion
            // 
            this.TextBoxDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBoxDescripcion.Location = new System.Drawing.Point(78, 111);
            this.TextBoxDescripcion.Name = "TextBoxDescripcion";
            this.TextBoxDescripcion.Size = new System.Drawing.Size(100, 20);
            this.TextBoxDescripcion.TabIndex = 5;
            this.TextBoxDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxDescripcion_Validating);
            this.TextBoxDescripcion.Validated += new System.EventHandler(this.TextBoxDescripcion_Validated);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Comision";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año de especialidad";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID Plan";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BotonAceptar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BotonCancelar, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(78, 311);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(285, 107);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(145, 3);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(75, 23);
            this.BotonAceptar.TabIndex = 1;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(3, 3);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotonCancelar.TabIndex = 0;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.TextBoxIdPlan, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ComboBoxPlanes, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(78, 236);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(258, 69);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // TextBoxIdPlan
            // 
            this.TextBoxIdPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBoxIdPlan.Enabled = false;
            this.TextBoxIdPlan.Location = new System.Drawing.Point(3, 24);
            this.TextBoxIdPlan.Name = "TextBoxIdPlan";
            this.TextBoxIdPlan.Size = new System.Drawing.Size(100, 20);
            this.TextBoxIdPlan.TabIndex = 7;
            // 
            // ComboBoxPlanes
            // 
            this.ComboBoxPlanes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ComboBoxPlanes.FormattingEnabled = true;
            this.ComboBoxPlanes.Location = new System.Drawing.Point(132, 24);
            this.ComboBoxPlanes.Name = "ComboBoxPlanes";
            this.ComboBoxPlanes.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxPlanes.TabIndex = 8;
            this.ComboBoxPlanes.SelectedValueChanged += new System.EventHandler(this.ComboBoxPlanes_SelectedValueChanged);
            // 
            // TextBoxID
            // 
            this.TextBoxID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBoxID.Enabled = false;
            this.TextBoxID.Location = new System.Drawing.Point(78, 30);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(100, 20);
            this.TextBoxID.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Tag = "";
            // 
            // ComisionesDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ComisionesDesktop";
            this.Text = "ComisionesDesktop";
            this.Load += new System.EventHandler(this.ComisionesDesktop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxIdPlan;
        private System.Windows.Forms.TextBox TextBoxAñoEsp;
        private System.Windows.Forms.TextBox TextBoxDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox ComboBoxPlanes;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}