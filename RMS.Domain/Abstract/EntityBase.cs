﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.Abstract;

public abstract class EntityBase
{
    public int Id { get; set; } = new int();
}
