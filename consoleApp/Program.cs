// do-while döngüsü

// int i = 1;

// do {
//     Console.WriteLine(i);
//     i++;
// } while(false);

Console.Write("adet: ");
int adet = Convert.ToInt32(Console.ReadLine());

string[] urunler = new string[adet];

int i = 0;

do {
    Console.Write("ürün adı: ");
    urunler[i] = Console.ReadLine() ?? "";

    i++;
} while(adet != i);

Console.WriteLine("ürünler listeleniyor...");

for(var a = 0; a < urunler.Length; a++) {
    Console.WriteLine(urunler[a]);
}