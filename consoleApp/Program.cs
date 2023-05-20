int sayi = -9;

var sonuc = (sayi % 2 == 0) ? 
                (sayi > 0) ? "sayı pozitif çift": "sayı negatif çift": 
                (sayi > 0) ? "sayı pozitif tek": "sayı negatif tek";

Console.WriteLine(sonuc);