using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        //private List<Actor> actores = new List<Actor>();
        public string titulo ;
        public Int16 año ;
        private string país ;
        private string director ;

        //Constructores
        public Pelicula()
        {
            
        }
        public Pelicula(string titulo, Int16 año)
        {
            this.titulo = titulo;
            this.año = año;           
        }

        //Métodos
        public Int16 GetAño() {return año;}
        public void SetAño(Int16 a){año=a;}
        public string GetTitulo(){return titulo;}
        public void SetTitulo(string t){titulo=t;}
        
        public void Imprime()
        {
            Console.WriteLine($"{titulo} ({año})");
        }

        //LIST
        private List<Actor> actores = new List<Actor>();
        public void ImprimeActores()
            {
                foreach(Actor a in actores)
                {
                    Console.WriteLine(a);
                }
            }

            public void AgregaActor(Actor actor)
            {
                actores.Add(actor);
            }
        
    }

    public class Actor
    {
        //Propiedades
        public string Nombre {get;set;}
        public Int16 Año {get;set;}
        //Constructores
        public Actor (string Nombre, Int16 Año)
        {
            this.Nombre=Nombre;
            this.Año=Año;
        }

        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
        }
          public override string ToString()
        {
            return $"{Nombre} ({Año})";
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {   
           
            //SEGUNDA PARTE
           //Lista de Peliculas
           List<Pelicula>peliculas = new List<Pelicula>();
           peliculas.Add(new Pelicula{titulo="La La Land", año = 2016});
           peliculas.Add(new Pelicula{titulo="Top Gun : Maverick", año = 2022});
           peliculas.Add(new Pelicula{titulo="CODA.Los sonidos del silencio", año = 2021});
           peliculas.Add(new Pelicula{titulo="Todo en todas partes", año = 2022});
           peliculas.Add(new Pelicula{titulo="Green Book", año = 2018});


           foreach(Pelicula p in peliculas)
           {
                Console.WriteLine("{0} ({1}))", p.titulo, p.año);
           }

          //PRIMERA PARTE
          Pelicula p1 = new Pelicula();
          p1.SetTitulo("La La Land");
          p1.SetAño(2016);
          Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
          Pelicula p2 = new Pelicula();
          p2.SetTitulo("Top Gun Maverick");
          p2.SetAño(2022);
          Console.WriteLine("{0}({1})", p2.GetTitulo(), p2.GetAño());
          
          //TERCERA PARTE
            Pelicula p3 = new Pelicula("La La Land", 2016);
             p3.AgregaActor(new Actor("Ryan Gosling", 1980));
             p3.AgregaActor(new Actor("Emma Stone", 1988));

             p3.ImprimeActores();

        }
    }
}
