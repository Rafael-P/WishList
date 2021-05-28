using Microsoft.AspNetCore.Mvc;
using System;
using WishList.WebApi.Domains;
using WishList.WebApi.Interfaces.Controllers.Base;
using WishList.WebApi.Interfaces.Repositories.Base;
using WishList.WebApi.Repositories;

namespace WishList.WebApi.Controllers {
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase, IStandardController<Usuario> {
        IStandardRepository<Usuario> _userRepository { get; set; }

        public UsuarioController() {
            _userRepository = new UsuarioRepository();
        }

        /// <summary>
        /// Deleta um usuário.
        /// </summary>
        /// <param name="id">O id do usuário que será deletado.</param>
        /// <returns>Retorna StatusCode 204(No Content).</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            try {
                _userRepository.Delete(id);

                return StatusCode(204);
            }
            catch(Exception error) {
                return BadRequest(error);
            }
        }

        /// <summary>
        /// Lista todos os usuários.
        /// </summary>
        /// <returns>Retorna um objeto JSON, com a lista de usuários.</returns>
        [HttpGet]
        public IActionResult Get() {
            try {
                return Ok(_userRepository.ListAll());
            }
            catch(Exception error) {
                return BadRequest(error);
            }
        }

        /// <summary>
        /// Busca apenas um usuário.
        /// </summary>
        /// <param name="id">O id do usuário que será buscado.</param>
        /// <returns>Retorna um objeto JSON, do usuário buscado.</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            try {
                return Ok(_userRepository.SearchById(id));
            }
            catch(Exception error) {
                return BadRequest(error);
            }
        }

        /// <summary>
        /// Cadastra um novo usuário.
        /// </summary>
        /// <param name="newEntity">Objeto que será cadastrado.</param>
        /// <returns>Retorna um StatusCode 201(Created).</returns>
        [HttpPost]
        public IActionResult Post(Usuario newEntity) {
            try {
                _userRepository.Register(newEntity);

                return StatusCode(201);
            }
            catch(Exception error) {
                return BadRequest(error);
            }
        }

        /// <summary>
        /// Atualiza um usuário.
        /// </summary>
        /// <param name="id">O id do usuário escolhido a ser atualizado.</param>
        /// <param name="newEntity">Objeto com as novas informações.</param>
        /// <returns>Retorna um StatusCode 204(No Content).</returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, Usuario newEntity) {
            try {
                _userRepository.Update(id, newEntity);

                return StatusCode(204);
            }
            catch(Exception error) {
                return BadRequest(error);
            }
        }
    }
}
