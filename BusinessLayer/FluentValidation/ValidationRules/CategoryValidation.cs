using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.FluentValidation.ValidationRules
{
    public class CategoryValidation:AbstractValidator<Category>
    {
        public CategoryValidation()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz.");
            RuleFor(c => c.Description).NotEmpty().WithMessage("Kategori Açıklamasını Boş Geçemezsiniz.");
            RuleFor(c => c.Name).MinimumLength(3).WithMessage("Lütfen en az 3 karaktret girişi yapınız");
            RuleFor(c => c.Name).MaximumLength(50).WithMessage("Lütfen 20 karakterden fazla değer girişi yapmayınız.");
        }
    }
}
