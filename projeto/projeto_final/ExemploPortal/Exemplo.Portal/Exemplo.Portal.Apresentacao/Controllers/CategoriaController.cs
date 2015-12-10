using System;
using System.Web.Mvc;
using Exemplo.Portal.Apresentacao.AutoMapper;
using Exemplo.Portal.Apresentacao.ViewModel.Areas.Administrador;
using Exemplo.Portal.Dominio.Entidades;
using Exemplo.Portal.Dominio.Interfaces.Infra;
using System.Collections.Generic;
using Exemplo.Portal.Dominio.Interfaces.Servicos;

namespace Exemplo.Portal.Apresentacao.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly IUnidadeTrabalho _unidadeTrabalho;
        private readonly ICategoriaServico _categoriaServico;

        public CategoriaController(IUnidadeTrabalho unidadeTrabalho,
            ICategoriaServico categoriaRepositorio)
        {
            _unidadeTrabalho = unidadeTrabalho;
            _categoriaServico = categoriaRepositorio;
        }

        // GET: Categoria
        public ActionResult Index()
        {
            var model = _categoriaServico.Recuperar().MapTo<List<CategoriaViewModel>>();
            return View(model);
        }

        // GET: Categoria/Details/5
        public ActionResult Details(int id)
        {
            var model = _categoriaServico.Recuperar(id).MapTo<CategoriaViewModel>();
            return View(model);
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        public ActionResult Create(CategoriaViewModel model)
        {
            try
            {
                //TODO: Validar ModelState

                _unidadeTrabalho.Iniciar();
                _categoriaServico.Inserir(model.MapTo<Categoria>());
                _unidadeTrabalho.Salvar();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _categoriaServico.Recuperar(id).MapTo<CategoriaViewModel>();
            return View(model);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        public ActionResult Edit(CategoriaViewModel model)
        {
            try
            {
                //TODO: Validar ModelState

                _unidadeTrabalho.Iniciar();
                _categoriaServico.Alterar(model.MapTo<Categoria>());
                _unidadeTrabalho.Salvar();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(model);
            }
        }

        // GET: Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _categoriaServico.Recuperar(id).MapTo<CategoriaViewModel>();
            return View(model);
        }

        // POST: Categoria/Delete/5
        [HttpPost]
        public ActionResult Delete(CategoriaViewModel model)
        {
            try
            {
                //TODO: Validar ModelState

                _unidadeTrabalho.Iniciar();
                _categoriaServico.Remover(model.MapTo<Categoria>());
                _unidadeTrabalho.Salvar();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }
    }
}
