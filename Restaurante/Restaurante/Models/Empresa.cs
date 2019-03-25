namespace Restaurante.Models
{
    public class Empresa
    {
        private int id;
        public int Id { get => this.id; set => this.id = value; }

        private string nomeEmpresa;

        public string NomeEmpresa { get => this.nomeEmpresa; set => this.nomeEmpresa = value; }
    }
}