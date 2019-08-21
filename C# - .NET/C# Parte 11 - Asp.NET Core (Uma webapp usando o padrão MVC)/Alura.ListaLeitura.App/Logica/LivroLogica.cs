using Alura.ListaLeitura.App.HTML;
using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App.Logica
{
    public class LivrosController : Controller
    {
        public IActionResult ParaLer(HttpContext contexto)
        {
            //var html = HtmlUtils.CarregaArquivoHTML("para-ler");
            var _repo = new LivroRepositorioCSV();


            //foreach (var livro in _repo.ParaLer.Livros)
            //{
            //    html = html.Replace("#NOVO-ITEM#", $"<li>{livro.Titulo} - {livro.Autor}</li>#NOVO-ITEM#");
            //}
            //html = html.Replace("#NOVO-ITEM#", "");
            //return contexto.Response.WriteAsync(html);
            ViewBag.Livros = _repo.ParaLer.Livros;
            //var html = new ViewResult { ViewName = "lista" };
            return View("lista");
        }

        public IActionResult Lendo(HttpContext contexto)
        {
            //var _repo = new LivroRepositorioCSV();
            //return contexto.Response.WriteAsync(_repo.Lendo.ToString());
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lendo.Livros;
            return View("lista");
        }
        public IActionResult Lidos(HttpContext contexto)
        {
            //var _repo = new LivroRepositorioCSV();
            //return contexto.Response.WriteAsync(_repo.Lidos.ToString());
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lidos.Livros;
            return View("lista");
        }
        public string Detalhes(int id)
        {
            var _repo = new LivroRepositorioCSV();
            var livro = _repo.Todos.First(l => l.Id == id);
            return livro.Detalhes();
        }

        public string Teste()
        {
            return "nova funcionabilidade implementada";
        }
    }
}
