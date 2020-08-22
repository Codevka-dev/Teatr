﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Teatr.Infrastructure.Commands.Dramas
{
    public class CreateAct
    {
        public Guid DramaId { get; set; }
        public Guid ActId { get; set; }
        public string ActStageDirections { get; set; }
        public string ActDescription { get; set; }
        public int ActNumber { get; set; }
        public string ActTitle { get; set; }
    }
}