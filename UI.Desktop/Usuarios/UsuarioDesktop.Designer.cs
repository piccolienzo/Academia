namespace UI.Desktop
{
    partial class UsuarioDesktop
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
            this.LabelID = new System.Windows.Forms.Label();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelClave = new System.Windows.Forms.Label();
            this.LabelApellido = new System.Windows.Forms.Label();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.LabelConfirmarClave = new System.Windows.Forms.Label();
            this.CheckBoxHabilitado = new System.Windows.Forms.CheckBox();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.TextBoxClave = new System.Windows.Forms.TextBox();
            this.TextBoxApellido = new System.Windows.Forms.TextBox();
            this.TextBoxUsuario = new System.Windows.Forms.TextBox();
            this.TextBoxConfirmarClave = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.ErrorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.LabelID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelNombre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelEmail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LabelClave, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LabelApellido, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelUsuario, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.LabelConfirmarClave, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.CheckBoxHabilitado, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BotonAceptar, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.BotonCancelar, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxNombre, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxClave, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxApellido, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxUsuario, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxConfirmarClave, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxEmail, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(681, 168);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LabelID
            // 
            this.LabelID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(3, 0);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(96, 33);
            this.LabelID.TabIndex = 0;
            this.LabelID.Text = "ID";
            // 
            // LabelNombre
            // 
            this.LabelNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(3, 33);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(96, 33);
            this.LabelNombre.TabIndex = 1;
            this.LabelNombre.Text = "Nombre";
            // 
            // LabelEmail
            // 
            this.LabelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Location = new System.Drawing.Point(3, 66);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(96, 33);
            this.LabelEmail.TabIndex = 2;
            this.LabelEmail.Text = "Email";
            // 
            // LabelClave
            // 
            this.LabelClave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelClave.AutoSize = true;
            this.LabelClave.Location = new System.Drawing.Point(3, 99);
            this.LabelClave.Name = "LabelClave";
            this.LabelClave.Size = new System.Drawing.Size(96, 33);
            this.LabelClave.TabIndex = 3;
            this.LabelClave.Text = "Clave";
            // 
            // LabelApellido
            // 
            this.LabelApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelApellido.AutoSize = true;
            this.LabelApellido.Location = new System.Drawing.Point(343, 33);
            this.LabelApellido.Name = "LabelApellido";
            this.LabelApellido.Size = new System.Drawing.Size(96, 33);
            this.LabelApellido.TabIndex = 4;
            this.LabelApellido.Text = "Apellido";
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Location = new System.Drawing.Point(343, 66);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(96, 33);
            this.LabelUsuario.TabIndex = 5;
            this.LabelUsuario.Text = "Usuario";
            // 
            // LabelConfirmarClave
            // 
            this.LabelConfirmarClave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelConfirmarClave.AutoSize = true;
            this.LabelConfirmarClave.Location = new System.Drawing.Point(343, 99);
            this.LabelConfirmarClave.Name = "LabelConfirmarClave";
            this.LabelConfirmarClave.Size = new System.Drawing.Size(96, 33);
            this.LabelConfirmarClave.TabIndex = 6;
            this.LabelConfirmarClave.Text = "Confirmar Clave";
            // 
            // CheckBoxHabilitado
            // 
            this.CheckBoxHabilitado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxHabilitado.AutoSize = true;
            this.CheckBoxHabilitado.Location = new System.Drawing.Point(343, 3);
            this.CheckBoxHabilitado.Name = "CheckBoxHabilitado";
            this.CheckBoxHabilitado.Size = new System.Drawing.Size(96, 27);
            this.CheckBoxHabilitado.TabIndex = 7;
            this.CheckBoxHabilitado.Text = "Habilitado";
            this.CheckBoxHabilitado.UseVisualStyleBackColor = true;
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonAceptar.Location = new System.Drawing.Point(364, 142);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(75, 23);
            this.BotonAceptar.TabIndex = 8;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BotonCancelar.Location = new System.Drawing.Point(445, 142);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotonCancelar.TabIndex = 9;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // TextBoxID
            // 
            this.TextBoxID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxID.Location = new System.Drawing.Point(105, 3);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.ReadOnly = true;
            this.TextBoxID.Size = new System.Drawing.Size(232, 20);
            this.TextBoxID.TabIndex = 10;
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNombre.Location = new System.Drawing.Point(105, 36);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(232, 20);
            this.TextBoxNombre.TabIndex = 11;
            this.TextBoxNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNombre_Validating);
            // 
            // TextBoxClave
            // 
            this.TextBoxClave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxClave.Location = new System.Drawing.Point(105, 102);
            this.TextBoxClave.Name = "TextBoxClave";
            this.TextBoxClave.PasswordChar = '*';
            this.TextBoxClave.Size = new System.Drawing.Size(232, 20);
            this.TextBoxClave.TabIndex = 13;
            this.TextBoxClave.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxClave_Validating);
            // 
            // TextBoxApellido
            // 
            this.TextBoxApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxApellido.Location = new System.Drawing.Point(445, 36);
            this.TextBoxApellido.Name = "TextBoxApellido";
            this.TextBoxApellido.Size = new System.Drawing.Size(233, 20);
            this.TextBoxApellido.TabIndex = 14;
            this.TextBoxApellido.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxApellido_Validating);
            // 
            // TextBoxUsuario
            // 
            this.TextBoxUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxUsuario.Location = new System.Drawing.Point(445, 69);
            this.TextBoxUsuario.Name = "TextBoxUsuario";
            this.TextBoxUsuario.Size = new System.Drawing.Size(233, 20);
            this.TextBoxUsuario.TabIndex = 15;
            this.TextBoxUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxUsuario_Validating);
            // 
            // TextBoxConfirmarClave
            // 
            this.TextBoxConfirmarClave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxConfirmarClave.Enabled = false;
            this.TextBoxConfirmarClave.Location = new System.Drawing.Point(445, 102);
            this.TextBoxConfirmarClave.Name = "TextBoxConfirmarClave";
            this.TextBoxConfirmarClave.PasswordChar = '*';
            this.TextBoxConfirmarClave.Size = new System.Drawing.Size(233, 20);
            this.TextBoxConfirmarClave.TabIndex = 16;
            this.TextBoxConfirmarClave.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxConfirmarClave_Validating);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxEmail.Location = new System.Drawing.Point(105, 69);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(232, 20);
            this.TextBoxEmail.TabIndex = 12;
            this.TextBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxEmail_Validating);
            // 
            // ErrorProviderApp
            // 
            this.ErrorProviderApp.BlinkRate = 1;
            this.ErrorProviderApp.ContainerControl = this;
            this.ErrorProviderApp.RightToLeft = true;
            // 
            // UsuarioDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(681, 168);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UsuarioDesktop";
            this.Text = "Usuario";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelClave;
        private System.Windows.Forms.Label LabelApellido;
        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.Label LabelConfirmarClave;
        private System.Windows.Forms.CheckBox CheckBoxHabilitado;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.TextBox TextBoxNombre;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox TextBoxClave;
        private System.Windows.Forms.TextBox TextBoxApellido;
        private System.Windows.Forms.TextBox TextBoxUsuario;
        private System.Windows.Forms.TextBox TextBoxConfirmarClave;
        private System.Windows.Forms.ErrorProvider ErrorProviderApp;
    }
}