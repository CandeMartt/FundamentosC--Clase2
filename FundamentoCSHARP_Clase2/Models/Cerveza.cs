using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentoCSHARP_Clase2.Models
{
    class Cerveza : Bebida
        // La cerveza por herencia ya tiene todos los atributos y metodos (que sean public, internal o protected) de la clase BEBIDA. 
    {
        // Hay que hacer un constructor si o si
        public Cerveza(int Cantidad, string Nombre = "Cerveza") // : base("Cerveza", 500) // en caso de poner valores predeterminados
            // si quiero poner un valor predeterminado SIEMPRE se pone al final.
            // base hace referencia al constructor de su padre. 
            : base (Nombre, Cantidad)
            // En base siempre se deben pasar los atributos en orden
        { 

        }
    }
}
