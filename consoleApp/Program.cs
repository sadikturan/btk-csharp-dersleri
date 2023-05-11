// Dizi Metotları (Array Methods)

string[] sehirler = {"zonguldak","rize","kocaeli"};
int[] plakalar = {67,53,41};

// sehirler[0] = "sakarya";
// sehirler.SetValue("sakarya",1);

Console.WriteLine(sehirler.GetValue(1));
Console.WriteLine(sehirler.Length);
Console.WriteLine(Array.IndexOf(sehirler, "rize"));

Array.Sort(sehirler);
Array.Sort(plakalar);

Array.Reverse(plakalar);

Array.Clear(sehirler);
Array.Clear(plakalar, 0, 1);

Console.WriteLine(plakalar.GetValue(0));
Console.WriteLine(plakalar.GetValue(1));
Console.WriteLine(plakalar.GetValue(2));
