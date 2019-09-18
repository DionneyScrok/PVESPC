using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaAGORA
{
    class Cadastro
    {
        private string Id;
        private string Nome;
        private string Telefone;
        private string Data;
        private float Peso;

        public string _ID
        {
            get { return Id; }
            set { Id = value; }
        }
        public string _NOME
        {
            get { return Nome; }
            set { Nome = value; }
        }
        public string _TELEFONE
        {
            get { return Telefone; }
            set { Telefone = value; }
        }
        public string _DATA
        {
            get { return Data; }
            set { Data = value; }
        }
        public float _PESO
        {
            get { return Peso; }
            set { Peso = value; }
        }
        public Cadastro(string id, string nome, string telefone, string data, float peso)
        {
            this.Id = id;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Data = data;
            this.Peso = peso;
        }
    } 
}
