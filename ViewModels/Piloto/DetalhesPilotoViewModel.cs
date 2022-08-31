namespace VoeAirlinesSenai.ViewModels.Piloto
{
    public class DetalhesPilotoViewModel
    {
        public DetalhesPilotoViewModel(int id, string nome, string matricula)
        {
            Id = id;
            Nome = nome;
            Matricula = matricula;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
    }
}