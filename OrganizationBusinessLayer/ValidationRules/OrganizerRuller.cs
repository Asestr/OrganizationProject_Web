

using FluentValidation;
using OrganizationEntityLayer.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OrganizationBusinessLayer.ValidationRules
{
    public class OrganizerRuller:AbstractValidator<Organizer>
    {
        public OrganizerRuller()
        {
            RuleFor(login => login.OrganizerName).NotEmpty().WithMessage("Adınızı Giriniz");
            RuleFor(login => login.OrganizerName).MinimumLength(2).WithMessage("Adınız 2 karekterden büyük olmalıdır");
           
            RuleFor(login => login.OrganizerPassword).NotEmpty().WithMessage("Parola giriniz");
            RuleFor(login => login.OrganizerPassword).Must(IsPasswordValid).WithMessage("Parola en az 8 karakter olmalıdır.En az bir harf ve bir sayı içermelidir");
            RuleFor(login => login.OrganizerPassword).Equal(login => login.OrganizerPasswordRepeat).WithMessage("Şifreler eşleşmiyor");
            RuleFor(login => login.OrganizerLastName).NotEmpty().WithMessage("Soyadı giriniz");
            RuleFor(login => login.OrganizerLastName).MinimumLength(2).WithMessage("Soyadı en az 2 karakter olmalıdır");
            RuleFor(login => login.OrganizerMail).NotEmpty().WithMessage("Mail adresini girer misin? Seni mi bekliyecem");
            RuleFor(login => login.OrganizerMail).EmailAddress().WithMessage("Mail adresinizi doğru düzgün giriniz");
            RuleFor(login => login.OrganizerMail).NotEqual(login => login.OrganizerPasswordRepeat/*Kaydı tutulan mail listesini kontrol et*/).WithMessage("Aynı maili girmezssin");


        }
        private bool IsPasswordValid(string arg)
        {
            try
            {
                Regex regex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
                return regex.IsMatch(arg);
            }
            catch
            {
                return false;
            }
        }
    }
}

