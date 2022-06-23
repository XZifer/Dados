using Dados.Datos.Clases;
using Dados.Modelos.Clases;

namespace Dados.Aplicacion
{
    public class Program
    {
        public static void Main()
        {
            //Bienvenida al Jego de los Dados
            Console.WriteLine("Bienvenido al juego de dados");
            //Reglas
            Console.WriteLine("Reglas:\n" +
                "Se tiran tres dados si los tres salen con el mismo valor ´You Win!!!´, sino ´You lose!!´");
            //Iniciar Juego
            IniciarJuego();

        }

        private static void IniciarJuego()
        {
            JuegoDeDados juego = new JuegoDeDados();
            string tirarDados;
            List<Dado> lista = juego.ListaDeDados;
            
            
            Console.WriteLine("¿Quieres tirar los dados?: S-Si N-No");
            string tirardados = Console.ReadLine();
            string resultado;
            switch (tirardados.ToUpper())
            {
                case "S":                    
                    resultado = juego.Jugar(lista);
                    Console.WriteLine(resultado);
                    break;
                case "N":
                    Console.WriteLine("Hasta Luego!!!");
                    break;
                default:
                    tirardados = null;
                    break;   
            }
            
            Imprimir(lista);
                
        }

        private static void Imprimir(List<Dado> ld)
        {
            foreach (Dado d in ld)
            {
                Console.WriteLine(d.valor);
            }
        }
    }
}