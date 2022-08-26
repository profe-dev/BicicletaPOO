using System;

namespace EjercicioBicicletaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando a la clase
            Bicicleta bicicleta1 = new Bicicleta();

            //Accediendo a los campos
            bicicleta1.marca = "Oxford";
            bicicleta1.modelo = "Kamikaze";
            bicicleta1.color = "Roja";
            bicicleta1.aro = 16;
            bicicleta1.velocidades = 7;

            //Accediendo a los métodos
            bicicleta1.Frenar();
            bicicleta1.MostrarInformacion();
        }

        public class Bicicleta
        {
            //Campos
            public string marca;
            public string modelo;
            public string color;
            public int aro;
            public int velocidades;

            //Métodos
            public void Acelerar()
            {
                Console.WriteLine("La bicicleta está acelerando!");
            }

            public void Frenar()
            {
                Console.WriteLine("La bicicleta está frenando!");
            }

            public void CambioVelocidades()
            {
                Console.WriteLine("La Bicileta está cambiando de velocidad!");
            }

            public void MostrarInformacion()
            {
                Console.WriteLine("La Bicicleta es de marca: {0}", marca );
                Console.WriteLine("La Bicileta es de modelo: {0}", modelo);
                Console.WriteLine("La Bicileta es de color: {0}", color);
                Console.WriteLine("La Bicicleta es de aro: {0}", aro);
                Console.WriteLine("La Bicileta tiene {0} velocidades", velocidades);
            }

        }
    }
}
