using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SubCategoryValidator : AbstractValidator<SubCategory>
    {
        public SubCategoryValidator()
        {
           // RuleFor(x => x.SubCategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçilmez!");
            //RuleFor(x => x.SubCategoryName).MinimumLength(3).WithMessage("Kategori Adı en az 3 karakter olmalıdır!");
            //RuleFor(x => x.SubCategoryName).MaximumLength(100).WithMessage("Kategori Adı en fazla 100 karakter olmalıdır!");

            //RuleFor(x => x.SubCategoryDescription).NotEmpty().WithMessage("Kategori Açıklması Boş Geçilmez!");
            //RuleFor(x => x.SubCategoryDescription).MinimumLength(3).WithMessage("Kategori Açıklaması en az 3 karakter olmalıdır!");
            //RuleFor(x => x.SubCategoryDescription).MaximumLength(100).WithMessage("Kategori Açıklaması en fazla 100 karakter olmalıdır!");

          //  RuleFor(x => x.SubCategoryName).NotEmpty().WithMessage("Lütfen Kategori Seçiniz");
        }
    }
}
