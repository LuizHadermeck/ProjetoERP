using System;
using System.Security.Cryptography;
using System.Text;

namespace AlasComercialERP.Autenticacao
{
    public static class SenhaService
    {
        private const int SaltTamanho = 16;

        public static void GerarHash(string senha, out string hash, out string salt)
        {
            if (senha == null)
                throw new ArgumentNullException(nameof(senha));

            byte[] saltBytes = new byte[SaltTamanho];

            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }

            byte[] hashBytes = CalcularHash(senha, saltBytes);

            hash = Convert.ToBase64String(hashBytes);
            salt = Convert.ToBase64String(saltBytes);
        }

        public static bool VerificarSenha(string senha, string hash, string salt)
        {
            if (string.IsNullOrEmpty(senha) || string.IsNullOrWhiteSpace(hash) || string.IsNullOrWhiteSpace(salt))
                return false;

            try
            {
                byte[] saltBytes = Convert.FromBase64String(salt);
                byte[] hashEsperado = Convert.FromBase64String(hash);
                byte[] hashInformado = CalcularHash(senha, saltBytes);

                return CompararTempoFixo(hashEsperado, hashInformado);
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool CompararTempoFixo(byte[] esquerda, byte[] direita)
        {
            if (esquerda == null || direita == null)
                return false;

            int diferenca = esquerda.Length ^ direita.Length;
            int tamanho = Math.Min(esquerda.Length, direita.Length);

            for (int i = 0; i < tamanho; i++)
                diferenca |= esquerda[i] ^ direita[i];

            return diferenca == 0;
        }

        private static byte[] CalcularHash(string senha, byte[] saltBytes)
        {
            byte[] senhaBytes = Encoding.UTF8.GetBytes(senha);
            byte[] entrada = new byte[saltBytes.Length + senhaBytes.Length];

            Buffer.BlockCopy(saltBytes, 0, entrada, 0, saltBytes.Length);
            Buffer.BlockCopy(senhaBytes, 0, entrada, saltBytes.Length, senhaBytes.Length);

            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(entrada);
            }
        }
    }
}
