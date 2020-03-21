using System;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            Dot doti1,doti2,doti3;
            Console.WriteLine("Введите координату x точки A");
            doti1.x=Convert.ToDouble(Checks.CheckSingleDoubleInput());
            Console.WriteLine("Введите координату y точки A");
            doti1.y = Convert.ToDouble(Checks.CheckSingleDoubleInput());
            Console.WriteLine("Введите координату x точки B");
            doti2.x = Convert.ToDouble(Checks.CheckSingleDoubleInput());
            Console.WriteLine("Введите координату y точки B");
            doti2.y = Convert.ToDouble(Checks.CheckSingleDoubleInput());
            Console.WriteLine("Введите координату x точки C");
            doti3.x = Convert.ToDouble(Checks.CheckSingleDoubleInput());
            Console.WriteLine("Введите координату y точки C");
            doti3.y = Convert.ToDouble(Checks.CheckSingleDoubleInput());
            Triangle t= new Triangle (doti1, doti2, doti3);
            if(t.LengthAB+t.LengthBC<=t.LengthAC|| t.LengthAB + t.LengthAC <= t.LengthBC || t.LengthAC + t.LengthBC <= t.LengthAB)
            {
                Console.WriteLine("Полученный треугольник не удовлетворяет неравенству Минковского, работать с ним не получится");
                return;
            }
            while (true)
            {
                Console.WriteLine("Введите 1 вывода координат стороны АВ,2 для вывода координат стороны BC");
                Console.WriteLine("Введите 3 для вывода координат стороны AC,4 для вывода длины АВ");
                Console.WriteLine("Введите 5 для вывода длины ВС,6 для вывода длины АС");
                Console.WriteLine("Введите 7 для вывода угла А, 8 для вывода угла В");
                Console.WriteLine("Введите 9 для вывода угла С, 10 для вывода периметра треугольника");
                Console.WriteLine("Введите 11 для вывода площади треугольника, 12 для вывода радиуса вписанной в треугольник окружности ");
                Console.WriteLine("Введите 13 для вывода радиуса описанной около треугольника окружности, 14 для выхода из программы");
                int a = Convert.ToInt32(Checks.CheckSingleInput());
                switch (a)
                { 
                    case 1: Console.WriteLine("Координата x:{0:0.00}", t.CoordinatesAB.x); Console.WriteLine("Координата y:{0:0.00}", t.CoordinatesAB.y); break;
                    case 2: Console.WriteLine("Координата x:{0:0.00}", t.CoordinatesBC.x); Console.WriteLine("Координата y:{0:0.00}", t.CoordinatesBC.y); break;
                    case 3: Console.WriteLine("Координата x:{0:0.00}", t.CoordinatesAC.x); Console.WriteLine("Координата y:{0:0.00}", t.CoordinatesAC.y); break;
                    case 4: Console.WriteLine("Длина АВ:{0:0.00}", t.LengthAB); break;
                    case 5: Console.WriteLine("Длина ВС:{0:0.00}", t.LengthBC); break;
                    case 6: Console.WriteLine("Длина АС:{0:0.00}", t.LengthAC); break;
                    case 7: Console.WriteLine("Угол А:{0:0.00}", t.AngleA); break;
                    case 8: Console.WriteLine("Угол B:{0:0.00}", t.AngleB); break;
                    case 9: Console.WriteLine("Угол C:{0:0.00}", t.AngleC); break;
                    case 10: Console.WriteLine("Периметр:{0:0.00}", t.Perimetr); break;
                    case 11: Console.WriteLine("Площадь:{0:0.00}", t.Area); break;
                    case 12: Console.WriteLine("Радиус вписанной окружности:{0:0.00}", t.RadiusOfSmallCircle); break;
                    case 13: Console.WriteLine("Радиус описанной окружности:{0:0.00}", t.RadiusOfBigCircle); break;
                    case 14: return;
                    default: break;
                }
            }
        }
    }
}
