using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace CadaJSON
{
    public static class DadosPessoas
    {
        private static readonly string Pasta = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "CadaJSON");

        private static readonly string CaminhoArquivo = Path.Combine(Pasta, "contatos.json");

        private static List<Pessoa> _lista = new List<Pessoa>();

        public static IReadOnlyList<Pessoa> Lista => _lista.AsReadOnly();

        static DadosPessoas()
        {
            Carregar();
        }

        public static void Carregar()
        {
            try
            {
                Directory.CreateDirectory(Pasta);

                if (File.Exists(CaminhoArquivo))
                {
                    string json = File.ReadAllText(CaminhoArquivo);
                    _lista = JsonSerializer.Deserialize<List<Pessoa>>(json) ?? new List<Pessoa>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        public static void Salvar()
        {
            try
            {
                string json = JsonSerializer.Serialize(_lista, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(CaminhoArquivo, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar dados: " + ex.Message);
            }
        }

        public static void AdicionarOuAtualizar(Pessoa p)
        {
            var existente = _lista.Find(x => x.Identificador == p.Identificador);
            if (existente != null)
            {
                // Update
                existente.Nome = p.Nome;
                existente.Telefone = p.Telefone;
            }
            else
            {
                _lista.Add(p);
            }
            Salvar();
        }

        public static bool Excluir(string identificador)
        {
            var item = _lista.Find(x => x.Identificador == identificador);
            if (item != null)
            {
                _lista.Remove(item);
                Salvar();
                return true;
            }
            return false;
        }

        public static Pessoa Buscar(string identificador)
        {
            return _lista.Find(x => x.Identificador == identificador);
        }
    }
}