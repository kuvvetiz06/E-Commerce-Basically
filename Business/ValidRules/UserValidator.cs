using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidRules
{
  public  class UserValidator: AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı Ad Boş Geçilemez!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Boş Geçilemez !");
            RuleFor(x => x.Username).MinimumLength(2).WithMessage("Kullanıcı Ad Alanı En Az 2 Karakter Olmalıdır !");
            RuleFor(x => x.Username).MaximumLength(20).WithMessage("Kullanıcı Ad Alanı En Fazla 20 Karakter Olabilir !");
        }
    }
}
