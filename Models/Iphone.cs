namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base(numero)
        {
            Numero = numero;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone.");
        }
    }
}
