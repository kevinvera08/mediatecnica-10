/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
 
  //declaracion y asignacion de un vector
  string [] nombres = {"kevin", "efrain", "la maria"};
  
  //imprimir un dato del vector de manera directa
  Console.WriteLine (nombres [0]);
  
  /*imprimir un dato del vector de manera dinamica
    recorrer imprimiento el vector */
    
    for (int i = 0 ; i <=2; i++){
     
        Console.WriteLine (nombres[i]);    
    }
    
  }
}
