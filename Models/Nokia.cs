namespace DesafioPOO.Models{

    // TODO: Herdar da classe "Smartphone"

    public class Nokia : Smartphone{

        // TODO: Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(string aplicativo){

            Console.WriteLine($"Instalando o aplicativo {aplicativo} no Nokia.");
            
        }

        // Também precisa criar um construtor Nokia!
        public Nokia(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria){
            
        }

    }

}