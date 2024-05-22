/******************************************************************************
autor:        kevin vera
fecha:        22/05/2024
decripcion:   edad para la votacion
*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    
    // variables
    
    int edad;
    int valorMatricula;

    
    // peticion de datos
    
    Console.WriteLine("Digite su edad: ");
    edad = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite su valor de matricula: ");
    valorMatricula = Int32.Parse(Console.ReadLine());
   
    // validacion
   if (edad >= 18 ){
     Console.WriteLine("Felicidades, usted puede votar.: ");   
      Console.WriteLine("usted pagara de matricula: " + (valorMatricula * 0.85));
   }
  }
}