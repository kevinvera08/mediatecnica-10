/******************************************************************************

autor:kevin vera
fecha: 05/06/2024
Descripción: El Rey León: 
    Las manadas de la Roca del Rey están compitiendo 
    por el control de las Tierras del Reino. 
    Pide al usuario la fuerza de al menos 5 
    clanes diferentes y usa estructuras "si" 
    para determinar clasificación de fuerza.

*******************************************************************************/
using System;

class HelloWorld {
   
  static void Main(string[] args) {
     
    // variables
    int fuerza = 0;
   
   
   
    Console.WriteLine("Bienvenido a miniApp para fuerza.");
   
   
    for (int i = 0; i <= 4; i++ )
    {
        Console.WriteLine("\nIngrese su numero de fuerza del 1 al 5: " + i + " ,luego presionar enter");
        fuerza =  Int32.Parse(Console.ReadLine());
   
    if (fuerza == 5){
        Console.WriteLine("\nleon🦁");
    }
        if (fuerza == 4){
       
            Console.WriteLine("\nhiena🐆");
       }
            if (fuerza == 3){
                Console.WriteLine("\ncebra🦓");
           }
                if (fuerza == 2){
                    Console.WriteLine("\nrinoceronte🦏");
               }
                    if (fuerza == 1){
                        Console.WriteLine("\nantilope🐐");
    }
    }
   
  }
}
