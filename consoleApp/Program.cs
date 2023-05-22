// break & continue

// string isim = "Sadık Turan";

// for(var i = 0; i < isim.Length; i++) {
//     if(isim[i] == 'ı') 
//         continue;
    
//     Console.WriteLine(isim[i]);
// }

// Console.WriteLine("döngü bitti");

int x = 0;

while(x < 5) {
    x++;
    if(x == 3) 
        continue;
    Console.WriteLine(x);
}