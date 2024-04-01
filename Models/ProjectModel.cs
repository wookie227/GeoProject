using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoProject.Models
{
    public class ProjectModel
    {
        [Key]
        public int ProjectId { get; set; }

        [StringLength(100)]
        public string ProjectName { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public ICollection<AreaModel> Areas { get; set; }
        public ICollection<UserModel> Users { get; set; }
    }
}
