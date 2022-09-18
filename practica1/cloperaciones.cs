using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    class cloperaciones
    {
        //Atributos
        private float num1;
        private float num2;

        //Constructor(Es el que dirige)
        public cloperaciones(float num1, float num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        //Métodos
        public float sumar()
        {
            return (num1 + num2);
        }
       
        public float resta()
        {
            return (num1 - num2);
        }
        
        public float multiplicacion()
        {
            return (num1*num2);
        }
      
        public float division()
        {
            return (num1 / num2);
        }
    }
}
