using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HBLC_Bookings.Models
{
    public class RoomType
    {
        [Key]
        public int RoomTypeId { get; set; }
        [Required]
        [StringLength(200)]
        public string? RoomTypeName { get; set; }
        public int RoomTypeNumber { get; set; }
        [StringLength(300)]
        public string? RoomTypeImage { get; set; }
        [Column(TypeName ="decimal(8,2)")]
        public decimal FeePerNight { get; set; }

    }
}
