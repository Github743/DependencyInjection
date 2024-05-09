using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DependencyApi.Models.Database
{
    [Table("Country")]
    public partial class Country
    {
        public int CountryId { get; set; }

        [StringLength(100)]
        public string CountryName { get; set; }

        public int? OrderBy { get; set; }

        public bool? IsSuppressed { get; set; }
    }
}