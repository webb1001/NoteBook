﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Notebook.UNA.Encriptar
{
    class Encriptar
    {
        string clave = "";
        public Encriptar() 
        {
            clave = "pje89e09ewhfo24w";
        }
        public string Encriptamiento(string dato)
        {
            byte[] keyArray;
            byte[] encriptar = Encoding.UTF8.GetBytes(dato);
            keyArray = Encoding.UTF8.GetBytes(clave);
            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultado = cTransform.TransformFinalBlock(encriptar, 0, encriptar.Length);
            tdes.Clear();
            return Convert.ToBase64String(resultado, 0, resultado.Length);
        }
        public string Desencriptamiento(string dato)
        {
            byte[] keyArray;
            byte[] decriptar = Convert.FromBase64String(dato);
            keyArray = Encoding.UTF8.GetBytes(clave);
            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultado = cTransform.TransformFinalBlock(decriptar, 0, decriptar.Length);
            tdes.Clear();
            return Encoding.UTF8.GetString(resultado);
        }
    }
}
