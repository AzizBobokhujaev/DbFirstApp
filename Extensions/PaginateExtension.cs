using DbFirstApp.Models;

namespace DbFirstApp.Extensions;

public static class PaginateExtension
{
    public static IQueryable<T> Paginate<T>(this IQueryable<T> source, PaginateParameters parameters) =>
        source.Skip((parameters.PageNumber - 1) * parameters.PageSize)
            .Take(parameters.PageSize);
}