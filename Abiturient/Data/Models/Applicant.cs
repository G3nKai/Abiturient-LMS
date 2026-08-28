using Applicant.Data.Models.Enum;
using HawkN.Iso.Countries;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Abiturient.Data.Models
{
    public class Applicant
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public CountryCode.TwoLetterCode Citizenship { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
    }
}
