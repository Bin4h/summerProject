using Microsoft.AspNetCore.Identity;

namespace Application.Services;

public class PasswordService
{
    private readonly PasswordHasher<object> _passwordHasher;

    public PasswordService()
    {
        _passwordHasher = new PasswordHasher<object>();
    }

    public string HashPassword(string password)
    {
        var hashedPassword = _passwordHasher.HashPassword(null, password);
        return hashedPassword;
    }

    public bool VerifyPassword(string hashedPassword, string providedPassword)
    {
        var verificationResult = _passwordHasher.VerifyHashedPassword(null, hashedPassword, providedPassword);
        return verificationResult == PasswordVerificationResult.Success;
    }
}
