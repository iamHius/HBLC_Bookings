using HBLC_Bookings.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace HBLC_Bookings.Components
{
    public class RoomForm : ViewComponent 
    {
        private readonly ApplicationDbContext _context;
        public RoomForm(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View("Index",_context.Rooms.ToList());
        }
    }
}
