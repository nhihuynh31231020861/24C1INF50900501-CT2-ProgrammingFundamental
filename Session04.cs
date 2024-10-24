using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04
{
    internal class Session04
    {
        public static void Main(string[] args)
        {
            //baitap02_slide9();
            //baitap03_slide9();
            //baitap05_slide9();
            //baitap01_slide22();
            //baitap02_slide22();
            //baitap03_slide22();
            //baitap04_slide22();
            //baitap05a_slide22();
            //baitap05b_slide22();
            //baitap05c_slide22();
            //baitap06_slide22();
            //baitap07_slide22();
            baitap08_slide22();
        }
        static void baitap02_slide9()
        {
            int x;
            Console.WriteLine("Bieu thuc: x = y^2 + 2y + 1");
            for (int y = -5; y <= 5; y++)
            {
                x = y * y + 2 * y + 1;
                Console.WriteLine($"y = {y}; x = {y}^2 + 2{y} + 1 = {x}");
            }
        }
        static void baitap03_slide9()
        {
            Console.WriteLine("Nhap do dai quang duong (km):");
            float km = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap khoang thoi gian (gio):");
            float hour = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap khoang thoi gian (phut):");
            float minute = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap khoang thoi gian (giay):");
            float second = Convert.ToSingle(Console.ReadLine());

            float km_hour = km / (hour + minute / 60.0f + second / 3600.0f);
            float m_h = km_hour / 1.609f;
            Console.WriteLine($"km/h = {km_hour}");
            Console.WriteLine($"m/h = {m_h}");
        }
        static void baitap05_slide9()
        {
            char symbol;
            Console.WriteLine("Nhap 1 ky tu:");
            symbol = Convert.ToChar(Console.ReadLine());
            if (symbol == 'a' || symbol == 'e' || symbol == 'o' || symbol == 'i' || symbol == 'u')
            {
                Console.WriteLine("Day la nguyen am");
            }
            else if (symbol >= '0' || symbol <= '9')
            {
                Console.WriteLine("Day la so");
            }
            else
            {
                Console.WriteLine("Day la ky tu khac");
            }
        }
        static void baitap01_slide22()
        {
            Console.WriteLine("Nhap so do 3 canh cua tam giac: ");
            int a = Convert.ToChar(Console.ReadLine());
            int b = Convert.ToChar(Console.ReadLine());
            int c = Convert.ToChar(Console.ReadLine());
            if (a + b < c && b + c < a && a + c < b)
                Console.WriteLine("3 so do vua nhap khong phai 3 canh cua tam giac");
            else if (a < 0 || b < 0 || c < 0)
                Console.WriteLine("3 canh khong hop le");
            else if (a + b == c || b + c == a || a + c == b)
                Console.WriteLine("3 canh vua nhap la 1 duong thang");
            else if (a == b && b == c)
                Console.WriteLine("Tam giac deu");
            else if (a == b || b == c || a == c)
                Console.WriteLine("Tam giac can");
            else if (a * a + b * b == c * c || b * b + c * c == a * a || a * a + c * c == b * b)
                Console.WriteLine("Tam giac vuong");
            else
                Console.WriteLine("Tam giac thuong");
        }
        static void baitap02_slide22()
        {
            int sum = 0;
            Console.WriteLine("Nhap 10 so");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Nhap so thu {i + 1}: ");
                int a = Convert.ToInt32(Console.ReadLine());
                sum += a;
            }
            double average = sum / 10.0;
            Console.WriteLine($"Tong 10 so la: {sum}");
            Console.WriteLine($"Trung binh cong 10 so la: {average}");
        }
        static void baitap03_slide22()
        {
            Console.Write("Nhap 1 so nguyen: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Bang cuu chuong {a}");
            for (int i = 1; i < 11; i++)
            {
                int n = a * i;
                Console.WriteLine($"{a} * {i} = {n}");
            }
        }
        static void baitap04_slide22()
        {
            Console.Write("Nhap so dong: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }
        static void baitap05a_slide22()
        {
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }
        static void baitap05b_slide22()
        {
            int n = 4;
            int a = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(a + " ");
                    ++a;
                }
                Console.WriteLine();
            }
        }
        static void baitap05c_slide22()
        {
            int n = 4;
            int a = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(a + " ");
                    ++a;
                }
                Console.WriteLine();
            }
        }
        static void baitap06_slide22()
        {
            double sum = 0.0;
            Console.WriteLine("Nhap so n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i < n)
                {
                    Console.Write($"1/{i} + ");
                    sum += 1 / (float)i;
                }
                if (i == n)
                {
                    sum += 1 / (float)i;
                    Console.WriteLine($"1/{i} ");
                }
            }
            Console.WriteLine($"Tong cua day la: {sum}");
        }
        static void baitap07_slide22()
        {
            int n, sum;
            Console.WriteLine("Nhap gioi han pham vi la so nguyen duong a va b : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                n = 1;
                sum = 0;
                while (n < i)
                {
                    if (i % n == 0) sum = sum + n;
                    n++;
                }
                if (sum == i) Console.WriteLine($"So {i} la so hoan hao");
            }
        }
        static void baitap08_slide22()
        {
            int a = 0;
            Console.Write("Nhap so nguyen duong n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    a++;
                    Console.WriteLine($"{n} khong phai so nguyen to");
                    break;
                }
            }
            if (a == 0 && n != 1) Console.WriteLine($"{n} la so nguyen to");
        }
    }
}


   
