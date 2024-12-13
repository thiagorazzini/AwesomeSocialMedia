using AwesomeSocialMedia.Users.Core.ValueObjects;
using System.Diagnostics.Metrics;

namespace AwesomeSocialMedia.Users.Application.Commands.UpdateUser.Models
{
    public class ContactInfoModel
    {
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string PhoneNumber { get; set; }

        public ContactInfo ToValueObject() => new ContactInfo(Email, WebSite, PhoneNumber);

    }
}