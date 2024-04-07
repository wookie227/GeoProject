using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GeoProject.Models
{
    public class GeologicalInformationModel
    {
        [Key]
        public int GeologicalInformationId { get; set; }

        [StringLength(50)]
        public string RockType { get; set; }

        [StringLength(100)]
        public string Composition { get; set; }

        public double Porosity { get; set; }

        public bool CracksPresent { get; set; }

        [ForeignKey("Profile")]
        public int ProfileId { get; set; }
        public ProfileModel Profile { get; set; }
    }
}
