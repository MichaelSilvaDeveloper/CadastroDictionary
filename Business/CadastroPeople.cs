using System;
using System.Collections.Generic;
using System.IO;


namespace CadastroDictionaryList
{
    public class CadastroPeople : ICadastroPeople
    {
        Dictionary<int, string> peopleList = new Dictionary<int, string>();
        //private Dictionary<int, string> peopleList;

        public void AddPerson()
        {
            Console.WriteLine("Digite o id da pessoa: ");
            int idPerson = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome da pessoa: ");
            string namePerson = Convert.ToString(Console.ReadLine());
            peopleList.Add(idPerson, namePerson);
            GravarDadosdaArquivo();
        }

        public void DisplayPeople()
        {
            if (peopleList.Count == 0)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                foreach (KeyValuePair<int, string> person in peopleList)
                {
                    Console.WriteLine("Pessoas: " + "\n" + "Id: {0}" + "\n" + "Nome: {1}", person.Key, person.Value);
                }
            }
        }

        public void SearchPerson()
        {
            if (peopleList.Count == 0)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                Console.WriteLine("Buscar pessoa por id");
                Console.WriteLine("Informe o id da pessoa para encontrar-lá");
                int searchPersonById = Convert.ToInt32(Console.ReadLine());

                foreach (KeyValuePair<int, string> person in peopleList)
                {

                    if (searchPersonById.Equals(person.Key))
                    {
                        Console.WriteLine("Pessoa encontrada");
                        Console.WriteLine("Pessoa: " + "\n" + "Id: {0}" + "\n" + "Nome: {1}", person.Key, person.Value);
                        //Console.WriteLine(person.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Pessoa não encontrada");
                    }
                }
            }
        }

        public void EditPerson()
        {
            if (peopleList.Count == 0)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                Console.WriteLine("Buscar pessoa por id");
                Console.WriteLine("Informe o id da pessoa para encontrar-lá");
                int searchPersonById = Convert.ToInt32(Console.ReadLine());

                foreach (KeyValuePair<int, string> person in peopleList)
                {

                    if (searchPersonById.Equals(person.Key))
                    {
                        var a = person.Key;
                        var b = person.Value;
                        Console.WriteLine("Pessoa encontrada");
                        Console.WriteLine("Digite um novo nome para a pessoa: ");
                        string newNamePerson = Convert.ToString(Console.ReadLine());

                    }
                    else
                    {
                        Console.WriteLine("Pessoa não encontrada");
                    }
                }
            }

        }

        public void RemovePerson()
        {
            if (peopleList.Count == 0)
            {
                Console.WriteLine("Lista Vazia");
            }
            else
            {
                Console.WriteLine("\n - Remover Pessoa - ");
                Console.WriteLine("\nLista de Pessoas");
                foreach (KeyValuePair<int, string> person in peopleList)
                {
                    Console.WriteLine("Pessoas: " + "\n" + "Id: {0}" + "\n" + "Nome: {1}", person.Key, person.Value);
                }
                Console.WriteLine("\nDigite o id da pessoa para remover");
                int removePersonById = Convert.ToInt32(Console.ReadLine());
                foreach (KeyValuePair<int, string> person in peopleList)
                {
                    if (peopleList.ContainsKey(removePersonById))
                    {
                        Console.WriteLine("Pessoa encontrada");
                        Console.WriteLine("Deseja remover essa pessoa ? [ 1 ] - Sim / [ 2 ] - Não");
                        int option = Convert.ToInt32(Console.ReadLine());
                        if (option == 1)
                        {
                            Console.WriteLine("Pessoa removida");
                            peopleList.Remove(removePersonById);
                            //peopleList.Remove(person.Key);
                        }
                        else if (option == 2)
                        {
                            Console.WriteLine("Pessoa não removida");
                        }
                        else
                        {
                            Console.WriteLine("Insira uma opção inválida");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Pessoa não encontrada");
                    }
                }
            }
            GravarDadosdaArquivo();
        }

        public void GravarDadosdaArquivo()
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\Michael\\Desktop\\DictionaryList\\Test.txt");  //Instancia um Objeto StreamWriter (Classe de Manipulação de Arquivos)
                foreach (KeyValuePair<int, string> person in peopleList)
                {
                    sw.WriteLine("Pessoas: " + "\n" + "Id: {0}" + "\n" + "Nome: {1}", person.Key, person.Value);
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executando o Bloco de Comandos.");
            }
        }

        public void LerDadosDoAquivo()
        {
            StreamReader x;

            string Caminho = "C:\\Users\\Michael\\Desktop\\DictionaryList\\Test.txt";
            x = File.OpenText(Caminho);
            while (x.EndOfStream != true)
            {
                string linha = x.ReadLine();
                Console.WriteLine(linha);
            }
            x.Close();
            Console.ReadKey();
        }
    }
}