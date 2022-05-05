using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Ticket
    {     
        [Key]
        public int TicketId { get; set; }
        [Required]
        public string Name { get; set;}
        [Required]
        public string CardNUmber { get; set;}

         
    }
}
