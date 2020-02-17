using System.Linq;

namespace EzyPaging
{
  public static class IQueryableExtensions
    {
        /// <summary>
        /// Applies the provided PageModel values to an IQueryable instance.
        /// </summary>
        public static IQueryable<T> AddPaging<T>(this IQueryable<T> queryable, PageModel pageModel)
        {
            return queryable.Skip(pageModel.Skip.GetValueOrDefault()).Take(pageModel.Take.GetValueOrDefault());
        }
    }
}
