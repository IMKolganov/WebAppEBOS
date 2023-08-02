namespace WebAppEBOS.Data.Extensions;

public static partial class DbContextExtensions
{
    // public static IQueryable<TProjection> BuildQuery<TEntity, TProjection>(
    //     this DbSet<TEntity> context, IExpressionSpecification<TEntity> spec, TypeAdapterConfig adapterConfig) 
    //     where TEntity : class
    // {
    //     context.ThrowIfNull(nameof(context));
    //
    //     var query = context
    //         .BuildQuery(spec)
    //         .ProjectToType<TProjection>(adapterConfig);
    //
    //     return query;
    // }
    //
    // public static IQueryable<TEntity> BuildQuery<TEntity>(
    //     this IQueryable<TEntity> context, IExpressionSpecification<TEntity> spec) 
    //     where TEntity : class
    // {
    //     context.ThrowIfNull(nameof(context));
    //     
    //    var query = spec switch
    //     {
    //         IQueryPageOrderBy<TEntity> querySpecification => BuildPageQueryOrderBy(context, querySpecification),
    //         IQueryOrderBy<TEntity> querySpecification => BuildQueryOrderBy(context, querySpecification),
    //         IPageSpecification<TEntity> pageSpecification => BuildPageQuery(context, pageSpecification),
    //         IQuerySpecification<TEntity> querySpecification => BuildQueryInternal(context, querySpecification),
    //         _ => context.Where(spec.Expression)
    //     };
    //
    //    return query;
    // }
    //
    // private static IQueryable<TEntity> BuildQueryInternal<TEntity>(
    //     IQueryable<TEntity> context, IQuerySpecification<TEntity> specification) 
    //     where TEntity : class
    // {
    //     return context
    //         .Where(specification.Expression)
    //         .Take(specification.Size);
    // }
    // private static IQueryable<TEntity> BuildQueryOrderBy<TEntity>(
    //     IQueryable<TEntity> context, IQueryOrderBy<TEntity> specification) 
    //     where TEntity : class
    // {
    //     IQueryable<TEntity> fQuery = context
    //         .Where(specification.Expression)
    //         .Take(specification.Size);
    //     if (specification._Type == enOrderByType.asc)
    //         return fQuery.OrderBy(specification.OrderByExpression);
    //     return fQuery.OrderByDescending(specification.OrderByExpression);
    // }    
    // private static IQueryable<TEntity> BuildPageQueryOrderBy<TEntity>(
    //     IQueryable<TEntity> context, IQueryPageOrderBy<TEntity> specification) 
    //     where TEntity : class
    // {
    //     var skipCount = specification.Index * specification.Size;
    //     var fQuery = BuildQueryOrderBy(context,specification);
    //     return fQuery.Skip(skipCount);
    //
    // }
    //
    // private static IQueryable<TEntity> BuildPageQuery<TEntity>(
    //     IQueryable<TEntity> context, IPageSpecification<TEntity> specification) 
    //     where TEntity : class
    // {
    //     var skipCount = specification.Index * specification.Size;
    //     
    //     return context
    //         .Where(specification.Expression)
    //         .Skip(skipCount)
    //         .Take(specification.Size);
    // }
    //
    // public static bool IsMemoryProvider(this DbContext context) 
    //     => context.Database.ProviderName == "Microsoft.EntityFrameworkCore.InMemory";
    //
    // public static bool IsSqlServer(this DatabaseFacade database)
    //     => database.ProviderName == "Microsoft.EntityFrameworkCore.InMemory";
    //
}