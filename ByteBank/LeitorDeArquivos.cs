﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class LeitorDeArquivos : IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivos(string arquivo)
        {
            Arquivo = arquivo;

            //throw new FileNotFoundException();

            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");
            throw new IOException(); // Exception de entrada e saída
        }

        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}
