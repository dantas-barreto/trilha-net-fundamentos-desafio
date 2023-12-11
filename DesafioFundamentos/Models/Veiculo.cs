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

        public string Marca
        {
            get
            {
                return _marca.ToUpper();
            }
        }

        public string Modelo
        {
            get
            {
                return _modelo.ToUpper();
            }
        }

        public string Cor 
        {
            get
            {
                return _cor.ToUpper();
            }
        }

        public string Placa 
        {
            get
            {
                return _placa.ToUpper();
            }
        }

        public void ListaVeiculo()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Cor: {Cor}, Placa: {Placa}");
        }
    }
}