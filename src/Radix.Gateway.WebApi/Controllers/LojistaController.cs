using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Radix.Gateway.Client.ViewModel;
using Radix.Gateway.Domain;
using Radix.Gateway.Domain.Repository;
using Radix.Gateway.Domain.Service;
using Radix.Gateway.Domain.Validations;
using Radix.Gateway.Resource;
using Radix.Gateway.WebApi.Utility;
using System.Collections.Generic;
using System.Linq;

namespace Radix.Gateway.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Lojista")]
    public class LojistaController : Controller
    {
        private readonly IUserRepository userRepository;
        public List<NotificationMessage> Messages { get; set; }

        public LojistaController(IUserRepository userRepository)
        {
            Guardian.AgainstNull(userRepository);
            this.userRepository = userRepository;
            Messages = new List<NotificationMessage>();
        }

        // GET: api/Lojista
        /// <summary>
        /// Recuperar usuário pelo email
        /// </summary>
        /// <param name="email"></param>
        [HttpGet("{email}")]
        public IActionResult Get(string email)
        {
            var user = userRepository.FindByEmail(email);

            if (user != null)
            {
                return Ok(new
                {
                    success = true,
                    data = user
                });
            }

            return NotFound(new
            {
                success = true,
                data = UserResource.UserNotFound
            });
        }

        // POST: api/Lojista
        /// <summary>
        /// Criar um usuário
        /// </summary>
        /// <param name="User"></param>
        [HttpPost]
        public IActionResult Create([FromBody]UserViewModel userViewModel)
        {
            Guardian.AgainstNull(userViewModel);
            if (ModelState.IsValid)
            {
                var user = Mapper.Map<UserViewModel, User>(userViewModel);
                var userValidation = new RegisterNewUserValidation(userRepository);
                userValidation.Validate(user);
                Messages.AddRange(userValidation.Messages);

                if (!Messages.HasErrors())
                {
                    userRepository.Insert(user);
                    return Ok(new
                    {
                        success = true,
                        data = string.Format(UserResource.UserRegisteredSuccessfully, user.Name)
                    });
                }
            }

            Messages.AddRange(ModelState.GetCustomErrors().Select(s => new
            NotificationMessage(s, Domain.EnumTypes.NotificationType.Error)));

            return BadRequest(new
            {
                success = true,
                errors = Messages
            });
        }

        /// <summary>
        /// Atualizar dados do usuário
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public IActionResult Update([FromBody]UserViewModel user)
        {
            Guardian.AgainstNull(user);
            if (ModelState.IsValid)
            {
                userRepository.Update(Mapper.Map<UserViewModel, User>(user), user.Id.ToString());
                return Ok(new
                {
                    success = true,
                    data = string.Format(UserResource.UserUpdatedSuccessfully, user.Name)
                });
            }
            else
            {
                return BadRequest(new
                {
                    success = true,
                    errors = ModelState.GetCustomErrors()
                });
            }
        }

        /// <summary>
        /// Deletar um usuário pelo id
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public IActionResult Delete(string id)
        {
            var deleteResult = userRepository.Delete(id);

            if (deleteResult > 0)
            {
                return Ok(new
                {
                    success = true,
                    data = UserResource.UserDeletedSuccessfully
                });
            }
            else
            {
                return BadRequest(new
                {
                    success = true,
                    errors = UserResource.NoUserFoundDeleted
                });
            }
        }
    }
}