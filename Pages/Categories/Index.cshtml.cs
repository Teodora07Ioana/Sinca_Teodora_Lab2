using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sinca_Teodora_Lab2.Data;
using Sinca_Teodora_Lab2.Models;
using Sinca_Teodora_Lab2.Models.ViewModels;

namespace Sinca_Teodora_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Sinca_Teodora_Lab2.Data.Sinca_Teodora_Lab2Context _context;

        public IndexModel(Sinca_Teodora_Lab2.Data.Sinca_Teodora_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public CategoriesIndexData CategoryData { get; set; }
        public int CategoryID { get; set; }
        public int BookID { get; set; }
        public async Task OnGetAsync(int? id, int? bookID)
        {
            CategoryData = new CategoriesIndexData();
            CategoryData.Publishers = await _context.Category.Include(i => i.BookCategories).ThenInclude(c => c.Book.Author).OrderBy(i => i.CategoryName).ToListAsync();
            if (id != null)
            {
                CategoryID = id.Value;
                Category category = CategoryData.Publishers.Where(i => i.ID == id.Value).Single();
                CategoryData.Books = category.BookCategories.Select(bc => bc.Book).ToList();
            }
        }

            /*if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }*/
        }
}
