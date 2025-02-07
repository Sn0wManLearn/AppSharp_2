Bits bit1 = new(4L);
Bits bit2 = new(4);
Bits bit3 = new((byte)4);


Console.WriteLine($"Значение: {bit1.Value} \tразмер данных {bit1.Size}");
Console.WriteLine($"Значение: {bit2.Value} \tразмер данных {bit2.Size}");
Console.WriteLine($"Значение: {bit3.Value} \tразмер данных {bit3.Size}");