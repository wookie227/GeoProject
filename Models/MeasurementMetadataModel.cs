using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GeoProject.Models
{
    public class MeasurementMetadataModel
    {
        [Key]
        public int MeasurementMetadataId { get; set; }

        public DateTime DateTime { get; set; }

        [StringLength(100)]
        public string EquipmentParameters { get; set; }

        [StringLength(100)]
        public string MeasurementConditions { get; set; }

        [ForeignKey("Profile")]
        public int ProfileId { get; set; }
        public ProfileModel Profile { get; set; }
    }
}
