using PawTrack.Communication.Responses;

namespace PawTrack.Application.UseCases.Pets.GetById
{
    public class GetPetByIdUseCase
    {

        public ResponsePetJson Execute(int id)
        {
            // Lógica para buscar o pet pelo id
            return new ResponsePetJson
            {
                id = 1,
                name = "Rex",
                birthDay = new System.DateTime(year:2019,month: 01,day: 01),
                type = Communication.Enums.PetType.Dog
            };
        }
    }
}
