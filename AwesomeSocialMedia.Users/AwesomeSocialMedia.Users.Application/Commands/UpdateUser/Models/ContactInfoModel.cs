using AwesomeSocialMedia.Users.Core.ValueObjects;
using System.Diagnostics.Metrics;

namespace AwesomeSocialMedia.Users.Application.Commands.UpdateUser.Models
{
    public class ContactInfoModel
    {
        public string Email { get; private set; }
        public string WebSite { get; private set; }
        public string PhoneNumber { get; private set; }

        public ContactInfo ToValueObject() => new ContactInfo(Email, WebSite, PhoneNumber);

    }
}