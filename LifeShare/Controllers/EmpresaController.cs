using System;
using System.Collections.Generic;
using LifeShare.Persistencia;
using System.Linq;
using System.Threading.Tasks;
using LifeShare.Models;
using Microsoft.AspNetCore.Mvc;

namespace LifeShare.Controllers
{
    public class EmpresaController : Controller
    {
        private EmpresaContext _context;

        //Injeção de dependência pelo construtor
        public EmpresaController(EmpresaContext context)
        {
            _context = context;
        }

        //Método que cadastra no banco de dados POST
        [HttpPost]
        public IActionResult Cadastrar(Empresa empresa)
        {
            //Cadastrar no banco
            _context.Empresas.Add(empresa);
            _context.SaveChanges(); //commit
            //Mensagem de sucesso
            TempData["msg"] = "Empresa Cadastrada!";
            //Redirect 
            return RedirectToAction("Cadastrar");
        }

        //Criar o método que exibe o formulário de cadastro, criar tag helper, partial views
        [HttpGet] //http://localhost:1231/empresa/cadastrar
        public IActionResult Cadastrar()
        {
            return View(); //Abri a página /Views/empresa/Cadastrar.cshtml
        }

        //Listar todos os Empresa
        public IActionResult Index()
        {
            var lista = _context.Empresas.ToList();

            return View(lista);//enviar a lista para a view
        }

         //Método que recebe o id do Empresa e retorna a página de formulário com os dados
        [HttpGet]
        public IActionResult Editar(int Id)
        {
            //Pesquisar o Empresa pelo código
            var Empresa = _context.Empresas.Find(Id);
            return View(Empresa);  //Enviar o Empresa para a view
        }

        //Método que chama a model para atualizar os dados no banco de dados
        [HttpPost]
        public IActionResult Editar(Empresa Empresa)
        {
            //Atualizar a Empresa no banco
            //_context.Attach(Empresa).State = EntityState.Modified;
            _context.Empresas.Update(Empresa);
            //Commit
            _context.SaveChanges();
            //Mensagem de sucesso
            TempData["msg"] = "Empresa atualizada!";
            //Redirecionar para a listagem
            return RedirectToAction("Index");
        }

         //Método que recebe o id do empresa e aciona o model para remove-lo do banco
        [HttpPost]
        public IActionResult Remover(int Id)
        {
            //Pesquisar o empresa pelo id
            var empresa = _context.Empresas.Find(Id);
            //Remover o empresa
            _context.Empresas.Remove(empresa);
            //Commit
            _context.SaveChanges();
            //Mensagem
            TempData["msg"] = "Empresa Removida!";
            //Redirect para a página de listagem
            return RedirectToAction("Index");
        }

        //Método de pesquisa
        [HttpPost]
        public IActionResult Pesquisar(int EmpresaId)
        {
            //Pesquisar a empresa por id
            var lista = _context.Empresas.ToList();
            var empresa = lista.Find(current => current.EmpresaId == EmpresaId);

            return View(empresa);
        }

        [HttpGet]
        public IActionResult Pesquisar()
        {

            return View();
        }

    }
}
