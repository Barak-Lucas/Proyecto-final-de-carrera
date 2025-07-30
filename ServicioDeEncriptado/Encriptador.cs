using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;

namespace ServicioDeEncriptado
{
    public class Encriptador
    {
        public static string Encriptar(string pContraseña)
        {
			try
			{
				byte[] encriptado = Encoding.Unicode.GetBytes(pContraseña);
				string resultado = Convert.ToBase64String(encriptado);
				return resultado;
			}
			catch (Exception){throw;}
        }

		public static string Desencriptar(string pContraseñaEncriptada)
		{
			try
			{
				byte[] desencriptar = Convert.FromBase64String(pContraseñaEncriptada);
				string resultado = Encoding.Unicode.GetString(desencriptar);
				return resultado;
			}
			catch (Exception){throw;}
		}
    }
}
