using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoProject.Models
{
    public class AreaModel
    {
        [Key]
        public int AreaId { get; set; }

        [StringLength(50)]
        public string AreaType { get; set; }

        [StringLength(100)]
        public string Coordinates { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public ProjectModel Project { get; set; }

        public ICollection<ProfileModel> Profiles { get; set; }
    }
}
