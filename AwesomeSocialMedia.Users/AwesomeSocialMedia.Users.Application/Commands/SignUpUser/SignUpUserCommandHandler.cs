using AwesomeSocialMedia.Users.Application.Models;
using AwesomeSocialMedia.Users.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSocialMedia.Users.Application.Commands.SignUpUser
{
    public class SignUpUserCommandHandler : IRequestHandler<SignUpUserCommand, BaseResult<Guid>>
    {
        private readonly IUserRepository _repository;

        public SignUpUserCommandHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<BaseResult<Guid>> Handle(SignUpUserCommand request, CancellationToken cancellationToken)
        {
            var user = request.ToEntity();

            await _repository.AddAsync(user);

            return new BaseResult<Guid>(user.Id, message: "Perfil cadastrado com sucesso!");
        }
    }
}
