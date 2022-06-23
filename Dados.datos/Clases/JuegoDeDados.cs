using Dados.Modelos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Datos.Clases
{
    public class JuegoDeDados
    {
        public List<Dado> ListaDeDados { get; set; } = new List<Dado>();
        public JuegoDeDados()
        {
            Dado d1 = new()
            {
                valor = 0
            };
            Dado d2 = new()
            {
                valor = 0
            };
            Dado d3 = new()
            {
                valor = 0
            };
            ListaDeDados.Add(d1);   
            ListaDeDados.Add(d2);   
            ListaDeDados.Add(d3);
        }
        public string Jugar(List<Dado> ld)
        {
            Dados dados = new();
            List<int> lista = new List<int>();
            int salida;
            foreach (Dado d in ld)
            {
                salida = dados.Tirar(d);
                lista.Add(salida);  
            }

            if (lista[0] == lista[1]
                && lista[1] == lista[2])
            {
                return "You Win!!";
            }
            else
            {
                return "You Lose!!";
            }
            
        }
    }
}
