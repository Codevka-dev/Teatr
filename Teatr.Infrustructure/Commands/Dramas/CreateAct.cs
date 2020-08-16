using System;
using System.Collections.Generic;
using System.Text;

namespace Teatr.Infrastructure.Commands.Dramas
{
    public class CreateAct
    {
        public string ActStageDirections { get; protected set; }
        public string ActDescription { get; protected set; }
        public int ActNumber { get; protected set; }
        public string ActTitle { get; protected set; }
    }
}
