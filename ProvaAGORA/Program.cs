using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaAGORA
{
    class Program
    {
        static void Main(string[] args)
        {

            Boolean continua = true;
            List<Cadastro> cadastros = new List<Cadastro>();
            do
            {
                Console.WriteLine($"Pessoas cadastradas = {cadastros.Count()}");
                Console.WriteLine("(1) - INCLUIR!");
                Console.WriteLine("(2) - ALTERAR!");
                Console.WriteLine("(3) - EXCLUIR!");
                Console.WriteLine("(4) - LISTAR!");
                Console.WriteLine("(5) - PESQUISAR!");
                Console.WriteLine("(6) - SAIR!");
                string opcao = Console.ReadLine();


                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("(INCLUIR) - Adicione os dados para incluir na lista.");
                        Console.WriteLine("ID: ");
                        string id = Console.ReadLine();
                        Console.WriteLine("Nome: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Telefone: ");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("Informe a data de nascimento: ");
                        string data = Console.ReadLine();
                        Console.WriteLine("Informe o peso: ");
                        float peso = float.Parse(Console.ReadLine());
                        cadastros.Add(new Cadastro(id, nome, telefone, data, peso));
                        break;
                    case "2":
                        Console.WriteLine("(ALTERAR) - Deseja alterar por (id), (nome) ou (telefone)? Informe: ");
                        string opcao2 = Console.ReadLine();
                        switch (opcao2)
                        {
                            case "id":
                                Console.WriteLine("Informe o ID:");
                                string alterando = Console.ReadLine();
                                Cadastro pesquisar = cadastros.Find(x => x._ID.Equals(alterando));
                                if (alterando != null)
                                {
                                    Console.WriteLine($"ID: {pesquisar._ID}");
                                    Console.WriteLine($"Nome: {pesquisar._NOME}");
                                    Console.WriteLine($"Telefone: {pesquisar._TELEFONE}");
                                    Console.WriteLine($"Telefone: {pesquisar._DATA}");
                                    Console.WriteLine($"Telefone: {pesquisar._PESO}");
                                    Console.WriteLine("Informe o novo id:");
                                    pesquisar._ID = Console.ReadLine();
                                    Console.WriteLine("Informe o novo nome:");
                                    pesquisar._NOME = Console.ReadLine();
                                    Console.WriteLine("Informe o novo telefone:");
                                    pesquisar._TELEFONE = Console.ReadLine();
                                    Console.WriteLine("Informe o nova data de nascimento:");
                                    pesquisar._DATA = Console.ReadLine();
                                    Console.WriteLine("Informe o novo peso:");
                                    pesquisar._PESO = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Cadastro alterado com sucesso!");
                                    Console.WriteLine($"ID: {pesquisar._ID}");
                                    Console.WriteLine($"Nome: {pesquisar._NOME}");
                                    Console.WriteLine($"Telefone: {pesquisar._TELEFONE}");
                                    Console.WriteLine($"Telefone: {pesquisar._DATA}");
                                    Console.WriteLine($"Telefone: {pesquisar._PESO}");


                                }
                                else
                                {
                                    Console.WriteLine("Nenhum registro com essa informação!!!");
                                }
                                break;
                            case "nome":
                                Console.WriteLine("Informe o Nome:");
                                string alterando1 = Console.ReadLine();
                                Cadastro pesquisar1 = cadastros.Find(x => x._NOME.Equals(alterando1));
                                if (alterando1 != null)
                                {
                                    Console.WriteLine($"ID: {pesquisar1._ID}");
                                    Console.WriteLine($"Nome: {pesquisar1._NOME}");
                                    Console.WriteLine($"Telefone: {pesquisar1._TELEFONE}");
                                    Console.WriteLine("Informe o novo id:");
                                    pesquisar1._ID = Console.ReadLine();
                                    Console.WriteLine("Informe o novo nome:");
                                    pesquisar1._NOME = Console.ReadLine();
                                    Console.WriteLine("Informe o novo telefone:");
                                    pesquisar1._TELEFONE = Console.ReadLine();
                                    Console.WriteLine("Cadastro alterado com sucesso!");

                                }
                                else
                                {
                                    Console.WriteLine("Nenhum registro com essa informação!!!");
                                }
                                break;
                            case "telefone":
                                Console.WriteLine("Informe o telefone:");
                                string alterando2 = Console.ReadLine();
                                Cadastro pesquisar2 = cadastros.Find(x => x._TELEFONE.Equals(alterando2));

                                if (alterando2 != null)
                                {
                                    Console.WriteLine($"ID: {pesquisar2._ID}");
                                    Console.WriteLine($"Nome: {pesquisar2._NOME}");
                                    Console.WriteLine($"Telefone: {pesquisar2._TELEFONE}"); //COLOCAR PARA ALTERAR NAS CASES ID, TELEFONE E NOME;
                                    Console.WriteLine("Informe o novo id:");
                                    pesquisar2._ID = Console.ReadLine();
                                    Console.WriteLine("Informe o novo nome:");
                                    pesquisar2._NOME = Console.ReadLine();
                                    Console.WriteLine("Informe o novo telefone:");
                                    pesquisar2._TELEFONE = Console.ReadLine();
                                    Console.WriteLine("Cadastro alterado com sucesso!");
                                }
                                else
                                {
                                    Console.WriteLine("Nenhum registro com essa informação!!!");
                                }
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("(EXCLUIR)");
                        Console.WriteLine("Deseja excluir por (id), (nome) ou (telefone). Informe:");
                        string opcao3 = Console.ReadLine();
                        switch (opcao3)
                        {
                            case "id":
                                Console.WriteLine("Informe o ID: ");
                                string excID = Console.ReadLine();
                                Cadastro excluID = cadastros.Find(x => x._ID.Equals(excID));
                                if (excID != null)
                                {
                                    Console.WriteLine($"ID: {excluID._ID}");
                                    Console.WriteLine($"Nome: {excluID._NOME}");
                                    Console.WriteLine($"Telefone: {excluID._TELEFONE}");
                                    Console.WriteLine("Deseja excluir este cadastro? Digite (s) para sim e (n) para não.");
                                    string yesORno = Console.ReadLine();
                                    switch (yesORno)
                                    {
                                        case "s":
                                            cadastros.Remove(excluID);
                                            Console.WriteLine("Cadastro removido com sucesso!!!");
                                            break;
                                        case "n":

                                            break;
                                        default:
                                            Console.WriteLine("Opção Invalida");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Nenhum registro encontrado.");
                                }
                                break;
                            case "nome":
                                Console.WriteLine("Informe o NOME: ");
                                string excNOME = Console.ReadLine();
                                Cadastro excluNome = cadastros.Find(x => x._NOME.Equals(excNOME));
                                if (excNOME != null)
                                {
                                    Console.WriteLine($"ID: {excluNome._ID}");
                                    Console.WriteLine($"Nome: {excluNome._NOME}");
                                    Console.WriteLine($"Telefone: {excluNome._TELEFONE}");
                                    Console.WriteLine("Deseja excluir este cadastro? Digite (s) para sim e (n) para não.");
                                    string yesORno = Console.ReadLine();
                                    switch (yesORno)
                                    {
                                        case "s":
                                            cadastros.Remove(excluNome);
                                            Console.WriteLine("Cadastro removido com sucesso!!!");
                                            break;
                                        case "n":

                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Nenhum registro encontrado.");
                                }
                                break;
                            case "telefone":
                                Console.WriteLine("Informe o telefone: ");
                                string excTEL = Console.ReadLine();
                                Cadastro excluTel = cadastros.Find(x => x._TELEFONE.Equals(excTEL));
                                if (excTEL != null)
                                {
                                    Console.WriteLine($"ID: {excluTel._ID}");
                                    Console.WriteLine($"Nome: {excluTel._NOME}");
                                    Console.WriteLine($"Telefone: {excluTel._TELEFONE}");
                                    Console.WriteLine("Deseja excluir este cadastro? Digite (s) para sim e (n) para não.");
                                    string yesORno = Console.ReadLine();
                                    switch (yesORno)
                                    {
                                        case "s":
                                            cadastros.Remove(excluTel);
                                            Console.WriteLine("Cadastro removido com sucesso!!!");
                                            break;
                                        case "n":

                                            break;
                                        default:
                                            Console.WriteLine("Opção Invalida");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Nenhum registro encontrado.");
                                }
                                break;
                        }
                        break;
                    case "4":
                        Console.WriteLine("(LISTAR)");
                        foreach (Cadastro listar in cadastros)
                        {
                            Console.WriteLine($"ID: {listar._ID}");
                            Console.WriteLine($"Nome: {listar._NOME}");
                            Console.WriteLine($"Telefone: {listar._TELEFONE}");
                            Console.WriteLine($"Telefone: {listar._DATA}");
                            Console.WriteLine($"Telefone: {listar._PESO}");
                            Console.WriteLine("====================");
                        }
                        break;
                    case "5":
                        Console.WriteLine("(Pesquisar)");
                        Console.WriteLine("Deseja pesquisar por (id), (nome) ou (telefone)???");
                        string pesqza = Console.ReadLine();
                        switch (pesqza)
                        {
                            case "id":
                                Console.WriteLine("Digite o id: ");
                                string pesqID = Console.ReadLine();
                                Cadastro pesquiseID = cadastros.Find(x => x._ID.Equals(pesqID));
                                Console.WriteLine($"ID: {pesquiseID._ID}");
                                Console.WriteLine($"Nome: {pesquiseID._NOME}");
                                Console.WriteLine($"Telefone: {pesquiseID._TELEFONE}");
                                break;
                            case "nome":
                                Console.WriteLine("Digite o nome: ");
                                string pesqNome = Console.ReadLine();
                                Cadastro pesquiseNome = cadastros.Find(x => x._NOME.Equals(pesqNome));
                                Console.WriteLine($"ID: {pesquiseNome._ID}");
                                Console.WriteLine($"Nome: {pesquiseNome._NOME}");
                                Console.WriteLine($"Telefone: {pesquiseNome._TELEFONE}");
                                break;
                            case "telefone":
                                Console.WriteLine("Digite o telefone: ");
                                string pesqTEL = Console.ReadLine();
                                Cadastro pesquiseTel = cadastros.Find(x => x._TELEFONE.Equals(pesqTEL));
                                Console.WriteLine($"ID: {pesquiseTel._ID}");
                                Console.WriteLine($"Nome: {pesquiseTel._NOME}");
                                Console.WriteLine($"Telefone: {pesquiseTel._TELEFONE}");
                                break;
                            default:
                                Console.WriteLine("Opção Invalida");
                                break;

                        }
                        break;
                    case "6":
                        Console.WriteLine("SAIR");
                        Console.WriteLine("Deseja realmente sair?sim ou não");
                        string sair = Console.ReadLine();
                        switch (sair) {
                            case "sim":
                        Environment.Exit(6);
                        continua = false;
                                break;
                            case "nao":
                                break;
                }
                        break;
                    default:
                        Console.WriteLine("Opção Invalida");
                        break;

                }
            } while (continua);
        }
    }
}
