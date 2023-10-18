using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroDictionaryList
{
    public interface ICadastroPeople
    {
        void AddPerson();
        void DisplayPeople();
        void SearchPerson();
        void EditPerson();
        void RemovePerson();
        void GravarDadosdaArquivo();
        void LerDadosDoAquivo();
    }
}
