using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_and_WPF_9.Classes;

namespace Classes_and_WPF_9
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №9");
            Console.WriteLine("Введите номер задания от 1 до 30:");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            switch (taskNumber)
            {
                case 1:

                    Console.WriteLine("Введите целое число А (А < B)");
                    int A1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите целое число B (B > A)");
                    int B1 = int.Parse(Console.ReadLine());

                    Class1 class1 = new Class1(A1, B1);
                    List<int> numbers1 = class1.GetNumber();

                    Console.WriteLine($"Числа от А то В: ");
                    Console.WriteLine(class1.G2());

                    Console.WriteLine(class1.G1());

                    break;

                case 2:

                    Console.WriteLine("Введите целое число А (А < B)");
                    int A2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите целое число B (B > A)");
                    int B2 = int.Parse(Console.ReadLine());

                    Class2 class2 = new Class2(A2, B2);

                    Console.WriteLine($"Числа от А то В: ");

                    Console.WriteLine(class2.G2());


                    Console.WriteLine(class2.G1());

                    break;

                case 3:

                    Console.WriteLine("Введите вещественное число А");
                    double A3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите целое число N (N > 0)");
                    int N3 = int.Parse(Console.ReadLine());

                    Class3 class3 = new Class3(A3, N3);

                    Console.WriteLine("Число А перемножается само насебя N раз:");

                    Console.WriteLine(class3.G2());

                    Console.WriteLine(class3.G1());

                    break;
                case 4:
                    Console.WriteLine("Введите вещественное число А");
                    double A4 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите целое число N (N > 0)");
                    int N4 = int.Parse(Console.ReadLine());

                    Class4 class4 = new Class4(A4, N4);

                    Console.WriteLine("Число А перемножается само насебя N раз:");

                    Console.WriteLine(class4.G2());


                    break;

                case 5:
                    Console.WriteLine("Введите вещественное число А");
                    long A5 = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Введите целое число N (N > 0)");
                    int N5 = int.Parse(Console.ReadLine());

                    Class5 class5 = new Class5(A5, N5);

                    Console.WriteLine("Число А перемножается само насебя N раз:");

                    Console.WriteLine(class5.G3());

                    Console.Write($"Сумма чисел {class5.G2()} равно {class5.G()}");

                    break;

                case 6:

                    Console.WriteLine("Введите значение N (N > 1):");
                    int N6 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите значение M (M > 1):");
                    int M6 = int.Parse(Console.ReadLine());

                    Class6 class6 = new Class6(N6, M6);

                    Console.WriteLine($"Наименьшее целое K, при котором выполняется 3K ({class6.G1() * 3}) > N ({N6}): {class6.G1()}");

                    break;
                case 7:

                    Console.WriteLine("Введите значение N (N > 1):");
                    int N7 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите значение M (M > 1):");
                    int K7 = int.Parse(Console.ReadLine());

                    Class7 class7 = new Class7(N7, K7);

                    Console.WriteLine($"Наибольшее целое K, при котором выполняется 3K < N: {class7.G1()}");

                    break;
                case 8:
                    Console.WriteLine("Введите значение N (N > 1):");
                    int A8 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите значение M (M > 1):");
                    int N8 = int.Parse(Console.ReadLine());

                    Class8 class8 = new Class8(A8, N8);

                    Console.WriteLine($" {class8.G1()}");
                    break;
                case 9:
                    Console.Write("Введите целое число N (> 0): ");
                    int n9 = Convert.ToInt32(Console.ReadLine());

                    try
                    {
                        Class9 class9 = new Class9(n9);
                        Console.WriteLine(class9.G1());
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 10:
                    Console.Write("Введите целое число N (> 0): ");
                    int n10 = Convert.ToInt32(Console.ReadLine());

                    try
                    {
                        Class10 class10 = new Class10(n10);
                        Console.WriteLine(class10.G1());
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 11:
                    Console.WriteLine("Введите значение: Х");
                    double x11 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите значение:N (> 0)");
                    int n11 = int.Parse(Console.ReadLine());

                    Class11 class11 = new Class11(x11, n11);

                    Console.WriteLine($"Значениe выражения равно:{class11.G1()}");
                    break;
                case 12:
                    Console.WriteLine("Введите значение: Х");
                    double x12 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите значение:N (> 0)");
                    int n12 = int.Parse(Console.ReadLine());

                    Class12 class12 = new Class12(x12, n12);

                    Console.WriteLine($"Значениe выражения равно:{class12.G1()}");
                    break;
                case 13:
                    Console.WriteLine("Введите значение: Х");
                    double x13 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите значение:N (> 0)");
                    int n13 = int.Parse(Console.ReadLine());

                    Class13 class13 = new Class13(x13, n13);

                    Console.WriteLine($"Значениe выражения равно:{class13.G1()}");
                    break;
                case 14:
                    Console.WriteLine("Введите значение: Х (|X|>1)");
                    double x14 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите значение:N (> 0)");
                    int n14 = int.Parse(Console.ReadLine());

                    Class14 class14 = new Class14(x14, n14);

                    Console.WriteLine($"Значениe выражения равно:{class14.G1()}");
                    break;
                case 15:
                    Console.WriteLine("Введите значение: Х (|X|>1)");
                    double x15 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите значение:N (> 0)");
                    int n15 = int.Parse(Console.ReadLine());

                    Class15 class15 = new Class15(x15, n15);

                    Console.WriteLine($"Значениe выражения равно:{class15.G1()}");
                    break;
                case 16:
                    // Ввод данных
                    Console.Write("Введите целое число N (> 2): ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Введите вещественное число A: ");
                    double a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите вещественное число B (B > A): ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Class16 class16 = new Class16(n, a, b);

                    Console.WriteLine("Точки разбиения:");
                    class16.G1().ForEach(number => Console.WriteLine(number));
                    break;
                case 17:
                    // Ввод данных
                    Console.Write("Введите целое число N (> 2): ");
                    int n17 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Введите вещественное число A: ");
                    double a17 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите вещественное число B (B > A): ");
                    double b17 = Convert.ToDouble(Console.ReadLine());

                    // Создаем объект класса Class17
                    Class17 class17 = new Class17(n17, a17, b17);
                    Console.WriteLine("Значения функции F(X) = 1 - sin(X) в точках разбиения:");
                    class17.G1().ForEach(number => Console.WriteLine(number));
                    break;
                case 18:
                    Console.WriteLine("Введите число D (> 0):");
                    double D18 = double.Parse(Console.ReadLine());

                    Class18 class18 = new Class18(D18);

                    var rezult1 = class18.FindFirstK();

                    Console.WriteLine($"Номер K:{rezult1.K}");
                    Console.WriteLine($"AK-1:{rezult1.AK_1}");
                    Console.WriteLine($"AK:{rezult1.AK}");
                    break;
                case 19:
                    Console.WriteLine("Введите число D (> 0):");
                    double D19 = double.Parse(Console.ReadLine());

                    Class19 class19 = new Class19(D19);

                    var rezult2 = class19.FindFirstK();

                    Console.WriteLine($"Номер K:{rezult2.K}");
                    Console.WriteLine($"AK-1:{rezult2.AK_1}");
                    Console.WriteLine($"AK:{rezult2.AK}");
                    break;
                case 20:
                    Console.WriteLine("Введите число от 10 до N:");
                    int N20 = int.Parse(Console.ReadLine());

                    Class20 class20 = new Class20(N20);

                    Console.WriteLine($"Не чётные кратные пяти числа:{class20.G1()}");
                    break;

                case 21:

                    Class21 class21 = new Class21();
                    class21.G1().ForEach(number => Console.WriteLine(number));

                    break;
                case 22:
                    Console.WriteLine("Введите значение x");
                    double X22 = Convert.ToDouble(Console.ReadLine());
                    Class22 class22 = new Class22(X22);
                    Console.WriteLine($"Ответ:{class22.G1()}");

                    break;

                case 23:
                    Console.WriteLine("Введите значение n");
                    double n23 = Convert.ToDouble(Console.ReadLine());
                    Class23 class23 = new Class23(n23);
                    class23.G1().ForEach(number => Console.WriteLine(number));

                    break;

                case 24:
                    Console.WriteLine("Введите значение n");
                    int n24 = Convert.ToInt32(Console.ReadLine());
                    Class24 class24 = new Class24(n24);
                    Console.WriteLine($"Ответ:{class24.G1()}");
                    break;

                case 25:
                    Console.WriteLine("Введите значение n");
                    int n25 = Convert.ToInt32(Console.ReadLine());
                    Class25 class25 = new Class25(n25);
                    Console.WriteLine("Первые цифры чисел из списка от 10 до N");
                    class25.G1().ForEach(number => Console.WriteLine(number));

                    Console.WriteLine("Cумма цифр чисел из списка от 10 до N");
                    class25.G2().ForEach(number => Console.WriteLine(number));
                    break;

                case 26:
                    Console.WriteLine("Введите значение n");
                    int n26 = Convert.ToInt32(Console.ReadLine());
                    Class26 class26 = new Class26(n26);
                    Console.WriteLine($"Ответ:{class26.G1()}");

                    break;

                case 27:
                    Class27 class27 = new Class27();
                    Console.WriteLine($"Ответ:{class27.G1()}");

                    break;

                case 28:
                    Class28 class28 = new Class28();
                    Console.WriteLine($"Ответ:{class28.G1()}");

                    break;

                case 29:
                    Console.WriteLine("Введите значение n");
                    int n29 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение А");
                    double A29 = Convert.ToDouble(Console.ReadLine());

                    Class29 class29 = new Class29(n29, A29);
                    class29.G1().ForEach(number => Console.WriteLine(number));

                    break;

                case 30:
                    Console.WriteLine("Введите значение n");
                    int n30 = Convert.ToInt32(Console.ReadLine());
                    Class30 class30 = new Class30(n30);
                    Console.WriteLine($"Ответ:{class30.G1()}");
                    break;
            }
        }
    }
}
