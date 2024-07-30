using PawTrack.Communication.Enums;

namespace PawTrack.Communication.Responses
{
    public  class ResponseShortPetJson
    {
        public int id { get; set; }

        public string name { get; set; }

        public PetType type { get; set; }
    }
}
