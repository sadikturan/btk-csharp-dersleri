
## Değişken Tanımlama

Uygulama 1: Bir öğrencinin aşağıdaki bilgileri için gerekli değişkenleri oluşturunuz.  

Öğrenci adı
Öğrenci soyadı
Öğrenci ad ve soyad
Öğrenci numarası
Öğrenci cinsiyet
Öğrenci tc kimlik
Öğrenci doğum yılı
Öğrenci adres bilgisi
Öğrenci yaşı  

    var ogrenciAdi = "Ahmet ";    
    var ogrenciSoyadi = "Turan";    
    var adSoyad = ogrenciAdi + ogrenciSoyadi;    
    var ogrenciNo = "1025";    
    var ogrenciTc = "111111";    
    var ogrenciDogumYili = 2005;    
    var ogrenciYas = 2024 - ogrenciDogumYili;    
    var ogrenciAdres = "Kocaeli izmit";     
    
    Console.WriteLine(ogrenciAdi);    
    Console.WriteLine(ogrenciSoyadi);    
    Console.WriteLine(adSoyad);    
    Console.WriteLine(ogrenciNo);    
    Console.WriteLine(ogrenciTc);    
    Console.WriteLine(ogrenciYas);    
    Console.WriteLine(ogrenciAdres);

Uygulama 2: Aşağıdaki ürünlerin toplam bilgisini hesaplayınız.

Ürün 1 => 50 TL
Ürün 2 => 60.5 TL
Ürün 3 => 356.45 TL    

    var urun1_fiyat = 50;    
    var urun2_fiyat = 60.5;    
    var urun3_fiyat = 356.45;  
    
    var toplam = urun1_fiyat + urun2_fiyat + urun3_fiyat;    
    Console.WriteLine(toplam);