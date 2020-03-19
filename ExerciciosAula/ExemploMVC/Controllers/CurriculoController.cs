using ExemploMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExemploMVC.Controllers
{
    public class CurriculoController : Controller
    {
        public IActionResult Index()
        {
            Curriculo Curriculo1 = new Curriculo()
           
            {
                Nome = "Patrik Eduardo da Silva",
                CPF = "030.899.180-05",
                Telefone = "51 98049-9494",
                Endereco = "Rua: Caxambu, N*689, Apto 14, Bairro: Vila Nova Cidade: Novo Hamburgo/RS",
                Habilitacao = "AB",
                Experience = "Experiência Profissional",
                Paludo = "Lojas Paludo LTDA: ",
                Exercito = "Exército Brasileiro: ",
                Wyntech = "Wyntech Serviços em Informática: ",
                Formation = "Formação Acadêmica",
                EnsinoMedio = "E.M.F.Borges de Medeiros: ",
                Tecnico = "Instituição Evangelica de Novo Hamburgo: ",
                Consideracao = "Atualmente busco um trabalho que viabilize desenvolver um crescimento profissional na área de Programação, tenho facilidade no trabalho em equipe e funções de liderança, busco sempre estar adquirindo conhecimento e melhorando tanto como profissional, como estar ajudando no crescimento da empresa."
            };
            return View(Curriculo1);
        }
    }
}