// While Döngüsü Uygulama

// Sayı Tahmin
// 1-100 arasında rastgele tutulan bir sayıyı buldurmaya çalışın.
// Tanımlanan hak bittiğinde oyun bitmeli.

var rnd = new Random();
int tutulan = rnd.Next(1, 100);
int hak = 3;

while(hak > 0) {
    Console.WriteLine(tutulan);

    Console.Write("sayı: ");
    int sayi = Convert.ToInt32(Console.ReadLine());

    hak--;

    if(sayi == tutulan) {
        Console.WriteLine("tebrikler bildiniz");
        break;
    } 
    else {
        if(hak == 0) {
            Console.WriteLine("oyun bitti");
            break;
        }
        if(tutulan > sayi) {
            Console.WriteLine("yukarı");
        } else {
            Console.WriteLine("aşağı");
        }
    }
}
