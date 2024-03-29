﻿using Microsoft.AspNetCore.Identity;

namespace SHCApiGateway.ViewModel.UserClim
{
    public class UserClimDto
    {
        public static IdentityUserClaim<string> Map(
            UserClimViewModel viewModel)
        {
            if (viewModel == null)
            {
                return
                    new IdentityUserClaim<string>();
            }

            return new IdentityUserClaim<string>()
            {
                Id = viewModel.Id,
                UserId = viewModel.UserId,
                ClaimType = viewModel.ClaimType,
                ClaimValue = viewModel.ClaimValue,
            };
        }

        public static UserClimViewModel Map(
            IdentityUserClaim<string> dataEntity)
        {
            if (dataEntity == null) { return new UserClimViewModel(); }

            return new UserClimViewModel()
            {
                Id = dataEntity.Id,
                UserId = dataEntity.UserId,
                ClaimType = dataEntity.ClaimType,
                ClaimValue = dataEntity.ClaimValue,
            };
        }

        public static IEnumerable<UserClimViewModel> Map(IEnumerable<IdentityUserClaim<string>> dataEntityList)
        {
            if (dataEntityList == null) { yield break; }

            foreach (var item in dataEntityList)
            {
                yield return Map(item);
            }
        }
    }
}
