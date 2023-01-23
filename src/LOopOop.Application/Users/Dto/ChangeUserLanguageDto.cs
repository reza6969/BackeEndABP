using System.ComponentModel.DataAnnotations;

namespace LOopOop.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}