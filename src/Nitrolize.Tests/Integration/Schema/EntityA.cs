﻿using System;
using System.Collections.Generic;

namespace Nitrolize.Tests.Integration.Schema
{
    public class EntityA
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<EntityB> Entities { get; set; }
    }
}
