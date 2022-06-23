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
    }
}
