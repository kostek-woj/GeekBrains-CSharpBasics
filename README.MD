# GeekBrains - GameDev with Unity - C# Basics
## Lesson 6 Homework
- [x] **1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).**

**2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.**
- [x] а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум. Использовать массив (или список) делегатов, в котором хранятся различные функции.
- [x] б) * Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр (с использованием модификатора out).

**3. Переделать программу Пример использования коллекций для решения следующих задач:**
- [x] а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
- [x] б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (* частотный массив);
- [x] в) отсортировать список по возрасту студента;
- [x] г) * отсортировать список по курсу и возрасту студента;
Данные студентов находятся в файле https://d2xzmw6cctk25h.cloudfront.net/asset/3066993/attachment/a7ad5c5a7acb1a1603f0f0fdd3eb3d43.zip

- [x] **4. **Считайте файл различными способами. Смотрите “Пример записи файла различными способами”. Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), строку для StreamReader и массив int для BinaryReader.**

## Lesson 5 Homework
**1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:**
- [x] а) без использования регулярных выражений;
- [x] б) ** с использованием регулярных выражений.

**2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:**
- [x] а) Вывести только те слова сообщения, которые содержат не более n букв.
- [x] б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
- [x] в) Найти самое длинное слово сообщения.
- [x] г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
- [x] д) *** Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.

- [x] **3. * Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Например: badc являются перестановкой abcd.**

**4. * Задача ЕГЭ.
На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
<Фамилия> <Имя> <оценки>,
где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. Пример входной строки: Иванов Петр 4 5 3.**
- [x] Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.

Достаточно решить 2 задачи. Старайтесь разбивать программы на подпрограммы. Переписывайте в начало программы условие и свою фамилию. Все программы сделать в одном решении. Для решения задач используйте неизменяемые строки (string).


## Lesson 4 Homework
**1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. Заполнить случайными числами.**
- [x] Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

**2. Реализуйте задачу 1 в виде статического класса StaticClass**
- [x] а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
- [x] б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
- [x] в) *Добавьте обработку ситуации отсутствия файла на диске.

**3.**
- [x] а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений), метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
- [x] б) ** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
- [x] в) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)

- [x] **4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.**

**5.**
- [x] а) Реализовать библиотеку с классом для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами. Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
- [x] б) * Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
- [x] в) ** Обработать возможные исключительные ситуации при работе с файлами.

Достаточно решить 2 задачи. Старайтесь разбивать программы на подпрограммы. Переписывайте в начало программы условие и свою фамилию. Все программы сделать в одном решении.

## Lesson 3 Homework
**1.**
- [x] а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
- [x] б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
- [x] в) Добавить диалог с использованием switch демонстрирующий работу класса.

**2.**
- [x] С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.

**3. Дроби**
- [x] *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
- [x] * Добавить свойства типа int для доступа к числителю и знаменателю;
- [x] * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
- [x] ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
- [x] *** Добавить упрощение дробей.

Достаточно решить 2 задачи. Все программы сделать в одном решении.

## Lesson 2 Homework
- [x] 1)  Написать метод, возвращающий минимальное из трёх чисел.
- [x] 2)  Написать метод подсчета количества цифр числа.
- [x] 3)  С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
- [x] 4)  Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
- [x] 5A) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
- [x] 5B) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
- [x] 6)  *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
- [x] 7A) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
- [x] 7B) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

Достаточно решить 4 задачи. Разбивайте программы на подпрограммы. Переписывайте в начало программы условие и свою фамилию. Все программы делайте в одном решении.

###### Пунктуация и орфография сохранены
