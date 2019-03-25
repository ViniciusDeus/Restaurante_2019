using Restaurante.BLL;
using Restaurante.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Restaurante.Controllers
{
    public class EmpresaController : Controller
    {        
            // GET: Empresa
        public ActionResult Index()
        {
            EmpresaBLL bll = new EmpresaBLL();
            List<Empresa> listEmpresa = new List<Empresa>();

            listEmpresa = bll.BuscaEmpresa();
            
            return View(listEmpresa);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            EmpresaBLL bll = new EmpresaBLL();
            Empresa empresaDTO = new Empresa();

            empresaDTO = bll.BuscaEmpresaId(id);
            return View(empresaDTO);
        }

        [HttpGet]
        public ActionResult Update(Empresa model)
        {
            EmpresaBLL bll = new EmpresaBLL();
            if (ModelState.IsValid)
            {
                bll.EditarUpdate(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Delete(int id)
        {
            EmpresaBLL bll = new EmpresaBLL();
            bll.Delete(id);
            return RedirectToAction("Index");
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Empresa modal)
        {
            EmpresaBLL bll = new EmpresaBLL();
            if (ModelState.IsValid)
            {
                bll.Save(modal);
                return RedirectToAction("Index");
            }
            else
            {
                return View(modal);
            }
        }
    }
}