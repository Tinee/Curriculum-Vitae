using System;
using System.Security.Cryptography;

namespace Business_Logic.Account
{
    public static class PasswordHandler
    {
        public static string CreatePassword()
        {
            var rng = new RNGCryptoServiceProvider();
            var buff = new byte[7];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }
    }
}
