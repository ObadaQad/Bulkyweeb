using BulkyWebRazor_Temp2.Data;
using BulkyWebRazor_Temp2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace BulkyWebRazor_Temp2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        
        private readonly ApplicationDbContext _db;
       
        public List<Category> CategoryList { get; set; }
        public IndexModel (ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
			CategoryList=_db.Categories.ToList();

		}
      
    }
}
