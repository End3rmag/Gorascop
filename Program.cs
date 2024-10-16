using Microsoft.VisualBasic;

Console.WriteLine("Введите вашу дату рождения: ");
string Age = Console.ReadLine();

try
{
    string[] toNumb = Age.Split(".");
    foreach (string nums in toNumb)
    {
        Console.WriteLine($"Число: {nums}");
    }

    int date = Convert.ToInt32(toNumb[0]);
    int month = Convert.ToInt32(toNumb[1]);
    int year = Convert.ToInt32(toNumb[2]);

    string[] color = ["Металл", "Вода", "Дерево", "Огонь", "Земля"];
   
    int y = year - 1900;
    while (y >= 10)
    {
        y = y - 10;
    }

    string text = "Ваш знак зодиакака: ";

    switch (month)
    {
        case (01):
            if (date >= 21)
            { Console.WriteLine(text + "Водолей"); }
            else { Console.WriteLine(text + "Козерог"); }
            break;
        case (02):
            if (date >= 21)
            { Console.WriteLine(text + "Рыбы"); }
            else { Console.WriteLine(text + "Водолей"); }
            break;
        case (03):
            if (date >= 21)
            { Console.WriteLine(text + "Овен"); }
            else { Console.WriteLine(text + "Рыбы"); }
            break;
        case (04):
            if (date >= 21)
            { Console.WriteLine(text + "Телец"); }
            else { Console.WriteLine(text + "Овен"); }
            break;
        case (05):
            if (date >= 21)
            { Console.WriteLine(text + "Близнецы"); }
            else { Console.WriteLine(text + "Телец"); }
            break;
        case (06):
            if (date >= 22)
            { Console.WriteLine(text + "Рак"); }
            else { Console.WriteLine(text + "Близнецы"); }
            break;
        case (07):
            if (date >= 23)
            { Console.WriteLine(text + "Лев"); }
            else { Console.WriteLine(text + "Рак"); }
            break;
        case (08):
            if (date >= 24)
            { Console.WriteLine(text + "Дева"); }
            else { Console.WriteLine(text + "Лев"); }
            break;
        case (09):
            if (date >= 24)
            { Console.WriteLine(text + "Весы"); }
            else { Console.WriteLine(text + "Дева"); }
            break;
        case (10):
            if (date >= 24)
            { Console.WriteLine(text + "Скорпион"); }
            else { Console.WriteLine(text + "Весы"); }
            break;
        case (11):
            if (date >= 23)
            { Console.WriteLine(text + "Стрелец"); }
            else { Console.WriteLine(text + "Скорпион"); }
            break;
        case (12):
            if (date >= 22)
            { Console.WriteLine(text + "Козерог"); }
            else { Console.WriteLine(text + "Стрелец"); }
            break;
    }

    string textYears = "Вы родились в год: ";
    switch (year % 12) 
    {
        case 0:
            Console.WriteLine(textYears + "Обезьяна");
            break;
        case 1:
            Console.WriteLine(textYears + "Петух");
            break;
        case 2:
            Console.WriteLine(textYears + "Собака");
            break;
        case 3:
            Console.WriteLine(textYears + "Свинья");
            break;
        case 4:
            Console.WriteLine(textYears + "Крыса");
            break;
        case 5:
            Console.WriteLine(textYears + "Бык");
            break;
        case 6:
            Console.WriteLine(textYears + "Тигр");
            break;
        case 7:
            Console.WriteLine(textYears + "Кролик");
            break;
        case 8:
            Console.WriteLine(textYears + "Дракон");
            break;
        case 9:
            Console.WriteLine(textYears + "Змея");
            break;
        case 10:
            Console.WriteLine(textYears + "Лошадь");
            break;
        case 11:
            Console.WriteLine(textYears + "Овца");
            break;

    }

    Console.WriteLine("Ваша стихия: ");
    if (y > 4)
    {
        y = y / 2;
        string col = color[y];
        Console.WriteLine(col);
    }
    else 
    {
        string col = color[y];
        Console.WriteLine(col);
    }


}
catch (Exception e) { Console.WriteLine("Некорректно введены данные, введите в формате дд.мм.гггг");}

Console.ReadKey();