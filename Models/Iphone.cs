namespace DesafioPOO.Models{

    // TODO: Herdar da classe "Smartphone"

    public class Iphone: Smartphone{

        // TODO: Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(string aplicativo){

            Console.WriteLine($"Instalando o aplicativo {aplicativo} no Iphone.");

        }

        // Também precisa criar um construtor Iphone! 
        public Iphone(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria){    

        }

    }

}