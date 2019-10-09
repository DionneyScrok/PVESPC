using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroClass;
using DAO;
using Controler;
using Principal;
using View;

namespace View
{
    class ViewCadastro
    {

        public string menuDEcadastro(int qtdRegistros)
        {
            Console.WriteLine($"Pessoas cadastradas = {qtdRegistros}");
            Console.WriteLine("(1) - INCLUIR!");
            Console.WriteLine("(2) - ALTERAR!");
            Console.WriteLine("(3) - EXCLUIR!");
            Console.WriteLine("(4) - LISTAR!");
            Console.WriteLine("(5) - PESQUISAR!");
            Console.WriteLine("(6) - SAIR!");
            Console.WriteLine("(7) - SALVAR!");
            return Console.ReadLine();
        }
        public void mostraCadastro(Cadastro cadatro)
        {
            Console.WriteLine($" {cadatro}");
        }
        public Cadastro incluirCadastro()
        {
            Cadastro cadastro = new Cadastro();
            Console.WriteLine("(INCLUIR) - Adicione os dados para incluir na lista.");
            cadastro.Id = ler("Adicione o ID:");
            cadastro.Nome = ler("Adicione o Nome:");
            cadastro.Telefone = ler("Adicione o telefone:");
            cadastro.Data = ler("Adicione a data de nascimento:(DD/MM/AAAA)");
            cadastro.Peso = float.Parse(ler("Adicione o peso:"));
            Console.WriteLine("Cadastrado com sucesso!!!");
                return cadastro;
        }

        public string lerIdCadastro(string idCadastro)
        {
            Console.WriteLine(idCadastro);
            return ler("\nInforme o ID:");
        }
        public string lerAlteracao(string mesage, string valor)
        {
            Console.Write($"{mesage} ({valor}):");
            string vlr = Console.ReadLine();
            return !vlr.Equals("") ? vlr : valor;
        }
        public string ler(string mesage)
        {
            Console.WriteLine($"{mesage}");
            return Console.ReadLine();
        }
        public string alterarCadastro(Cadastro cadastro)
        {
            Console.WriteLine("\n(ALTERAR)");
            cadastro.Id = lerAlteracao("Insira o ID:", cadastro.Id);
            cadastro.Nome = lerAlteracao("Insira o Nome:", cadastro.Nome);
            cadastro.Telefone = lerAlteracao("Insira o Telefone:", cadastro.Telefone);
            cadastro.Data = lerAlteracao("Insira o Data de nascimento:", cadastro.Data);
            cadastro.Peso = float.Parse(lerAlteracao("Insira o peso:",cadastro.Peso.ToString()));
            Console.WriteLine("\nEditado com sucesso!\n");
            return cadastro.ToString();
        }
        public void mensagem ( string mensagem)
        {
            Console.WriteLine(mensagem);
        }
        public string confimarExclusao(Cadastro cadastro)
        {
            Console.WriteLine($"Deseja prosseguir com a exclusão de:{cadastro}");
            return ler("Deseja excluir esse registro (s/n)?");
        }
        internal void listaDEcadastros(List<Cadastro> listaDEcadastros)
        {
            Console.WriteLine("\nLista de Cadastros\n");
            listaDEcadastros.ForEach(cadastro => Console.WriteLine(cadastro));
        }
        public Dictionary<string, string> pesquisar()
        {

            Dictionary<string, string> elementosDePesquisa = new Dictionary<string, string>();
            Console.WriteLine("01 - Por Id");
            Console.WriteLine("02 - Por Nome");
            Console.WriteLine("03 - Por Telefone");


            string opcao = ler("\nIndique a opção: ");
            string elemento = ler("\nDigite o valor de busca: ");

            elementosDePesquisa.Add("opcao", opcao);
            elementosDePesquisa.Add("elemento", elemento);

            return elementosDePesquisa;

        }



    }
}
