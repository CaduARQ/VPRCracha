using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Web.Mvc;
using VPRCracha.Domain.Model.Repository;
using VPRCracha.Domain.Model.Repository.SQServer.Impl;

namespace VPRCracha.Domain.Model.UI.Controllers
{
    public class RegiaoController : Controller
    {
        private IRegiaoRepository regiaoRepository;

        public RegiaoController()
        {
            ViewData["ajax"] = true;
            ViewData["scrolling"] = true;
            ViewData["paging"] = true;
            ViewData["filtering"] = true;
            ViewData["grouping"] = true;
            ViewData["sorting"] = true;
            ViewData["showFooter"] = true;

            this.regiaoRepository = new RegiaoRepository();
        }        

        public ActionResult Index()
        {
            return View(this.regiaoRepository.ListaTodos());
        }

        [GridAction]
        public ActionResult _Index()
        {
            return View(this.regiaoRepository.ListaTodos());
        }

        public ActionResult SelectionClientSide()
        {
            return View();
        }

        [GridAction]
        public void _SelectionClientSide_UsuarioResponsavel(int idUsuario)
        {
            ViewData["idUsuarioResponsavelRegiao"] = idUsuario;
        }
        //
        // GET: /Regiao/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Regiao/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Regiao/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var regiaoNova = new Regiao()
                                     {
                                         Nome = collection["Nome"],
                                         ResponsavelRegiao = new Usuario() 
                                         {
                                             Nome = collection["ResponsavelRegiao.Nome"],
                                             Login = collection["ResponsavelRegiao.Login"],
                                             Senha = collection["ResponsavelRegiao.Senha"],
                                         }
                                     };

                this.regiaoRepository.Salvar(regiaoNova);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Regiao/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Regiao/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Regiao/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Regiao/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public IEnumerable<Usuario> UsuariosCadastrados { get; set; }
    }
}
