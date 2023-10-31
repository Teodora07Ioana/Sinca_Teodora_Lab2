using Sinca_Teodora_Lab2.Models;

namespace Sinca_Teodora_Lab2.Models.ViewModels
{
    public class CategoriesIndexData
    {
        public IEnumerable<Category> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
