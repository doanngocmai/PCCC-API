﻿namespace PCCC.Common.DTOs.User
{
    public class UserModel
    {
        public long Id { get; set; }

        public string[] UserName { get; set; } = null!;

        public string? FullName { get; set; }

        public string[] Phone { get; set; } = null!;

        public string[]? Gmail { get; set; }

        public bool Sex { get; set; }

        public string? Address { get; set; }

        public string Password { get; set; } = null!;

        public int IsActive { get; set; }

        public int Level { get; set; }

        public DateOnly CreationTime { get; set; }

        public bool IsDelete { get; set; }

        public float Amount { get; set; }

        public string CreatorUserName { get; set; } = null!;

        public long? UpgradeAccId { get; set; }

        public long? BuildingId { get; set; }

        public long? ApartmentUserId { get; set; }
    }
}
