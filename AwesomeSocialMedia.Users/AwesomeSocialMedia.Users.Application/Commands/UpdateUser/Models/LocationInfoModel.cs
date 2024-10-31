using AwesomeSocialMedia.Users.Core.ValueObjects;

namespace AwesomeSocialMedia.Users.Application.Commands.UpdateUser.Models
{
    public class LocationInfoModel
    {
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }

        public LocationInfo ToValueObject() => new LocationInfo(City, State, Country);
    }
}