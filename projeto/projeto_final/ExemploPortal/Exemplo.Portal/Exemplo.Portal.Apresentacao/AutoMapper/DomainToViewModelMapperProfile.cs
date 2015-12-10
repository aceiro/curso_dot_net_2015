using AutoMapper;
using Exemplo.Portal.Apresentacao.ViewModel.Areas.Administrador;
using Exemplo.Portal.Dominio.Entidades;
using System.Collections.Generic;

namespace Exemplo.Portal.Apresentacao.AutoMapper
{
    public class DomainToViewModelMapperProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMapper";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Categoria, CategoriaViewModel>();            
        }
    }
}