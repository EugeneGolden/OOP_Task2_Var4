using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
В класс Rectangle добавить:
a. Свойства:
позволяющие получить-установить длины сторон прямоугольника (доступные для чтения и записи);
позволяющее установить, является ли данный прямоугольник квадратом (доступное только для чтения).
b. Индексатор, позволяющий по индексу 0 обращаться к полю a, по индексу 1 – к полю b, 
при других значениях индекса выдается сообщение об ошибке.
*/

namespace OOP_Task1_Var4
{
    class Rectangle
    {
        private double a, b;

        public Rectangle(double squareSide)
        {
            a = squareSide;
            b = squareSide;
        }

        public Rectangle(double length, double width)
        {
            a = length;
            b = width;
        }

        public double length
        {
            get { return a; }
            set { a = value; }
        }

        public double width
        {
            get { return b; }
            set { b = value; }
        }

        //Свойство для чтения - является ли данный прямоугольник квадратом 
        public bool IsSquare
        {
            get { return a == b; }
        }

        public void Print()
        {
            Console.WriteLine("Length = " + a);
            Console.WriteLine("Width = " + b);
        }

        public double Perimeter()
        {
            return 2 * a + 2 * b;
        }

        public double Square()
        {
            return a * b;
        }

        public double this[int i]
        {
            get
            {
                if (i == 0)
                {
                    return a;
                }
                else if (i == 1)
                {
                    return b;
                }
                else
                {
                    Console.WriteLine("Неверный индекс {0}", i);
                    return -1;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double a = 5;
            Rectangle rec1 = new Rectangle(a);
            rec1.Print();
            Console.WriteLine("Периметр равен " + rec1.Perimeter());
            Console.WriteLine("Площадь равна " + rec1.Square());
            Console.WriteLine();

            a = 7;
            double b = 8;
            Rectangle rec2 = new Rectangle(a, b);
            rec2.Print();
            Console.WriteLine("Периметр равен " + rec2.Perimeter());
            Console.WriteLine("Площадь равна " + rec2.Square());
            Console.WriteLine();

            Console.WriteLine("Назначим новые длину и ширину для прямоугольника:");
            rec2.length = 2;
            rec2.width = 3;
            rec2.Print();
            Console.WriteLine();

            Console.WriteLine(rec1.IsSquare);
            Console.WriteLine(rec2.IsSquare);
            Console.WriteLine();


            Console.WriteLine("Используя индексатор, узнаем ширину прямоугольника: ");
            Console.WriteLine(rec2[1]);
            Console.ReadKey();
        }
    }
}