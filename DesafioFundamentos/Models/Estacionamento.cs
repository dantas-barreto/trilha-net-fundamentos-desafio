namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        Veiculo carro;
        private List<Veiculo> veiculos = new List<Veiculo>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Inserção de informações do veículo
            Console.Clear();
            Console.WriteLine("Marca do veículo:");
            string marca = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Modelo do veículo:");
            string modelo = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Cor do veículo:");
            string cor = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Placa do veículo:");
            string placa = Console.ReadLine();

            // Criação do objeto
            carro = new Veiculo(marca, modelo, cor, placa);

            // Adição do objeto na lista
            veiculos.Add(carro);
        }

        public void RemoverVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine().ToUpper();

            // Verifica se o veículo existe
            if (carro.Placa == placa)
            {
                int horas = 0;
                decimal valorTotal = 0; 

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Convert.ToInt32(Console.ReadLine());
                
                valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(carro);

                Console.WriteLine($"O veículo {carro.Placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            Console.Clear();
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (Veiculo item in veiculos)
                {
                    item.ListaVeiculo();
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
