
/******************************************************************************
Autor:kevin vera
fecha:23/05/2024
Descripcion:
            un docente requiere de un sistema de notas donde recibe 4 
            calificaciones generando un promedio y luego determinando 
            si gana o pierde. 
            - si su promedio es menor a 3 pierde
            - si es mayor gana
            -si tiene mayor a 4.5 :
            "felicidades, te has ganado una beca"

*******************************************************************************/
using System;
class Calificaciones{
  static void Main() {
     
     // declaracion de variables para las calificaciones
     double calificacion1, calificacion2, calificacion3, calificacion4;
     
     
     Console.WriteLine("Ingrese la primera calificacion");
     calificacion1 = Convert.ToDouble(Console.ReadLine());
     
     Console.WriteLine("Ingrese la segunda calificacion");
     calificacion2 = Convert.ToDouble(Console.ReadLine());
     
     Console.WriteLine("Ingrese la tercera calificacion");
     calificacion3 = Convert.ToDouble(Console.ReadLine());
     
     Console.WriteLine("Ingrese la cuarta calificacion");
     calificacion4 = Convert.ToDouble(Console.ReadLine());
     
     // calcular el promedio
     double promedio = (calificacion1 + calificacion2 + calificacion3 + calificacion4) / 4;
     
     // mostrar el promedio
     Console.WriteLine("El promedio es: " + promedio);
     
     if (promedio < 2.99){
         Console.WriteLine("perdiste,vuelvelo a intentarlo..😢");
     }
     
     if(promedio >= 3 && promedio <=4.49){
         Console.WriteLine("felicidades,pasaste.");
     }
     
     if(promedio >= 4.5 ){
         Console.WriteLine("felicidades, te has ganado una Beca..🥳");  
     Console.WriteLine("GANASTE!!!!");
     }    
         }
           
     }