using AutoMapper;

namespace Exemplo.Portal.Apresentacao.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings() 
        {
            Mapper.Initialize(m =>
            {
                m.AddProfile<DomainToViewModelMapperProfile>();
                m.AddProfile<ViewModelToDomainMapperProfile>();
            });
        }
    }
}