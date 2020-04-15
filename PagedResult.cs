using System;

namespace EzyPaging
{
    public class PagedResult<T>
    {
        public int? Total { get; set; }
        public T Result { get; set; }
    }
}
