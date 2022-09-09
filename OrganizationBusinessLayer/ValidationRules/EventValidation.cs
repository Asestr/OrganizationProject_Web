using FluentValidation;
using OrganizationEntityLayer.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationBusinessLayer.ValidationRules
{
    public class EventValidation:AbstractValidator<Event>
    {
        public EventValidation()
        {
            RuleFor(x => x.EventName).NotEmpty().WithMessage("Etkinlik başlığı boş geçemezssiniz.");
            //RuleFor(x => x.EventStartTime).NotEmpty().WithMessage("Etkinliğin başvuru tarihini boş geçemezssiniz.");
            RuleFor(x => x.EventRecourseOverTime).NotEmpty().WithMessage("Etkinliğin Başlangıç tarihini boş geçemezssiniz.");
            RuleFor(x => x.EventExplanation).NotEmpty().WithMessage("Etkinliğinizin açıklamasını yapınız");
            RuleFor(x => x.EventAddress).NotEmpty().WithMessage("Adres bilgilerini giriniz.");
            RuleFor(x => x.EventQuota).NotEmpty().WithMessage("Kontenjan sayınızı giriniz.");
            RuleFor(x => x.EventName).MaximumLength(100).WithMessage("Lütfen 100 karekterden daha az veri girişi yapın");
            RuleFor(x => x.EventName).MinimumLength(5).WithMessage("Lütfen 5 karekterden daha fazla veri girişi yapın");  
           


        }
    }
}
