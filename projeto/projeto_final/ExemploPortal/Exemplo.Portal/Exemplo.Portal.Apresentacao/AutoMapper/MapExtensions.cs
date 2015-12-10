using AutoMapper;

namespace Exemplo.Portal.Apresentacao.AutoMapper
{
    public static class MapExtensions
    {
        public static TDestination MapTo<TSource, TDestination>(TSource source, TDestination destination)
        {
            return Mapper.Map<TSource, TDestination>(source, destination);
        }

        public static TDestination MapTo<TDestination>(this object source)
        {
            return Mapper.Map<TDestination>(source);
        }
    }
}