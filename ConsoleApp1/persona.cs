using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }


        public persona(string nome , string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }
        public string getNome() {  return Nome; }
        public string getCognome() { return Cognome; }
        public int getEta() { return Eta; }
        public string GetDettagli()
        {
            return "Nome: " + Nome + ", Cognome: " + Cognome + ", Età: " + Eta;
        }
    }
}
