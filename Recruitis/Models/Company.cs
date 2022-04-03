using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recruitis.Models
{
    public class Company
    {

        public int CompanyID { get; set; }

        public string CompanyName { get; set; }



        public ICollection<Client> Clients { get; set; }

    }
}