using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto Nokia
        Nokia nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "123456789012345", memoria: 16);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Criando um objeto Iphone
        Iphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 12", imei: "987654321012345", memoria: 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
