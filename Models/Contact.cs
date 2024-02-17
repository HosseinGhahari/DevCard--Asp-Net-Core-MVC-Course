using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace DevCard___MVC.Models
{
	public class Contact
	{
		// here we have all properties for contact form
		// with all the validation requirement

		// SelectList Accept a list of drop-down list
		// we use it for saving the services items 

		[Required(ErrorMessage = "این فیلد اجباری است")]
        public string Name { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress]
        public string Email { get; set; }
        public string Service { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]
        public string Message { get; set; }
        public SelectList ServiceItems { get; set; }

    }
}
