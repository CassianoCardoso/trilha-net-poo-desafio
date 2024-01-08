using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DesafioPOO.Models
{

    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando ... {nomeApp}");
            Console.WriteLine("Em progresso...");
            Console.WriteLine("Instalação concluida.");
        }

        internal void InstalarApp(string v)
        {
            throw new NotImplementedException();
        }
    }
}