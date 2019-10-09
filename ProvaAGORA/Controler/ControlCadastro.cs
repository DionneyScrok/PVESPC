using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;
using DAO;
using CadastroClass;
using Principal;
using JsonCadastross;


namespace Controler
{
    class ControlCadastro
    {
        private ViewCadastro viewCadastro = new ViewCadastro();
        private DAOcadastro daoCadastro = new DAOcadastro();
        public void cadastroPessoa()
        {
            Boolean continua = true;
            do
            {
                string opcao = viewCadastro.menuDEcadastro(daoCadastro.pegaTodos());
                switch (opcao)
                {
                    case "1":
                        adicionar();
                        break;
                    case "2":
                        alterar();
                        break;
                    case "3":
                        excluir();
                        break;
                    case "4":
                        lista();
                        break;
                    case "5":
                        pesquisar();
                        break;
                    case "6":
                        viewCadastro.mensagem("Seu aplicativo foi encerrado!");
                        continua = false;
                        break;
                        break;
                    case "7":
                        salvar();
                        break;
                    default:
                        Console.WriteLine("Opção invalida!");
                        break;
                }
            }while(continua);
        }
        private void salvar()
        {
            new JsonCadastros().salvarArquivoJSon(daoCadastro.getAllCadastros());
        }
        private void adicionar()
        {
            Cadastro cadastro = viewCadastro.incluirCadastro();
            daoCadastro.addCadastro(cadastro);
        }
        private void alterar()
        {
            string id = viewCadastro.lerIdCadastro("(ALTERAR)");
            Cadastro cadastro = daoCadastro.findCadastro(id);
            if ( cadastro != null)
            {
                viewCadastro.alterarCadastro(cadastro);
            }
            else
            {
                viewCadastro.mensagem("Item não encontrado");
            }
           
        }
        private void excluir()
        {
            string id = viewCadastro.lerIdCadastro("(EXCLUIR)");
            Cadastro cadastro = daoCadastro.findCadastro(id);
            if (cadastro != null)
            {
                string confimacao = viewCadastro.confimarExclusao(cadastro);
                if (confimacao.Contains("S") || confimacao.Contains("s"))
                {
                    daoCadastro.removeCadastro(cadastro);
                }
            }
        }
        private void lista()
        {
            List<Cadastro> listaDEcadastros = daoCadastro.getAllCadastros();
            viewCadastro.listaDEcadastros(listaDEcadastros);
        }
        private void pesquisar()
        {
            Cadastro cadastro = null;
            Dictionary<string, string> elemento = viewCadastro.pesquisar();
            viewCadastro.mensagem("Resultado");
            switch (elemento["opcao"])
            {
                case "01": //"Insira o Id: "
                    cadastro = daoCadastro.findID(elemento["elemento"]);
                    break;
                case "02": //"Insira o Nome: "
                    cadastro = daoCadastro.findNome(elemento["elemento"]);
                    break;
                case "03": //"Insira o Autor: "
                    cadastro = daoCadastro.findTelefone(elemento["elemento"]);
                    break;
                default:
                    Console.WriteLine("\nOpção não existente!");
                    break;
            }
            mostraPesquisa(cadastro);
        }

        private void mostraPesquisa(Cadastro cadastro)
        {
            if (cadastro != null)
            {
                viewCadastro.mostraCadastro(cadastro);
            }
            else
            {
                viewCadastro.mensagem("Não encontrado!");
            }
        }




                      
    }
}
