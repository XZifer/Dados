using Dados.Modelos.Clases;

namespace Dados.Datos.Clases
{
    public class Dados
    {
        public int Tirar(Dado d)
        {
            Random random = new Random();
            d.valor = random.Next(1, 6);
            return d.valor;
        }
        public string Imprimir(int v)
        {
           return v.ToString();
        }
    }    
}