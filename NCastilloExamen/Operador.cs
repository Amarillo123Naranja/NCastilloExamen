using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCastilloExamen
{
    public class Operador
    {

        public int Numero1 { set; get; }

        public int Numero2 { set; get; }

        public string[] Color { set; get; }   



        //Constructores
        public Operador(int numero1) 
        {
            Numero1 = numero1;
        
        }

        public Operador(int numero1, int numero2) 
        {
        
        Numero1 = numero1;
        Numero2 = numero2;
        
        }

        public Operador(string[] color)
        {
           
            Color = color;
        }   

        //Metodos
        
        public static void For(int numero1)
        {
            for( int i = 0; i < numero1; i++ ) 
            {
                Console.WriteLine( i );
            }

        }


        public static void While(int numero1, int numero2)
        {
            while (numero1 < numero2)
            {
                
                    Console.WriteLine("Numeros Diferentes");
                    numero1 ++;
                
            }

            Console.WriteLine("Numeros iguales");
        }

        public static void Foreach(string[] color)
        {
            foreach(string s in color)
            {
                Console.WriteLine(s);
            }   

        }
    }
}
