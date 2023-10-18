using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroDictionaryList
{
    public class Person
    {
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Person() {}

        public override string ToString()
        {
            return "Pessoa: " + "\n" + "Id: " + Id + "\n" + "Nome: " + Name + "\n";
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}