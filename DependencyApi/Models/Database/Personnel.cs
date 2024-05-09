using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DependencyApi.Models.Database
{
    [Table("Personnel")]
    public partial class Personnel
    {
        public int PersonnelId { get; set; }

        [Required]
        [StringLength(100)]
        public string PersonnelName { get; set; }

        [StringLength(100)]
        public string PersonnelEmail { get; set; }

        [StringLength(100)]
        public string MobileNo { get; set; }

        public int? PersonnelRoleId { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        public bool IsActive { get; set; }

        public int? OrderBy { get; set; }

        public int? CreatedByPersonnelId { get; set; }

        public DateTime? CreatedDt { get; set; }

        public int? UpdatedByPersonnelId { get; set; }

        public DateTime? UpdatedDt { get; set; }
    }
}