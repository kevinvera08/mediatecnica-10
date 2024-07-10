/*
    los personajes de friendes estan organizando un evento y necesitan 
    un programa de c# para imprimir los nombres de los asistentes.
    chandler,joey,monica,rachel,ross,phoebe
*/

using System;
class MisegundoVector {
  static void Main() {


    // asignación de un vector dinámico
    string [] asistentes = {
        
    "chandler",
    "joey",
    "monica",
    "rachel",
    "ross",
    "phoebe"};
    
    /* imprimir un dato del vector de manera dinámica
       recorrer imprimiendo el vector */
       for (int J = 0; J < 6; J++){
        Console.WriteLine(asistentes[J]);
       }
  }
}