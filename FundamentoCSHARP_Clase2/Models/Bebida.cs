using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentoCSHARP_Clase2.Models
{
    class Bebida
    {
        // Atributos
        public string Nombre { get; set; }

        public int Cantidad { get; set; }

        // es un atributo publico
        // private es un atributo pivado y solo se puede acceder desde la misma clase
        // protectes es un atributo de tipo protegido. Solo pueden accerder las clases derivadas de esta

        // CONSTRUCTOR
        // El constructor debe tener el nombre de la clase SIEMPRE
        // El construstor es un metodo.No tiene tipo ni regresa tipo. Puede ser privado o publico, pero usualmente se utiliza en publico
        public Bebida(string Nombre, int Cantidad)
        {
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }
        // Metodos
        public void Beberse(int CuantoBebio)
            // la palabra void nos devuelve cosas
        {
            this.Cantidad -= CuantoBebio;
            // Se le resta a la cantidad que tenemos, la cantidad que se bebio. Se resta de esta forma. 
            // this es una palabra reservada y hace enfoque en los atributos de la clase
        }


    }
}
