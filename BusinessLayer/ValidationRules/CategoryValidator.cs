using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçilmez!");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori Adı en az 3 karakter olmalıdır!");
            RuleFor(x => x.CategoryName).MaximumLength(100).WithMessage("Kategori Adı en fazla 100 karakter olmalıdır!");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori Açıklması Boş Geçilmez!");
            RuleFor(x => x.CategoryDescription).MinimumLength(3).WithMessage("Kategori Açıklaması en az 3 karakter olmalıdır!");
            RuleFor(x => x.CategoryDescription).MaximumLength(100).WithMessage("Kategori Açıklaması en fazla 100 karakter olmalıdır!");
        }
    }
}
