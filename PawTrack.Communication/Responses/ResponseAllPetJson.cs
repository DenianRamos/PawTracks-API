﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawTrack.Communication.Responses
{
    public  class ResponseAllPetJson
    {

        public List<ResponseShortPetJson> Pets { get; set; } = [];
    }
}
