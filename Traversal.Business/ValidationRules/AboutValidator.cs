using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Entity.Concrete;

namespace Traversal.Business.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(r => r.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz...");
            RuleFor(r => r.Image1).NotEmpty().WithMessage("Lütfen görsel seçiniz...");
            RuleFor(r => r.Description).MinimumLength(50).WithMessage("Lütfen en az 50 karakterlik açıklama bilgisi giriniz...");
            RuleFor(r => r.Description).MaximumLength(1000).WithMessage("Lütfen açıklamayı kısaltın max 1000 karakter !!!");
        }
    }
}
