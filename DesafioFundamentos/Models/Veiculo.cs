using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Veiculo
    {
        private string _marca { get; }
        private string _modelo { get; }
        private string _cor { get; }
        private string _placa { get; }

        public Veiculo(string marca, string modelo, string cor, string placa)
        {
            _marca = marca;
            _modelo = modelo;
            _cor = cor;
            _placa = placa;
        }
    }
}