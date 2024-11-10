﻿using System;
using System.Collections.Generic;

namespace dal. Models;

public partial class TypesTrip
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}
