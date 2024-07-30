using PawTrack.Communication.Requests;
using PawTrack.Communication.Responses;

namespace PawTrack.Application.UseCases.Pet.Register
{
    public class RegisterPetUseCase
    {
        public ResponseCreatePetJson Execute(RequestPetJson request)
        {
            // Lógica para registrar o pet
            return new ResponseCreatePetJson
            {
                id = 1, 
                name = request.name,
               
            };
        }
    }
}