using Crito.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Crito.Models
{
    public class NewsLetterForm
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        public string? RedirectUrl { get; set; } = "/";



        public static implicit operator NewsLetterEntity(NewsLetterForm newsLetterForm)
        {
            var newsLetterEntity = new NewsLetterEntity
            {
                Email = newsLetterForm.Email
            };
            return newsLetterEntity;

        }
    }
}
