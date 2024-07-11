
/*

harry potter necesita un programa
en c# para listar sus hechizos
copleta el espacio en blanco
para mostrar los nombres de los
hechizos en la consola

*/




using System;
using System.Threading;
class HelloWorld {
  static void Main() {
 
  //hechizos aprendidos de harry potter
  string [] hechizos = {"wingardiun leviosa", "expecto patronum","expelliarmus"};
  
    
Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⡿⢿⣿⣿⣿⠀⣿⣿⣿⡿⠻⣿⣿⣿⣿⣿⣿⣿");
Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣷⡈⠻⣿⣿⠀⣿⣿⡟⢁⣾⣿⣿⣿⣿⣿⣿⣿");
Console.WriteLine("⣿⣿⣿⡿⠏⠀⠙⣿⣿⣦⣿⣿⣿⣿⣿⣤⣿⣿⠋⠀⠹⢿⣿⣿⣿");
Console.WriteLine("⣿⡿⠇⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠸⢿⣿");
Console.WriteLine("⣿⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⣿");
Console.WriteLine("⣿⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⣿");
Console.WriteLine("⣿⠀⠀⠀⠀⠀⠀⠀⠸⠛⠉⠉⠿⠉⠉⠛⠇⠀⠀⠀⠀⠀⠀⠀⣿");
Console.WriteLine("⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣴⣿⣦⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹");
Console.WriteLine("⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿");
Console.WriteLine("⣿⣧⠀⠀⠀⠀⠀⠀⣠⣾⣿⣿⣿⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀⣼⣿");
Console.WriteLine("⣿⣿⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⣿⣿");
Console.WriteLine("⣿⣿⣀⣀⣀⣀⣀⣀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣀⣀⣀⣀⣀⣀⣿⣿");
         Thread.Sleep(3000);
        Console.Clear();
        
        for (int i = 0 ; i <=2; i++){
     
        Console.WriteLine (hechizos[i]);    
    }
  }
}