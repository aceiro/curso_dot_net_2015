using Exemplo.Portal.Dominio.Entidades.Interfaces;

namespace Exemplo.Portal.Dominio.Entidades
{
    public class Categoria : IIdentificador, IVersionador
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public byte[] Versao { get; set; }
    }
}
