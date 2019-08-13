using System.ComponentModel.DataAnnotations;

namespace MyCompany.WXProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}