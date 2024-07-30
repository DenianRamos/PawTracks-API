using Microsoft.AspNetCore.Mvc;
using PawTrack.Application.UseCases.Pet.Register;
using PawTrack.Application.UseCases.Pet.Update;
using PawTrack.Application.UseCases.Pets.GetAll;
using PawTrack.Application.UseCases.Pets.GetById;
using PawTrack.Communication.Requests;
using PawTrack.Communication.Responses;
using System.Linq;

namespace PawTrack.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseCreatePetJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        public IActionResult CreatePet([FromBody] RequestPetJson request)
        {

            var response = new RegisterPetUseCase().Execute(request);
            return Created(string.Empty, response);
        }


        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseCreatePetJson), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        public IActionResult UpdatePet([FromBody] RequestPetJson request, [FromRoute] int id)
        {
           var UseCase = new UpdatePetUseCase();

            UseCase.Execute(request, id);
            return NoContent();
        }


        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllPetJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseCreatePetJson), StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var useCase = new GetAllPetsUseCase();

            var response = useCase.Execute();
            if (response.Pets.Any())
            {
                return Ok(response);
            } 
            return NoContent();

            
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponsePetJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseCreatePetJson), StatusCodes.Status404NotFound)]
        public IActionResult GetPetById([FromRoute] int id)
        {

            var useCase = new GetPetByIdUseCase();
            var response = useCase.Execute(id);
            return Ok(response);
        }

        [HttpDelete]
        [Route("{id}")]

        [ProducesResponseType( StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseCreatePetJson), StatusCodes.Status404NotFound)]
        public IActionResult Delete (int id)
        {
            return NoContent();
        }
    }
}
