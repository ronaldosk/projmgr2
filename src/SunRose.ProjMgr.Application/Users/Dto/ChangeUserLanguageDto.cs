using System.ComponentModel.DataAnnotations;

namespace SunRose.ProjMgr.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}