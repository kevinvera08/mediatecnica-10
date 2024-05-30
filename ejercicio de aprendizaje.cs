/******************************************************************************
Autor:kevin vera
fecha:23/05/2024
Descripcion:
           ejercicio aprendizaje
           
           dada la nota
           1-pierde
           2-pierde 
           3-gana
           4-alto
           5-superior
*******************************************************************************/
using System;
class Calificaciones{
  static void Main() {

     Console.WriteLine("Ingrese una nota del 1 al 5");
     
     int nota = Int32.Parse(Console.ReadLine());
     
     switch (nota)
     
     {
     case 1: 
         Console.WriteLine("pierdes😥");
     break;
     
     case 2:
         Console.WriteLine("pierde😥");
     break;

     case 3:
         Console.WriteLine("ganas😀");  
     break;
         
     case 4:
         Console.WriteLine("alto😁");
     break;
     
     case 5:
         Console.WriteLine("superior🥳");
     break;
    
     default:
        Console.WriteLine("nota no valida en el sistema");
        Console.WriteLine("finalizando programa...");
        break;
    
     }
    }

}