namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //* IMPLEMANTADO AQUI

    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        //* IMPLEMANTADO AQUI

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($@"Instalando aplicativo ""{nomeApp}"" no Nokia...");
        }
    }
}