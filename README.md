# EzyPaging
Minimal paging model and extensions for .NET Core projects

## Classes provided:

- PageModel: Paging model, linq-y format with skip & take integers.
- HttpRequestExtensions: Extension to extract a PageModel instance from the query parameters of an HttpRequest object.
- IQueryableExtensions: Extension to apply the values from a PageModel instance to any IQueryable.

*Both extensions default to 0 if any value is missing.
