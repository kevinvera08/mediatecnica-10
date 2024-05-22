/******************************************************************************
autor:        kevin vera
fecha:        22/05/2024
decripcion:   programa decisiones para determinar el sexo de un usuario
*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    
    // variables
    
    bool sexoMasculino;
    
    // capturar informacion del usuario
    
    Console.WriteLine("digite true si es hombre: ");
    sexoMasculino = Convert.ToBoolean(Console.ReadLine());
    
    // validacion
    if (sexoMasculino == true )
    {
    
      Console.WriteLine("Felicidades, es hombre");
    }
    else{   
        Console.WriteLine("Felicidades, es mujer");
    }
    
    Console.WriteLine("Finalizada la ejecucion");
    }
}
