using HBLC_Bookings.Areas.Identity.Pages.Account;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HBLC_Bookings.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        [ForeignKey("Room")]
        public int RoomId { get; set; }
        [ForeignKey("RoomService")]
        public int RoomServiceId { get; set; }
        public DateTime BookingFromDate { get; set; }
        public DateTime BookingToDate { get; set; }
        public int? BookingDuration { get; set; }
        [Required]
        [EmailAddress]
        public string? BookingEmail { get; set; }
        public Room? RoomNav { get; set; }
        public RoomService? RoomServiceNav { get; set; }

    }
}
