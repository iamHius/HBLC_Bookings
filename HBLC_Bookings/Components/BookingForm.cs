using HBLC_Bookings.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;


namespace HBLC_Bookings.Components
{
    public class BookingForm : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public BookingForm(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View("Index", _context.Bookings.ToList());
        }
    }
}
