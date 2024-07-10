/******************************************************************************
 
 un cliente solicita una mini app en consola que imprima freses
 de forma aleatoria coda que se ejecutado
 
*******************************************************************************/
using System;
class mitercervector {
  static void Main() {
    string[] frases = {
      
      "nunca es demasiado tarde para ser lo que podrias haber sido", 
      "aprender de los errores es de sabios",
      "la adversidad te hace reconocerte a ti mismo",
      "nunca digas nunca",
      "es mejor ser temido que amado",
      "El Universo conspira siempre a tu favor"
    };
    
    
   //aleatorio
   Random aleatorio = new Random ();
   int posicion = aleatorio.Next(0,6);
    
    //imprimir frase aleatoria
    Console.WriteLine(frases[posicion]);
    
  }
}