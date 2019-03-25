using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Restaurante.Models;
using Restaurante.DAL;

namespace Restaurante.BLL
{
    public class EmpresaBLL
    {
        public List<Empresa> BuscaEmpresa()
        {
            EmpresaDAL dal = new EmpresaDAL();
            return dal.BuscaEmpresa();
        }

        public Empresa BuscaEmpresaId(int id)
        {
            EmpresaDAL dal = new EmpresaDAL();
            return dal.BuscaEmpresaId(id);
        }

        public void EditarUpdate(Empresa model)
        {
            EmpresaDAL dal = new EmpresaDAL();
            dal.EditarUpdate(model);
        }

        public  void Save(Empresa modal)
        {
            EmpresaDAL dal = new EmpresaDAL();
            dal.Save(modal);
        }

        internal void Delete(int id)
        {
            EmpresaDAL dal = new EmpresaDAL();
            dal.Delete(id);
        }
    }
}