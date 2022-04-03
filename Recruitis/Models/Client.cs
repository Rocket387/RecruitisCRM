using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recruitis.Models
{
    public class Client
    {
        public int ClientID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }   

        [Required]
        public string PhoneNumber { get; set; }

        public int CompanyID { get; set; }
        public int RiskID { get; set; }
        public int StatusID { get; set; }

        public Company Company { get; set; }
        public Risk Risk { get; set; }
        public Status Status { get; set; }
    }
}
