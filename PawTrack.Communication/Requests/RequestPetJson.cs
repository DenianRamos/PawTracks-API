using PawTrack.Communication.Enums;

namespace PawTrack.Communication.Requests
{
    public class RequestPetJson
    {
        public string name { get; set; } = string.Empty;

        public DateTime birthDay { get; set; }

        public PetType type { get; set; }
    }
}
