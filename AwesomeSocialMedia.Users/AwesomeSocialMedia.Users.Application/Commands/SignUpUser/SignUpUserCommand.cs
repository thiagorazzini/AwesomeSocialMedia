using AwesomeSocialMedia.Users.Application.Models;
using AwesomeSocialMedia.Users.Core.Entities;
using MediatR;

namespace AwesomeSocialMedia.Users.Application.Commands.SignUpUser
{
    public class SignUpUserCommand : IRequest<BaseResult<Guid>>
    {
        public string FullName { get; private set; }
        public string DisplayName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Email { get; private set; }

        public User ToEntity() => new User(FullName, DisplayName, BirthDate, Email);
    }
}
