using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TodoApp.Models
{
    public class Todoo
    {
        [DisplayName("Todo Id")] // annotaction to customize the view filed names
        public int TodoId { get; set; }
        [Required(ErrorMessage = "Todo Titile is required")]
        [MinLength(2)] // where title should be minimum of 2 characters
        public string Title { get; set; }
        [Required]
        public string? Description { get; set; }
        public bool Status { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DueDate { get; set; }
        public List<User> Users { get; set; }
    }
}
