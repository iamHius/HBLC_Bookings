using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HBLC_Bookings.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        [Required]
        [StringLength(200)]
        public string? RoomName { get; set; }
        [ForeignKey("RoomType")]
        public int RoomTypeId { get; set; }
        [ForeignKey("RoomStatus")]
        public int RoomStatusId { get; set; }
        public RoomType? RoomTypeNav { get; set; }
        public RoomStatus? RoomStatusNav { get; set; }
    }
}
