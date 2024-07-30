using PawTrack.Communication.Enums;

namespace PawTrack.Communication.Responses
{
    public class ResponsePetJson
    {

        public int id { get; set; }
        public string name { get; set; } = string.Empty;

        public DateTime birthDay { get; set; }

        public PetType type { get; set; }
    }
}
