namespace AgendaDeEnsaio.models
{
    public class Agenda
    {
        public int Id { get; set; }
        public List<Música> Musica { get; set; }
        public string DiaDaSemana { get; set; }
        public string Disponibilidade { get; set; }
    }
}