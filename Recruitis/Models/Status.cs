using System.ComponentModel.DataAnnotations.Schema;

namespace Recruitis.Models
{

    public class Status
    {
        
        public int StatusID { get; set; }
        public string StatusLabel { get; set; }


        public ICollection<Client> Clients { get; set; }
    }

}