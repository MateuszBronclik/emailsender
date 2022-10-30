using System.ComponentModel.DataAnnotations;

namespace emailsender.Models
{
    public class MailModel
    {
        [Required]
        public string From { get; set; }

        [Required]
        public string To { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "The Subject value cannot exceed 256 characters. ")]
        public string Subject { get; set; }
        
        public string Body { get; set; }
       
    }
}
