using HBLC_Bookings.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace HBLC_Bookings.Components
{
    public class SearchForm : ViewComponent 
    {
        private readonly ApplicationDbContext _context;

        public SearchForm(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Bookings.ToList());
        }
    }
}
