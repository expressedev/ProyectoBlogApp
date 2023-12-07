using System;
using BlogLab.Models.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace BlogLab.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IConfiguration _config;

        public AccountRepository(IConfiguration config)
        {
            _config = config;
        }

        public Task<IdentityResult> CreateAsync(ApplicationUserIdentity user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUserIdentity> GetByUsernameAsync(string normalizedUsername, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

