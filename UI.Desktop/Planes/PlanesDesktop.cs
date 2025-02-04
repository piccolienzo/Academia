﻿using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;

namespace UI.Desktop
{
    public partial class PlanesDesktop : ApplicationForm
    {

        public Business.Entities.Plan PlanActual { get; set; }

        public PlanesDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public PlanesDesktop(int id, ModoForm modo) : this()
        {
            this.Modo = modo;
            Plan plan = new PlanLogic().GetOne(id);
            this.PlanActual = plan;
            this.MapearDeDatos();
        }
        public PlanesDesktop()
        {
            InitializeComponent();
        }

        public new void MapearDeDatos()
        {
            this.TextBoxId.Text = this.PlanActual.ID.ToString();
            this.TextBoxIdEspecialidad.Text = this.PlanActual.IdEspecialidad.ToString();
            this.TextBoxDescripcion.Text = this.PlanActual.Descripcion;

            if (this.Modo == ModoForm.Baja)
            {

                this.BotonAceptar.Text = "Eliminar";
                ComboBoxEspecialidades.Enabled = false;
                TextBoxDescripcion.Enabled = false;

            }
            else if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion)
            {

                this.BotonAceptar.Text = "Guardar";
            }
            else
            {
                this.BotonAceptar.Text = "Aceptar";
            }
        }
        public new void MapearADatos()
        {
            if (this.Modo == ModoForm.Alta)
            {
                Plan plan = new Plan();
                PlanActual = plan;

                this.PlanActual.Descripcion = this.TextBoxDescripcion.Text;
                this.PlanActual.IdEspecialidad = Convert.ToInt32(this.TextBoxIdEspecialidad.Text);



            }
            else if (this.Modo == ModoForm.Modificacion)
            {
                this.TextBoxIdEspecialidad.Enabled = false;
                this.PlanActual.Descripcion = this.TextBoxDescripcion.Text;

            }

            switch (this.Modo)
            {
                case ModoForm.Alta:
                    {
                        this.PlanActual.State = BusinessEntity.States.New;
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.PlanActual.State = BusinessEntity.States.Modified;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.PlanActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
                case ModoForm.Consulta:
                    {
                        this.PlanActual.State = BusinessEntity.States.Unmodified;
                        break;
                    }

            }


        }
        public new void GuardarCambios()
        {
            this.MapearADatos();
            PlanLogic planLogic = new PlanLogic();
            planLogic.Save(this.PlanActual);


        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        private new bool Validar()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (this.Continuar(this.BotonAceptar.Text, "Plan"))
                {
                    Notificar("Atención", "Cambios guardados", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Notificar("Error", "Existen errores, porfavor verificar el formulario", MessageBoxButtons.OK
                , MessageBoxIcon.Error);
                return false;
            }
        }

        private void TextBoxDescripcion_Validating(object sender, CancelEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                e.Cancel = true;
                errorProvider2.SetError(t, "No debe estar en blanco");
            }
        }

        private void TextBoxDescripcion_Validated(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            errorProvider2.SetError(t, "");
        }

        private void PlanesDesktop_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSetEspecialidades.especialidades' Puede moverla o quitarla según sea necesario.
            EspecialidadLogic especialidadLogic = new EspecialidadLogic();
            //Lista de planes


            this.ComboBoxEspecialidades.DataSource = especialidadLogic.GetAll();
            this.ComboBoxEspecialidades.DisplayMember = "descripcion";
            this.ComboBoxEspecialidades.ValueMember = "id";


        }

        private void BotonAgregarIdEspecialidad_Click(object sender, EventArgs e)
        {

            
            this.TextBoxIdEspecialidad.Text = (string)this.ComboBoxEspecialidades.SelectedValue.ToString();
        }

        private void ComboBoxEspecialidades_SelectedValueChanged(object sender, EventArgs e)
        {
            this.TextBoxIdEspecialidad.Text = (string)this.ComboBoxEspecialidades.SelectedValue.ToString();
        }
    }
}
