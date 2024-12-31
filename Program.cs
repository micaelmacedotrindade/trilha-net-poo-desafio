using DesafioPOO.Models;

Smartphone nokia = new Nokia("123456789", "S21", "AZ1232322XSS", 8);
Smartphone iphone = new Iphone("123456789", "S21", "AZ1232322XSS", 8);


nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");


iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");