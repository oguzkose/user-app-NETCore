using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserApp.Models
{
    public class UserViewModel : IValidatableObject
    {
        [Range(0, int.MaxValue, ErrorMessage = "0 dan büyük bir değer giriniz")]
        [Display(Name = "Sıra No")]
        [Required(ErrorMessage = "Bu alan doldurulmalıdır")]

        public int Id { get; set; }


        [Display(Name = "Adı")]
        [Required(ErrorMessage = "Bu alan doldurulmalıdır")]
        [StringLength(25)]
        public string Name { get; set; }


        [Display(Name = "Soyadı")]
        [Required(ErrorMessage = "Bu alan doldurulmalıdır")]
        [StringLength(25)]
        public string Surname { get; set; }


        [Display(Name = "GitHub Hesabı")]
        [Required(ErrorMessage = "Bu alan doldurulmalıdır")]
        [Url(ErrorMessage = "Url formatı şu şekilde olmalıdır: https://github.com/test")]
        public string GitHubAccountUrl { get; set; }


        [Display(Name = "Email")]
        [Required(ErrorMessage = "Bu alan doldurulmalıdır")]
        [EmailAddress(ErrorMessage = "Bu alan doldurulmalıdır")]
        public string Email { get; set; }


        [Display(Name = "Cinsiyet")]
        //[Required(ErrorMessage = "Bu alan doldurulmalıdır")]
        public string Gender { get; set; }

        [Display(Name = "Doğum Tarihi")]
        public DateTime BirthDate { get; set; }

        public IEnumerable<SelectListItem> GenderSelectList { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            #region DropdownList'ten cinsiyet seçme validation'u
            if (Gender != "Female" & Gender != "Male")
            {
                yield return new ValidationResult("Cinsiyet seçiniz", new[] { nameof(Gender) });
            }
            #endregion

            #region 18 yaşından küçüklerin kaydedilememesi 
            if (BirthDate > DateTime.Now.AddYears(-18))
            {
                yield return new ValidationResult("18 yaşından küçük kullanıcılar eklenemez", new[] { nameof(BirthDate) });
            }
            #endregion

        }
    }
}
