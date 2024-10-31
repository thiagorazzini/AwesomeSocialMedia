using AwesomeSocialMedia.Users.Application.Commands.UpdateUser.Models;
using AwesomeSocialMedia.Users.Application.Models;
using AwesomeSocialMedia.Users.Core.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSocialMedia.Users.Application.Commands.UpdateUser
{
    public class UpdateUserCommand : IRequest<BaseResult>
    {
        public Guid Id { get; set; }
        public string DisplayName { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public LocationInfoModel Location { get; set; }
        public ContactInfoModel Contact { get; set; }
    }
}
