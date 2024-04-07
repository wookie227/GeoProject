using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GeoProject.Models
{
    public class ElectrodeModel
    {
        [Key]
        public int ElectrodeCoordinateId { get; set; }

        [StringLength(50)]
        public string Coordinates { get; set; }

        [StringLength(50)]
        public string ElectrodeType { get; set; }
        public double Value { get; set; }
        public DateTime DateTime { get; set; }

        [ForeignKey("Profile")]
        public int ProfileId { get; set; }
        public ProfileModel Profile { get; set; }
    }
}
