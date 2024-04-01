using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoProject.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string AccessRights { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public ProjectModel Project { get; set; }
    }
}
