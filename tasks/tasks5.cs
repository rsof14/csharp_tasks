
//5.1
static void ConcatStrings(ref string first_text, params string[] symbols)
{
    foreach (string symbol in symbols)
    {
        first_text += symbol;
    }
    Console.WriteLine(first_text);
}

//5.2
static void MaxMin(params int[] numbers)
{
    int max = numbers[0];
    int min = numbers[0];
    foreach (int numb in numbers)
    {
        if (numb > max) { max = numb; };
        if (numb < min) { min = numb; };
    }
    int[] max_min = { max, min };
    Console.WriteLine("Максимальное значение: {0}, Минимальное значение: {1}", max_min[0], max_min[1]);
}

//5.3
static void DoubleFact(int numb)
{
    int fact = 1;
    for (int i = (numb + 1) % 2 + 1; i <= numb; i += 2)
    {
        fact *= i;
    }
    Console.WriteLine(fact);
}

//5.4
// Сортировка и фильтрация студентов по рейтингу
static void Students()
{
    var students_rating = new Dictionary<string, double>()
    {
        {"Tom", 4.3},
        {"Julia", 5.0},
        {"Bob", 3.1},
        {"Denis", 4.8},
        {"Maria", 4.0},
        {"Karen", 3.9}
    };
    var sortedStudents = from item in students_rating orderby item.Value descending select item;
    Console.WriteLine("Рейтинг студентов в порядке убывания");
    Console.WriteLine(String.Join(", ", sortedStudents));
    var selectedStudents = from p in students_rating
                           where p.Value >= 4.0
                           orderby p.Value descending
                           select p;
    Console.WriteLine("Студенты с рейтингом от 4.0");
    Console.WriteLine(String.Join(", ", selectedStudents));
}



string first_string = "one";
ConcatStrings(ref first_string, " ", "two", " ", "three");
Console.WriteLine(first_string);
MaxMin(1, 2, -5, 2, 0, 1);
DoubleFact(10);
Students();


