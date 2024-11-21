/*1.Дана последовательность из 10 чисел. Определить, является ли эта последовательность
упорядоченной по возрастанию. В случае отрицательного ответа определить
порядковый номер первого числа, которое нарушает данную последовательность.
Использовать break.*/

Console.WriteLine("Задание 1");

Console.WriteLine("Введите числа:");
int numberOne = Convert.ToInt32(Console.ReadLine());

int temp = numberOne;

bool result = true;

for (int i = 2; i < 11; i++)
{

    int numberI = Convert.ToInt32(Console.ReadLine());
    if (numberI > temp)
    {
        temp = numberI;
    }
    else
    {
        Console.WriteLine($"Последовательность нарушена, порядковый номер первого числа, которое нарушает данную последовательность - {i}");
        result = false;
        break;
    }

}

if (result)
{
    Console.WriteLine("Последовательность не нарушена");
}





/*2.Игральным картам условно присвоены следующие порядковые номера в зависимости от
их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
Порядковые номера остальных карт соответствуют их названиям («шестерка»,
«девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14) определить достоинство
соответствующей карты. Использовать try-catch-finally.*/

Console.WriteLine("Задание 2");

try
{
    Console.WriteLine("Введите номер игровой карты(от 6 до 14):");

    int k = Convert.ToInt32(Console.ReadLine());

    if (k < 6 || k > 14)
    {
        throw new ArgumentOutOfRangeException("Номер карты должен быть в диапазоне от 6 до 14.");
    }
    string cardName = k switch
    {
        11 => "Валет",
        12 => "Дама",
        13 => "Король",
        14 => "Туз",
        _ => k.ToString()
    };
    Console.WriteLine($"Карта с номером {k} — это {cardName}.");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"{ex.Message}");
}
finally
{
    Console.WriteLine("Программа завершена");
}



/*3.Напишите программу, которая принимает на входе строку и производит выходные
данные в соответствии со следующей таблицей:*/

Console.WriteLine("Задание 3");

Console.WriteLine("Введите исходную строку:");

string str = Console.ReadLine();

switch (str.ToLower())
{
    case "jabroni": Console.WriteLine("Patron Tequila"); break;
    case "school counselor": Console.WriteLine("Anything with Alcohol"); break;
    case "programmer": Console.WriteLine("Hipster Craft Beer"); break;
    case "bike gang member": Console.WriteLine("Moonshine"); break;
    case "politician": Console.WriteLine("Your tax dollars"); break;
    case "rapper": Console.WriteLine("Cristal"); break;
    default: Console.WriteLine("Beer"); break;

}



/*4.Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,
...,7) выводит на экран его название (понедельник, вторник, ..., воскресенье).
Использовать enum.*/

Console.WriteLine("Задание 4");



try
{
    Console.WriteLine("Введите номер дня недели (1-7):");
    int dayNumber = Convert.ToInt32((Console.ReadLine()));

    if (dayNumber < 1 || dayNumber > 7)
    {
        throw new ArgumentOutOfRangeException("Номер дня недели должен быть от 1 до 7.");
    }

    DaysOfWeek day = (DaysOfWeek)dayNumber;

    Console.WriteLine($"День недели: {day}");
}
catch (FormatException)
{
    Console.WriteLine("Ошибка: Введите корректное число.");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
finally
{
    Console.WriteLine("Программа завершена.");
}





/*5.Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента
"Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е. прибавить к
результату. Вывести на экран сколько кукол в “сумке”*/

Console.WriteLine("Задание 5");

string[] stringsArr = { "Apple", "Hello Kitty", "House", "Hello Kitty", "Friend", "Water", "Family", "Barbie doll" };
int bagDoll = 0;

foreach (string s in stringsArr)
{
    if (s == "Hello Kitty" || s == "Barbie doll")
    {
        bagDoll++;
    }
}

Console.WriteLine($"В сумке {bagDoll} кукол");





enum DaysOfWeek
{
    Понедельник = 1,
    Вторник,
    Среда,
    Четверг,
    Пятница,
    Суббота,
    Воскресенье
}
