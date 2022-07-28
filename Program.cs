using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSVReader
{
    class Program
    {
        public static void Main(String[] args)
        {
            string linha = "nome, cargo, cidade, telefone, endereco";
            string[] linhaseparada = null;
            StreamReader reader = new StreamReader(@"C:\arquivoCsv\pessoas.csv", Encoding.UTF8, true);
            while (true)
            {
                linha = reader.ReadLine();
                if (linha == null) break;
                linhaseparada = linha.Split(';');                
                string resultado = $@"Linha - S 
                    Nome : {(object)linhaseparada[0]}
                    Cargo: {(object)linhaseparada[1]}
                    Cidade: {(object)linhaseparada[2]}
                    Telefone: {(object)linhaseparada[3]}
                    Endereço: {(object)linhaseparada[4]}";
                Console.WriteLine(resultado);
            }
            Console.ReadKey();
            
        }
    }
}