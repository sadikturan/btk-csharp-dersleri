// Switch-Case


// int gun = (int)DateTime.Now.DayOfWeek; // 0=> pazar, 1=> pazartesi ... 6=> cumartesi

// switch(gun) {
//     case 0:
//         Console.WriteLine("pazar");
//         break;
//     case 1:
//         Console.WriteLine("pazartesi");
//         break;
//     case 2:
//         Console.WriteLine("salı");
//         break;
//     case 3:
//         Console.WriteLine("çarşamba");
//         break;
//     case 4:
//         Console.WriteLine("perşembe");
//         break;
//     case 5:
//         Console.WriteLine("cuma");
//         break;
//     case 6:
//         Console.WriteLine("cumartesi");
//         break;

//     default:
//         Console.WriteLine("hatalı gün");
//         break;

// }

int ay = 15;

switch (ay)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlkbahar");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("yaz");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("sonbahar");
        break;
    
    default:
        Console.WriteLine("Hatalı ay bilgisi");
        break;
}