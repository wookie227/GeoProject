using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GeoProject.Models
{
    public class ProfileModel
    {
        [Key]
        public int ProfileId { get; set; }

        [StringLength(50)]
        public string Coordinates { get; set; }

        [ForeignKey("Area")]
        public int AreaId { get; set; }
        public AreaModel Area { get; set; }

        public ICollection<ElectrodeModel> Electrode { get; set; }
        public ICollection<GeologicalInformationModel> GeologicalInformation { get; set; }
        public ICollection<MeasurementMetadataModel> MeasurementMetadata { get; set; }
    }
}
