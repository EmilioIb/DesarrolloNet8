using DesarrolloNet8Razor.Data;
using DesarrolloNet8Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DesarrolloNet8Razor.Pages.Categories
{
    public class IndexModel : PageModel
    {
        public List<Category> CategoryList { get; set; }
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }
    }
}
