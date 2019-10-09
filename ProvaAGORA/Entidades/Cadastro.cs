using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClass
{
    class Cadastro
    {
        public string Id { get; set; }
        public string Nome{ get; set; }
        public string Telefone{ get; set; }
        public string Data{ get; set; }
        public float Peso { get; set; }

        public override string ToString()
        {

                return $"ID: {Id}, Nome: {Nome}, Telefone: {Telefone}, Data: {Data}; Peso: {Peso}";
            
        }
    } 
}
