using System;
using FundamentoCSHARP_Clase2.Models;

namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {

            Bebida bebida = new Bebida("Coca Cola", 1000);
            bebida.Beberse(500);
            Console.WriteLine(bebida.Cantidad);
            // Console es como el print

            Cerveza cerveza = new Cerveza(500,"Cerveza Quilmes");
            // Por mas que tenga valores por defecto le puedo asignar otro. 
            cerveza.Beberse(10);
            Console.WriteLine(cerveza.Cantidad);
        }
    }
}
