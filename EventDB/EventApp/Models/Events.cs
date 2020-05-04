using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace EventApplication.Models
{
    public class Events
    {
        [Key]
        public int EventsId { get; set; }

        [Required(ErrorMessage = "Title is requied")]
        [StringLength(50, ErrorMessage = "Title cannot be more than 50 characters")]
        public string EventTitle { get; set; }

        [StringLength(150, ErrorMessage = "Description should not exceed 150 characters")]
        public string EventDescription { get; set; }

        [Required]
        public string EventStartTime { get; set; }

        [Required(ErrorMessage = "Start Date cannot be in the past")]
     
        public string EventStartDate { get; set; }

        
        [Required]
        public string EventEndTime { get; set; }

        [Required(ErrorMessage = "End date cannot be less than Start date")]
        
        public string EventEndDate { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public string EventType { get; set; }

        [Required]
        public string OrganizerName { get; set; }
        public string OrganizerContactInfo { get; set; }
        [Required(ErrorMessage = " Max tickets cannot be 0")]

        public int MaxTickets { get; set; }

        [Required(ErrorMessage = "Avaliable tickets cannot be 0")]
        public int AvaliableTickets { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}

    