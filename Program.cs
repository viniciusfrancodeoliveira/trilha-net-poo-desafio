using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia("12345", "6060", "11111111", "64GB");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine(" ");

Console.WriteLine("iPhone:");
Smartphone iPhone = new Iphone("45678", "12 Pro Max", "222222222", "128GB");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");
