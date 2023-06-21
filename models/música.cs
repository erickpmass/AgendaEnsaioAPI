namespace AgendaDeEnsaio.models
{
    public class Música
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Artista { get; set; }
        public string TempoDeDuração { get; set; }
        public EstiloEnum Estilo { get; set; }
        public string Dificuldade { get; set; }
        public string PréRequisitos { get; set; }
    }
}