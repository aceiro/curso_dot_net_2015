using AutoMapper;
using Exemplo.Portal.Apresentacao.ViewModel.Areas.Administrador;
using Exemplo.Portal.Dominio.Entidades;

namespace Exemplo.Portal.Apresentacao.AutoMapper
{
    public class ViewModelToDomainMapperProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomainMapper";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<CategoriaViewModel, Categoria>();
        }
    }
}