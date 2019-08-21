using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Alura.ListaLeitura.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddRouting();
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app)
        {
            //app.UseDeveloperExceptionPage();
            app.UseMvcWithDefaultRoute();

        }
    }
}

//codigo comentado
//public Task Roteamento (HttpContext context)
        //{
        //    var _repo = new LivroRepositorioCSV();
        //    var caminhosAtendidos = new Dictionary<string, RequestDelegate>
        //    {
        //        { "/Livros/ParaLer", LivrosParaLer },
        //        { "/Livros/Lendo", LivrosLendo },
        //        { "/Livros/Lidos", LivrosLidos }
        //    };

        //    if (caminhosAtendidos.ContainsKey(context.Request.Path))
        //    {
        //        var metodo = caminhosAtendidos[context.Request.Path];
        //        return metodo.Invoke(context);
        //    }

        //    context.Response.StatusCode = 404;
        //    return context.Response.WriteAsync("Caminho inexistente.");
        //}        

        //public void comentario()
        //{
        //    //Metodo antigo

        //    //var routeBuilder = new RouteBuilder(app);
        //    //routeBuilder.MapRoute("Livros/ParaLer", LivroLogica.ParaLer);
        //    //routeBuilder.MapRoute("Livros/Lendo", LivroLogica.Lendo);
        //    //routeBuilder.MapRoute("Livros/Lidos", LivroLogica.Lidos);
        //    //routeBuilder.MapRoute("Cadastro/NovoLivro/{nome}/{autor}", CadastroLogica.NovoLivro);
        //    //routeBuilder.MapRoute("Livros/Detalhes/{id:int}", LivroLogica.Detalhes);
        //    //routeBuilder.MapRoute("Cadastro/ExibeFormulario", CadastroLogica.ExibeFormulario);
        //    //routeBuilder.MapRoute("Cadastro/Incluir", CadastroLogica.Incluir);

        //    //var rotas = routeBuilder.Build();

        //    //app.UseRouter(rotas);

        //    //app.Run(Roteamento);
        //}