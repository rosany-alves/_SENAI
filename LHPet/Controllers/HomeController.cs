using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //Instância do tipo cliente
        Cliente cliente1 = new Cliente(01,"Arthur A. Ferreira","323.324.432-90","arthur@senai.br","Madruga");
        Cliente cliente2 = new Cliente(02,"Douglas A. Gomes","023.232.432-90","douglas@senai.br","Bug");
        Cliente cliente3 = new Cliente(03,"Ada A. Souza","323.122.325-90","ada@senai.br","Pinguim");
        Cliente cliente4 = new Cliente(04,"Nicolas O. Hopper","223.324.432-90","nicolas@senai.br","Pato");
        Cliente cliente5 = new Cliente(05,"Fernando P. Senna","423.111.432-90","fernando@senai.br","Golfinho");
        
        //lista de clientes
        List<Cliente>listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;


        //Instância do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01,"CTIN S/A","30.123.132/000-90","ctin@senai.br");
        Fornecedor fornecedor2 = new Fornecedor(02,"Intel Gog","40.123.132/000-90","inter@senai.br");
        Fornecedor fornecedor3 = new Fornecedor(03,"Tik Tok Cats","32.123.132/000-90","tiktok@senai.br");
        Fornecedor fornecedor4 = new Fornecedor(04,"Bifinho forever","323.324.432-90","bifinho@senai.br");
        Fornecedor fornecedor5 = new Fornecedor(05,"Cat&Dog INC","323.111.432-90","cat@senai.br");
        
        //lista de fornecedores
        List<Fornecedor>listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
