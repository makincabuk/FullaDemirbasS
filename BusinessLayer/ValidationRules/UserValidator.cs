using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class UserValidator: AbstractValidator<User>
    {
        public UserValidator()
        {//User Kuralları buraya
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı Boş Geçilmez!");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Kullanıcı Adı en az 3 karakter olmalıdır!");
            RuleFor(x => x.UserName).MaximumLength(100).WithMessage("Kategori Adı en fazla 100 karakter olmalıdır!");

            RuleFor(x => x.Uname).NotEmpty().WithMessage("Ad Boş Geçilmez!");
            RuleFor(x => x.Uname).MinimumLength(3).WithMessage("Ad en az 3 karakter olmalıdır!");
            RuleFor(x => x.Uname).MaximumLength(100).WithMessage("Ad en fazla 100 karakter olmalıdır!");

            RuleFor(x => x.USurName).NotEmpty().WithMessage("Soyad Boş Geçilmez!");
            RuleFor(x => x.USurName).MinimumLength(3).WithMessage("Soyad en az 3 karakter olmalıdır!");
            RuleFor(x => x.USurName).MaximumLength(100).WithMessage("Soyad en fazla 100 karakter olmalıdır!");

            RuleFor(x => x.UserPassword).NotEmpty().WithMessage("Şifre Boş Geçilmez!");
            RuleFor(x => x.UserPassword).MinimumLength(6).WithMessage("Şifre en az 6 karakter olmalıdır!");
            RuleFor(x => x.UserPassword).MaximumLength(100).WithMessage("soyad en fazla 100 karakter olmalıdır!");
        }
    }
}
