using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class DocenteCursoLogic : BusinessLogic
    {

        public DocenteCursoAdapter DocenteCursoData;

        public DocenteCursoLogic()
        {
            DocenteCursoData = new DocenteCursoAdapter();
        }

        public DocenteCurso GetOne(int id)
        {
            return DocenteCursoData.GetOne(id);
        }
        public List<DocenteCurso> GetAll()
        {
            return DocenteCursoData.GetAll();
        }


        public void Save(DocenteCurso docenteCurso)
        {
            DocenteCursoData.Save(docenteCurso);
        }

        public void Delete(int id)
        {
            DocenteCursoData.Delete(id);
        }

    }
}