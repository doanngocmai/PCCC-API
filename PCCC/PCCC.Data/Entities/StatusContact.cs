﻿using System;
using System.Collections.Generic;

namespace PCCC.Data.Entities;

public partial class StatusContact
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public string ReferralCode { get; set; } = null!;

    public string Gmail { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public int Status { get; set; }

    public string Content { get; set; } = null!;

    public DateOnly CreationTime { get; set; }

    public string? Title { get; set; }
}
