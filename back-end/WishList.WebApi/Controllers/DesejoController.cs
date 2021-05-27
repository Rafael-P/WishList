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
    public class DesejoController : ControllerBase, IStandardController<Desejo> {
        IStandardRepository<Desejo> _desireRepository { get; set; }

        public DesejoController() {
            _desireRepository = new DesejoRepository();
        }

        /// <summary>
        /// Deleta um desejo.
        /// </summary>
        /// <param name="id">O id do desejo que será deletado.</param>
        /// <returns>Retorna StatusCode 204(No Content).</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            try {
                _desireRepository.Delete(id);

                return StatusCode(204);
            }
            catch(Exception error) {
                return BadRequest(error);
            }
        }

        /// <summary>
        /// Lista todos os desejos.
        /// </summary>
        /// <returns>Retorna um objeto JSON, com a lista de desejos.</returns>
        [HttpGet]
        public IActionResult Get() {
            try {
                return Ok(_desireRepository.ListAll());
            }
            catch(Exception error) {
                return BadRequest(error);
            }
        }


        /// <summary>
        /// Busca apenas um desejo.
        /// </summary>
        /// <param name="id">O id do desejo que será buscado.</param>
        /// <returns>Retorna um objeto JSON, do desejo buscado.</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            try {
                return Ok(_desireRepository.SearchById(id));
            }
            catch(Exception error) {
                return BadRequest(error);
            }
        }

        /// <summary>
        /// Cadastra um novo desejo.
        /// </summary>
        /// <param name="newEntity">Objeto que será cadastrado.</param>
        /// <returns>Retorna um StatusCode 201(Created).</returns>
        [HttpPost]
        public IActionResult Post(Desejo newEntity) {
            try {
                _desireRepository.Register(newEntity);

                return StatusCode(201);
            }
            catch(Exception error) {
                return BadRequest(error);
            }
        }

        /// <summary>
        /// Atualiza um desejo.
        /// </summary>
        /// <param name="id">O id do desejo escolhido a ser atualizado.</param>
        /// <param name="newEntity">Objeto com as novas informações.</param>
        /// <returns>Retorna um StatusCode 204(No Content).</returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, Desejo newEntity) {
            try {
                _desireRepository.Update(id, newEntity);

                return StatusCode(204);
            }
            catch(Exception error) {
                return BadRequest(error);
            }
        }
    }
}
