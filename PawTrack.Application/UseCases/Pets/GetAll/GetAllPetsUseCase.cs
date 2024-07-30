using PawTrack.Communication.Responses;

namespace PawTrack.Application.UseCases.Pets.GetAll
{
    public class GetAllPetsUseCase
    {
        public ResponseAllPetJson Execute()
        {
            return new ResponseAllPetJson
            {
                Pets = new List<ResponseShortPetJson>
                {
                    new ResponseShortPetJson
                    {
                        id = 1,
                        name = "Rex",
                        type = Communication.Enums.PetType.Dog
                    },
                }

            };

        }
    }
}
