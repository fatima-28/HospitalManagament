namespace HospitalManagementSystem.Utilities
{
    public class PagedResult<T> where T:class
    {
        public PagedResult() { }
        public List<T> Data { get; set; }
        public int PageSize { get; set; }
        public int PageNum { get; set; }
        public int TotalItems { get; set; }
    }
}
