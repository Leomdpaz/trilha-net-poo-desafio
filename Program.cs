using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe o número para o iPhone:");
        string numeroIphone = Console.ReadLine();
        Iphone iphone = new Iphone(numeroIphone);

        Console.WriteLine("Informe o número para o Nokia:");
        string numeroNokia = Console.ReadLine();
        Nokia nokia = new Nokia(numeroNokia);

        iphone.Ligar();
        iphone.ReceberLigacao();
        Console.WriteLine("Informe o aplicativo para instalar no iPhone:");
        string appIphone = Console.ReadLine();
        iphone.InstalarAplicativo(appIphone);

        nokia.Ligar();
        nokia.ReceberLigacao();
        Console.WriteLine("Informe o aplicativo para instalar no Nokia:");
        string appNokia = Console.ReadLine();
        nokia.InstalarAplicativo(appNokia);
    }
}
