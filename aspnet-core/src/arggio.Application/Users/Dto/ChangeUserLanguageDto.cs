using System.ComponentModel.DataAnnotations;

namespace arggio.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}