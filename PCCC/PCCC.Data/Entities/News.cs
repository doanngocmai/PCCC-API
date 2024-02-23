﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace PCCC.Data.Entities;

public partial class News
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int Type { get; set; }

    public string Content { get; set; } = null!;

    public DateOnly CreationTime { get; set; }

    public string? Image { get; set; }

    public BitArray IsActive { get; set; } = null!;
}
