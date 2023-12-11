using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Veiculo
    {
        private string _marca;
        private string _modelo;
        private string _cor;
        private string _placa;

        public Veiculo(string marca, string modelo, string cor, string placa)
        {
            _marca = marca;
            _modelo = modelo;
            _cor = cor;
            _placa = placa;
        }
    }
}