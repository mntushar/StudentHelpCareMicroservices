﻿namespace SHCApiGateway.ViewModel.UserRoleClaim
{
    public class UserRoleClaimViewModel
    {
        public int Id { get; set; }
        public string RoleId { get; set; } = string.Empty;
        public string? ClaimType { get; set; }
        public string? ClaimValue { get; set; }
    }
}
