using Microsoft.AspNetCore.Mvc;
using Radix.Gateway.Domain;
using Radix.Gateway.WebApi.Utility;

namespace Radix.Gateway.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Lojista")]
    public class LojistaController : Controller
    {
        private readonly IUserRepository userRepository;

        public LojistaController(IUserRepository userRepository)
        {
            Guardian.AgainstNull(userRepository);
            this.userRepository = userRepository;
        }

        // GET: api/Lojista
        /// <summary>
        /// Recuperar um item pelo código
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
                data = "Usuário não encontrado."
            });
        }

        // POST: api/Lojista
        /// <summary>
        /// Criar um usuário
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create([FromBody]User user)
        {
            Guardian.AgainstNull(user);
            return null;
        }
    }
}