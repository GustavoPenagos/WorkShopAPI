using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace WorkShopAPI.Domain.Utils
{
    public static class Util
    {
        private static readonly byte[] Key = Encoding.ASCII.GetBytes("KEY".GetFromApp<string>());
        private static readonly byte[] IV = Encoding.UTF8.GetBytes("IV".GetFromApp<string>());
        //private static  IConfiguration _config = new ConfigurationBuilder()
        //    .SetBasePath(Directory.GetCurrentDirectory())
        //    .AddJsonFile("appsettings.json")
        //    .Build();

        public static string Decrypt(this string input)
        {
            #region 16 bytes
            //byte[] randomBytes = new byte[16];
            //using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            //{
            //    rng.GetBytes(randomBytes);
            //}
            //string base64String = Convert.ToBase64String(randomBytes);
            //string result = base64String.Substring(0, Math.Min(22, base64String.Length));
            #endregion
            byte[] resultado;
            ICryptoTransform decryptor;
            try
            {
                using Aes aes = Aes.Create();
                aes.Key = Key;
                aes.IV = IV;
                decryptor = aes.CreateDecryptor();
                byte[] datos = Convert.FromBase64String(input);

                resultado = decryptor.TransformFinalBlock(datos, 0, datos.Length);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Encoding.UTF8.GetString(resultado);
        }

        public static string Encrypt(this string texto)
        {
            byte[] resultado;
            try
            {
                using Aes aes = Aes.Create();
                aes.Key = Key;
                aes.IV = IV;
                ICryptoTransform encryptor = aes.CreateEncryptor();
                byte[] datos = Encoding.UTF8.GetBytes(texto);
                resultado = encryptor.TransformFinalBlock(datos, 0, datos.Length);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Convert.ToBase64String(resultado);
        }

        public static bool IsValid(this string encode)
            => !string.IsNullOrEmpty(encode) && encode.Decrypt() != null;
            
        
         

        public static string GeneratePassword(this string input)
        {
            byte[] inputBytes = Encoding.Default.GetBytes(input.Trim());
            byte[] hashBytes = MD5.HashData(inputBytes);

            return new Guid(hashBytes).ToString();
        }

        public static T GetFromApp<T>(this string key)
        {
            IConfiguration _config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            var value = _config.GetSection(key).Value;
            if (string.IsNullOrEmpty(value))
                value = "";

            return (T)Convert.ChangeType(value, typeof(T));

        }
        public static T ToAny<T>(this string? key)
        {
            if (string.IsNullOrEmpty(key))
                key = "0";
            return (T)Convert.ChangeType(key, typeof(T));
        }
        
    }
}
