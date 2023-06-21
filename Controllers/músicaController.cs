using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AgendaDeEnsaio.models;

namespace AgendaDeEnsaio.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class músicaController : ControllerBase
    {
        private static List<Música> músicas = new List<Música>()
        {
            new Música() { Id = 1, Nome = "Charismatic", Artista = "DROP The Beat", TempoDeDuração = "3min6seg", Dificuldade = "Médio", PréRequisitos = "Nenhum", Estilo = EstiloEnum.Kpop },
            new Música() { Id = 2, Nome = "golden hour", Artista = "JVKE", TempoDeDuração = "3min29seg", Dificuldade = "Díficil", PréRequisitos = "Balé Básico e Tutting Básico", Estilo = EstiloEnum.Contemporâneo},
            new Música() { Id = 3, Nome = "Pitbull Sem Coleira", Artista = "Bixarte & Urias", TempoDeDuração = "2min22seg", Dificuldade = "Fácil", PréRequisitos = "Nenhum", Estilo = EstiloEnum.Funk },
            new Música() { Id = 4, Nome = "HUMBLE", Artista = "Kendrick Lamar", TempoDeDuração = "2min57seg", Dificuldade = "Médio", PréRequisitos = "Street Dance Básico", Estilo = EstiloEnum.HipHop },
            new Música() { Id = 5, Nome = "Her Mind", Artista = "Urias", TempoDeDuração = "2min14seg", Dificuldade = "Díficil", PréRequisitos = "Tutting Avançado", Estilo = EstiloEnum.Eletrônica },
            new Música() { Id = 6, Nome = "Side to Side", Artista = "Ariana Grande & Nicki Minaj", TempoDeDuração = "3min46seg", Dificuldade = "Fácil", PréRequisitos = "Nenhum", Estilo = EstiloEnum.Pop},
            new Música() { Id = 7, Nome = "Conto do Vigário", Artista = "MC Carol", TempoDeDuração = "2min34seg", Dificuldade = "Fácil", PréRequisitos = "Locking", Estilo = EstiloEnum.Funk },
            new Música() { Id = 8, Nome = "Body Do", Artista = "Chlöe", TempoDeDuração = "2min20seg", Dificuldade = "Díficil", PréRequisitos = "Tutting Avançado", Estilo = EstiloEnum.Vogue }
        };
        
        public IActionResult GetFirst()
        {
            Música m = músicas[0];
            return Ok(m);
        }
    }
}