// Array Slicing

string[] sehirler = {"zonguldak","rize","kocaeli","istanbul","ankara","çanakkale"};

// foreach(var sehir in sehirler[0..3]) {
//     Console.WriteLine(sehir);
// }

foreach(var sehir in sehirler[2..]) {
    Console.WriteLine(sehir);
}

string il = "Kocaeli";

Console.WriteLine(il[..5]);


