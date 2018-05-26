namespace Radix.Gateway.Domain
{
    public class User
    {
        public string Id  { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool UtilizaSistemaAntifraudes { get; set; }
        public Adquirente Adquirente { get; set; }
    }
}