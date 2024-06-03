using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Entities
{
    public class CalculadoraNew
    {
        private List<string> _listahistorico;

        public CalculadoraNew()
        {
            _listahistorico = new List<string>();
        }

        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;
            _listahistorico.Insert(0, $"Res: {res}");
            return res;
        }

        public int Subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            _listahistorico.Insert(0, $"Res: {res}");
            return res;
        }

        public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            _listahistorico.Insert(0, $"Res: {res}");
            return res;
        }

        public int Dividir(int val1, int val2)
        {
            int res = val1 / val2;
            _listahistorico.Insert(0, $"Res: {res}");
            return res;
        }

        public List<string> Historico()
        {
            _listahistorico.RemoveRange(3, _listahistorico.Count - 3);
            return _listahistorico;
        }
    }
}