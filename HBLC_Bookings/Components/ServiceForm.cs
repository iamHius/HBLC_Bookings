using HBLC_Bookings.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace HBLC_Bookings.Components
{
    public class ServiceForm : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public ServiceForm(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View("Index",_context.RoomServices.ToList());
        }
    }
}
