// //задание 1
// int lessonNumber = 5;
// int totalLessons = 1;

// while (lessonNumber >= totalLessons) {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber--;
// }

// Console.WriteLine("Пары закончились");

// //задание 2
// Console.WriteLine("Вводите оценки по одной, для завершения введите −1:");
// int grade = int.Parse(Console.ReadLine());
// int count = 0;

// while (grade != -1) {
//     Console.WriteLine($"Оценка принята: {grade}");
//     count++;
//     grade = int.Parse(Console.ReadLine());
// }

// Console.WriteLine($"Всего введено оценок: {count}");
// Console.WriteLine("Ввод завершён");

// //задание 3
// int sum = 0;
// int count = 0;
// int maxGrade = 0;

// Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());
// while (grade != -1) {
//     sum += grade;
//     count++;
//     if (grade > maxGrade) {
//         maxGrade = grade;
//     }
//     grade = int.Parse(Console.ReadLine());
// }

// if (count > 0) {
//     Console.WriteLine($"Средний балл: {(double)sum / count}");
//     Console.WriteLine($"Максимальная оценка: {maxGrade}");
// } else {
//     Console.WriteLine("Оценок не было введено");
// }

//задание 4

string correctPassword = "qwerty123";
int attempts = 0;

while (true) {
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();
    attempts++;

    if (password == correctPassword) {
        Console.WriteLine("Доступ разрешён");
        Console.WriteLine($"Количество неудачных попыток: {attempts - 1}");
        break;
    }

    Console.WriteLine("Неверный пароль, попробуйте снова");
}