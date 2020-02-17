using Microsoft.AspNetCore.Http;

namespace EzyPaging
{
  public static class HttpRequestExtensions
    {
        /// <summary>
        /// Extracts paging from an HttpRequest, values searched are queryparams "skip" and "take"
        /// </summary>
        public static PageModel ExtractPaging(this HttpRequest request)
        {
            var skipValue = request.Query["skip"];
            var takeValue = request.Query["take"];

            _ = int.TryParse(skipValue, out var skip);
            _ = int.TryParse(takeValue, out var take);

            return new PageModel
            {
                Skip = skip,
                Take = take
            };
        }
    }
}
