using System.Security.Cryptography;
using System.Text;

namespace API;

public class HelperClass : IHelperClass
{
   public bool ComaprePassword(string sendingPassword, byte[] passwordSalt, byte[] passwordHash)
   {
      using var hmac = new HMACSHA512(passwordSalt);
      var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(sendingPassword));
      for (int i = 0; i < computedHash.Length; i++)
      {
         if (computedHash[i] != passwordHash[i])
         {
            return false;
         }
      }
      return true;
   }


}
