using BlazorDataFormLocalization.Client.Resources;
using System.ComponentModel.DataAnnotations;

namespace BlazorDataFormLocalization.Data
{
    public class UserDetails
    {
        [Display(ResourceType = typeof(SfResources), Name = "DataForm_FirstName")]
        [Required(ErrorMessageResourceName = "DataForm_FirstName_Error", ErrorMessageResourceType = typeof(SfResources))]
        public string FirstName { get; set; }

        [Display(ResourceType = typeof(SfResources), Name = "DataForm_LastName")]
        [Required(ErrorMessageResourceName = "DataForm_LastName_Error", ErrorMessageResourceType = typeof(SfResources))]
        public string LastName { get; set; }

        [Display(ResourceType = typeof(SfResources), Name = "DataForm_Email")]
        [Required(ErrorMessageResourceName = "DataForm_Email_Error", ErrorMessageResourceType = typeof(SfResources))]
        [EmailAddress(ErrorMessageResourceName = "DataForm_Valid_Email_Error", ErrorMessageResourceType = typeof(SfResources))]
        public string Email { get; set; }

        [Display(ResourceType = typeof(SfResources), Name = "DataForm_Password")]
        [MinLength(8, ErrorMessageResourceName = "DataForm_Password_Length_Error", ErrorMessageResourceType = typeof(SfResources))]
        [Required(ErrorMessageResourceName = "DataForm_Password_Error", ErrorMessageResourceType = typeof(SfResources))]
        public string Password { get; set; }

        [Display(ResourceType = typeof(SfResources), Name = "DaaForm_DateOfBirth")]
        [Required(ErrorMessageResourceName = "DataForm_DateOfBirth_Error", ErrorMessageResourceType = typeof(SfResources))]
        public DateTime? DateOfBirth { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessageResourceName = "DataForm_AcceptTerms_Error", ErrorMessageResourceType = typeof(SfResources))]
        [Display(ResourceType = typeof(SfResources), Name = "DataForm_AcceptTerms")]
        public bool AcceptTerms { get; set; }

        public UserDetails()
        {
        }
    }
}
