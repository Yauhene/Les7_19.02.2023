// Игра в пирамидки
//http://rebus1.com/index.php?item=tower

void Towers(string with = "1", string on = "3", string some = "2", int count = 3) // Здесь:
// string with = "1" - исходный штырь
// string on = "3" - целевой штырь
// string some = "2" - промежуточный штырь
// int count = 3 - количество шайб на старте
{
if (count > 1) Towers(with, some, on, count - 1);
Console.WriteLine($"{with} >> {on}");
if (count > 1) Towers(some, on, with, count - 1);
}

Towers();