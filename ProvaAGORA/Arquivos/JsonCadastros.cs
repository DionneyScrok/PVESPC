using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using View;
using DAO;
using Controler;
using CadastroClass;
using Newtonsoft.Json;

namespace JsonCadastross
{
    class JsonCadastros
    {
        public Boolean salvarArquivoJSon(List<Cadastro> listCadastro)
        {
            string json = JsonConvert.SerializeObject(listCadastro, Formatting.Indented);

            //write string to file
            File.WriteAllText(@"./Cadastros.json", json);
            return true;
        }



        public List<Cadastro> lerArquivoJSon()
        {
            string jsonFilePath = @"./Cadastros.json";
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);

                List<Cadastro> lista = JsonConvert.DeserializeObject<List<Cadastro>>(json);
                return lista;
            }
            return null;
        }

    }
}
