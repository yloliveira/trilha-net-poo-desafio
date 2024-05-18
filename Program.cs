using DesafioPOO.Models;

Nokia nokia = new Nokia("99999-9999", "mod1", "123", 4096);
Iphone iphone = new Iphone("88888-8888", "12 mini", "123456", 8096);

nokia.InstalarAplicativo("gmail");
nokia.Ligar();
nokia.ReceberLigacao();

iphone.InstalarAplicativo("Google chrome");
iphone.Ligar();
iphone.ReceberLigacao();