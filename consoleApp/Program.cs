// Nullable Types

int? maas = default;
bool? isActive = null;

Console.WriteLine(maas.HasValue);
Console.WriteLine(maas.GetValueOrDefault());
Console.WriteLine(isActive.GetValueOrDefault());