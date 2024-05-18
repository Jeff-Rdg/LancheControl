namespace LancheControl.DTO
{
    public class PagedResponseDto<T>
    {
        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public int TotalRecords { get; set; }
        public T Data { get; init; }
        
    }
}