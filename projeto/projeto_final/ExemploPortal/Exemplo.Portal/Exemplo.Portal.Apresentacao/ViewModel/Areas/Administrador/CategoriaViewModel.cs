using System.ComponentModel.DataAnnotations;

namespace Exemplo.Portal.Apresentacao.ViewModel.Areas.Administrador
{
    public class CategoriaViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public byte[] Versao { get; set; }
    }
}