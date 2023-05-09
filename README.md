/*
    DateTime
*/

var simdi = DateTime.Now;

Console.WriteLine(simdi);
Console.WriteLine(simdi.Year);
Console.WriteLine(simdi.Month);
Console.WriteLine(simdi.Day);
Console.WriteLine(simdi.DayOfWeek);
Console.WriteLine(simdi.Hour);
Console.WriteLine(simdi.Minute);
Console.WriteLine(simdi.Second);

DateTime dt = new DateTime(2022, 6, 10, 14, 30, 45);
DateTime dt2 = dt.AddYears(1);
DateTime dt3 = dt.AddHours(2);

Console.WriteLine(dt2.Year);
Console.WriteLine(dt3.Hour);

var fark = simdi - dt;
Console.WriteLine(fark.TotalDays);
Console.WriteLine(fark.TotalMinutes);