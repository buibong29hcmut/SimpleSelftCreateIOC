﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSelftCreateIOC
{
    internal class RandomGuidGenerator
    {
        public Guid RandomGuid { get; set; }= Guid.NewGuid();
    }
}
