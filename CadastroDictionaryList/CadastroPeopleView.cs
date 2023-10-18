using System;

namespace CadastroDictionaryList
{
    internal class CadastroPeopleView
    {
        private static ICadastroPeople iCadastroPeople;

        public static void AddPerson()
        {
            iCadastroPeople.AddPerson();
        }

        public static void DisplayPeople()
        {
            iCadastroPeople.DisplayPeople();
        }

        public static void SearchPerson()
        {
            iCadastroPeople.SearchPerson();
        }

        public static void EditPerson()
        {
            iCadastroPeople.EditPerson();
        }

        public static void RemovePerson()
        {
            iCadastroPeople.RemovePerson();
        }

        public static void GravarDadosEmArquivo()
        {
            iCadastroPeople.GravarDadosdaArquivo();
        }

        public static void LerDadosDoArquivo()
        {
            iCadastroPeople.LerDadosDoAquivo();
        }

        public static void InvalidOption()
        {
            Console.WriteLine("Opção iválida");
        }

        public static ICadastroPeople getInstanceICadastroPeople()
        {
            return new CadastroPeople();
        }

        static void Main(string[] args)
        {
            iCadastroPeople = getInstanceICadastroPeople();
            //Dictionary<int, string> peopleList = new Dictionary<int, string>();
            string option = "";
                
            while (option != "0")
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("[ 1 ] - Adicionar");
                Console.WriteLine("[ 2 ] - Exibir Pessoas");
                Console.WriteLine("[ 3 ] - Buscar");
                Console.WriteLine("[ 4 ] - Editar");
                Console.WriteLine("[ 5 ] - Remover");
                Console.WriteLine("[ 6 ] - Salvar em Arquivo");
                Console.WriteLine("[ 7 ] - Ler Dados do Arquivo");
                Console.WriteLine("[ 0 ] - Sair");
                option = Convert.ToString(Console.ReadLine());
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        AddPerson();
                        Console.Clear();
                        //AddPerson(peopleList);
                        break;
                    case "2":
                        Console.Clear();
                        DisplayPeople();
                        //DisplayPeople(peopleList);
                        break;
                    case "3":
                        Console.Clear();
                        SearchPerson();
                        //SearchPerson(peopleList);
                        break;
                    case "4": 
                        EditPerson();
                        //EditPerson(peopleList);
                        break;
                    case "5":
                        Console.Clear();
                        RemovePerson();
                        //RemovePerson(peopleList);
                        break;
                    case "6":
                        GravarDadosEmArquivo();
                        break;
                    case "7":
                        LerDadosDoArquivo();
                        break;
                    case "0":
                        Console.WriteLine("Obrigado por utilizar este programa");
                        break;
                    default:
                        InvalidOption();
                        break;
                }
            }
        }
    }
}