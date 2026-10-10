// //задание 1
// int lessonNumber = 5;
// int totalLessons = 1;

// while (lessonNumber >= totalLessons) {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber--;
// }

// Console.WriteLine("Пары закончились");

// //задание 2
Console.WriteLine("Вводите оценки по одной, для завершения введите −1:");
int grade = int.Parse(Console.ReadLine());
int count = 0;

while (grade != -1) {
    Console.WriteLine($"Оценка принята: {grade}");
    count++;
    grade = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Всего введено оценок: {count}");
Console.WriteLine("Ввод завершён");