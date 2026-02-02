using System;
using System.Collections.Generic;
using System.Text;

namespace CadaJSON
{
    internal class Class3   //Cria o arquivo JSON
    {
        //Armazena o diretório e o nome do arquivo JSON
        private const string Diretorio = "/Documentos/CadaJSON/";
        private const string NomeArquivo = "DataPessoas.json";

        public static void CriarArquivo()
        {
            try
            {
                //Criação do diretório caso não exista
                Directory.CreateDirectory(Diretorio);

                string caminhoCompleto = Path.Combine(Diretorio, NomeArquivo);

                //Criação do arquivo se não existir
                if (!File.Exists(caminhoCompleto))
                {
                    File.WriteAllText(caminhoCompleto, "{}", Encoding.UTF8);
                }
            }
            catch (Exception ex)
            {
                throw new IOException("Erro ao criar o arquivo JSON.", ex);
            }
        }
    }
}

