using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroClass;
using Controler;

namespace DAO
{
    class DAOcadastro
    {
        private List<Cadastro> listaDEcadastros = new List<Cadastro>();
        public int pegaTodos()
        {
            return listaDEcadastros.Count;
        }
        
        public void addCadastro(Cadastro cadastro)
        {
            listaDEcadastros.Add(cadastro);
        }
        public Cadastro findCadastro(string id)
        {
            return listaDEcadastros.Find(x => x.Id.Equals(id));
        }
        internal void removeCadastro(Cadastro cadastro)
        {
            listaDEcadastros.Remove(cadastro);
        }
        internal List<Cadastro> getAllCadastros()
        {
            return listaDEcadastros;
        }
        public Cadastro findNome(string nome)
        {
            return listaDEcadastros.Find(x => x.Nome.Equals(nome));
        }
        public Cadastro findTelefone(string telefone)
        {
            return listaDEcadastros.Find(x => x.Telefone.Equals(telefone));
        }
        public Cadastro findID(string id)
        {
            return listaDEcadastros.Find(x => x.Id.Equals(id));
        }
        internal void setListaCadastros(List<Cadastro> lista)
        {
            if (listaDEcadastros != null)
                listaDEcadastros.AddRange(lista);
        }
    }
}
