namespace Mission11_Hendrickson.Models.ViewModels
{
    public class PaginationInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalNumPages => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); //casting it as a decimal so u can divide, and then maing it an int again. after result of Math.Ceiling is done, it will cast it as an int again
    }
}
