namespace AcelerandoNoConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            {
                Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2024, 110);
                Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);

                //Carro carro1 = new Carro("Sedan", "Chevrolet", "Onix", 2024, 110);
                //Carro carro2 = new Carro("SUV", "Ford", "EcoSport", 2018, 120);

                chevrolet.Exibir();
                Carro.Acelerar(chevrolet.Marca);
                ford.Exibir();
                Carro.Acelerar(ford.Marca);
            }

            // Segunda parte

            //    carro1.Exibir();
            //    carro1.Acelerar(carro1.Marca);
            //    carro2.Exibir();
            //    carro2.Acelerar(carro2.Marca);
            //}
        }
    }
}