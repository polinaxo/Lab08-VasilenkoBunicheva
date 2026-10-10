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

// //задание 4

// string correctPassword = "qwerty123";
// int attempts = 0;

// while (true) {
//     Console.Write("Введите пароль от личного кабинета: ");
//     string password = Console.ReadLine();
//     attempts++;

//     if (password == correctPassword) {
//         Console.WriteLine("Доступ разрешён");
//         Console.WriteLine($"Количество неудачных попыток: {attempts - 1}");
//         break;
//     }

//     Console.WriteLine("Неверный пароль, попробуйте снова");
// }

// //задание 5
// string answer;

// do {
//     Console.WriteLine("Введите дату посещения (например, 01.09): ");
//     string date = Console.ReadLine();
//     Console.WriteLine($"Дата добавлена: {date}");

//     Console.WriteLine("Добавить еще одну запись? (да/нет): ");
//     answer = Console.ReadLine();
// } while (answer == "да");

// Console.WriteLine("Дневник сохранен");

// //Самостоятельноe задание А
// int N = 5;
// int i = 1;

// while (i <= 10) {
//     Console.WriteLine($"{N} * {i} = {N * i}");
//     i++;
// }

// //Задание Б
// Console.WriteLine("Введите имена учеников (для завершения введите 'конец'):");
// int count = 0;
// string name = Console.ReadLine();

// while (name != "конец")
// {
//     count++;
//     name = Console.ReadLine();
// }

// Console.WriteLine($"Всего введено имён: {count}");

// //задание В
// int totalPages = 0;
// Console.WriteLine("Введите количество прочитанных страниц за день (для завершения введите -1):");
// int pages = int.Parse(Console.ReadLine());

// while (pages != -1) {
//     totalPages += pages;
//     Console.WriteLine("Введите количество прочитанных страниц за день (для завершения введите -1):");
//     pages = int.Parse(Console.ReadLine());
// }

// Console.WriteLine($"Общее количество прочитанных страниц: {totalPages}");


// //задание Г
// while (true) {
//     Console.Write("Введите целое число: ");
//     if (!int.TryParse(Console.ReadLine(), out int number)) {
//         Console.WriteLine("Ошибка: введите целое число!");
//         continue;
//     }
    
//     if (number % 7 == 0) {
//         Console.WriteLine("Найдено!");
//         break;
//     }
// }

// Console.Write("Введите свою фамилию: "); 
// string surname = Console.ReadLine()!.Trim(); 
 
// if (string.IsNullOrEmpty(surname)) { 
//     Console.WriteLine("Фамилия не введена. Завершение работы."); 
//     return; 
// } 
 
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear); 
 
// var assigned = Enumerable.Range(1, 10) 
//     .OrderBy(_ => rnd.Next()) 
//     .Take(2) 
//     .OrderBy(x => x) 
//     .ToList(); 
 
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// //Буничева №5 и №6
// //№5
// const string correctCode = "1234";
// string enteredCode;

// Console.WriteLine("Добро пожаловать! Введите код домофона:");

// while (true)
// {
//     enteredCode = Console.ReadLine();
    
//     if (enteredCode == correctCode) {
//         Console.WriteLine("Дверь открыта!");
//         break;
//     }
//     else {
//         Console.WriteLine("Неверный код. Попробуйте ещё раз.");
//     }
// }
// //№6
// Console.Write("Введите положительное целое число: ");
// int number = int.Parse(Console.ReadLine());
// int count = 0;

// while (number != 0) {
//     number = number / 10;
//     count++;
// }

// Console.WriteLine($"Количество цифр: {count}");

// //Василенко №1 и №2
// //№1
// Console.Write("Введите начальное число для отсчёта: ");
// int N = int.Parse(Console.ReadLine());

// while (N >= 1) {
//     Console.WriteLine(N);
//     N--;
// }
// Console.WriteLine("Старт!");

// //№2
// int number;
// int sum = 0;

// Console.WriteLine("Введите числа (для завершения введите 0):");

// number = int.Parse(Console.ReadLine());

// while (number != 0) {
//     if (number > 0) {
//         sum += number;
//     }
    
//     number = int.Parse(Console.ReadLine());
// }

// Console.WriteLine($"Сумма положительных чисел: {sum}");

const string CORRECT_PIN = "1234";
decimal totalWithdrawn = 0m;  
int attempts = 3;

Console.WriteLine("Добро пожаловать в банкомат!");

while (attempts > 0) {
    Console.Write("Введите PIN-код: ");
    string pin = Console.ReadLine();
    
    if (pin == CORRECT_PIN) {
        Console.WriteLine("Доступ разрешен. Выполняем операции снятия.");
        decimal amount;
        do {
            Console.Write("Введите сумму для снятия (0 для завершения): ");
            if (!decimal.TryParse(Console.ReadLine(), out amount)) {
                Console.WriteLine("Ошибка: введите число!");
                continue;
            }
            
            if (amount > 0) {
                totalWithdrawn += amount;
                Console.WriteLine($"Снято: {amount:C}");
            }
        } while (amount != 0);
        Console.WriteLine($"Общая сумма снятых средств: {totalWithdrawn:C}");
        break;
    }
    else {
        attempts--;
        Console.WriteLine($"Неверный PIN-код! Осталось попыток: {attempts}");
    }
}

if (attempts == 0) {
    Console.WriteLine("Все попытки исчерпаны. Карта заблокирована!");
}