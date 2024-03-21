﻿using System;
using System.Collections.Generic;

namespace rest.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Category { get; set; }

    public decimal Price { get; set; }
}
