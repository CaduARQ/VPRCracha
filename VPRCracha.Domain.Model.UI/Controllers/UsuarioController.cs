using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VPRCracha.Domain.Model.Repository;
using VPRCracha.Domain.Model.Repository.SQServer.Impl;

namespace VPRCracha.Domain.Model.UI.Controllers
{
    public class UsuarioController : Controller
    {
        private IRepository<Usuario> __repository;

        public UsuarioController()
        {
            __repository = new Repository<Usuario>();
        }
        //
        // GET: /Usuario/

        public ActionResult ListaUsuarios()
        {
            ViewData["ajax"] = true;
            ViewData["scrolling"] = true;
            ViewData["paging"] = true;
            ViewData["filtering"] = true;
            ViewData["grouping"] = true;
            ViewData["sorting"] = true;
            ViewData["showFooter"] = true;

            return View(this.__repository.ListaTodos());
        }

        //
        // GET: /Usuario/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Usuario/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Usuario/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Usuario/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Usuario/Edit/5

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
        // GET: /Usuario/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Usuario/Delete/5

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
    }
}
