﻿using System;
using System.Collections.Generic;
using System.Text;
using Teatr.Core.Domain;

namespace Teatr.Infrastructure.DTO
{
    public class SentenceDto
    {
        public Guid SentenceId { get; set; }
        public Guid SceneId { get;  set; }
        public Guid CharacterId { get;  set; }
        public string Text { get; set; }
    }
}
