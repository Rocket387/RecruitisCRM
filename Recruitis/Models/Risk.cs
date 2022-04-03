using System.ComponentModel.DataAnnotations.Schema;

namespace Recruitis.Models
{
    public class Risk
    {


        
        public int RiskID { get; set; }
        public string RiskLabel { get; set; }


        public ICollection<Client> Clients { get; set; }

    }
}