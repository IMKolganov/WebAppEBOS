using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace WebAppEBOS.Service.Provider;

public class CustomTokenProvider<TUser> : DataProtectorTokenProvider<TUser> where TUser : class
{
    public CustomTokenProvider(IDataProtectionProvider dataProtectionProvider, IOptions<DataProtectionTokenProviderOptions> options, ILogger<DataProtectorTokenProvider<TUser>> logger) 
        : base(dataProtectionProvider, options, logger)
    {
    }

    public override Task<string> GenerateAsync(string purpose, UserManager<TUser> manager, TUser user)
    {
        // Implement your own logic for generating tokens here.
        // For example, you can generate a custom token based on user information, purpose, or any other criteria.

        string token = "your_custom_token_here";

        return Task.FromResult(token);
    }
}