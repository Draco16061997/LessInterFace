//Интерфейс для устройств
//Цель: Создать интерфейс IDevice, который будет определять основные методы для работы с различными устройствами (например, включение, выключение).

//Требования:

//Интерфейс IDevice должен содержать методы TurnOn() и TurnOff().
//Создайте классы Smartphone и Laptop, реализующие интерфейс IDevice.
////В методах TurnOn() и TurnOff() каждого класса выводите сообщение о состоянии устройства (например, "Smartphone turned on").

//Smartphone nokia = new Smartphone();

//nokia.TurnOn();

//Laptop lenive = new Laptop();

//lenive.TurnON();

//interface IDevice
//{
  

//    void TurnOn() => Console.WriteLine("Divace ON!");

//    void TurnOff() => Console.WriteLine("Divace Off");
//}


//class Smartphone : IDevice
//{

//    public void TurnOn() => Console.WriteLine("Smartphone is ON");
//    public void TurnOff() => Console.WriteLine("Smartphone is Off");
//}


//class Laptop : IDevice
//{
//    public void TurnON() => Console.WriteLine("Laptop is ON ");
//    public void TurnOff() => Console.WriteLine("Laptop is OFF");

//}




//Интерфейс для геометрических фигур
//Цель: Разработать интерфейс IGeometricShape, который будет определять методы для вычисления площади и периметра геометрической фигуры.

//Требования:

//Интерфейс IGeometricShape должен содержать методы CalculateArea() и CalculatePerimeter().
//Создайте классы Circle, Rectangle, и Triangle, реализующие интерфейс IGeometricShape.
//В каждом классе реализуйте соответствующие методы для вычисления площади и периметра.


Circle circle = new Circle();
circle.CalculatePerimetr(2.3f);
circle.CalculateArea(3);

Rectangle rectangle = new Rectangle();  
rectangle.CalculateArea(3);
rectangle.CalculatePerimetr(4.54f);

Triangle triangle = new Triangle();
((IGeometricShape)triangle).CalculatePerimetr(3.4f);
((IGeometricShape)triangle).CalculateArea(3);
((IGeometricShape)triangle).CalculateArea(4);
triangle.CalculatePerimetr(3);

interface IGeometricShape
{
    void CalculateArea(float a);

    void CalculatePerimetr(float a);
}


class Circle : IGeometricShape
{
    public void CalculateArea(float radius)
    {
        Console.WriteLine(Math.PI * radius*2);
    }

    public void CalculatePerimetr(float radius)
    {
        Console.WriteLine(2*Math.PI*radius);
    }
}


class Rectangle : IGeometricShape
{
    public void CalculateArea(float a)
    {
        Console.WriteLine(a*a);
    }

    public void CalculatePerimetr(float a)
    {
        Console.WriteLine(a* 4);
    }
    
}

class Triangle : IGeometricShape
{
    void IGeometricShape.CalculateArea(float a)
    {
        Console.WriteLine((Math.Pow(a,2) * Math.Sqrt(a)) / 4);
    }

    void IGeometricShape.CalculatePerimetr(float a)
    {
        Console.WriteLine(a * 3);
    }
    public void CalculatePerimetr(float a) => Console.WriteLine("druga stuka");
}







//Интерфейс для сравнения объектов
//Цель: Разработать интерфейс IComparable, который позволит сравнивать объекты по определенному критерию.

//Требования:

//Интерфейс IComparable должен содержать метод CompareTo(object obj).
//Создайте класс Employee, который реализует интерфейс IComparable. Сравнение должно производиться по зарплате сотрудника.
//Реализуйте метод CompareTo() так, чтобы он возвращал результат сравнения зарплат сотрудников.



//Emploue Vasya = new Emploue { "Vasya", 230000 };


//interface IComparable
//{
//    void ComparableTo(object obj);
//}

//class Emploue : IComparable
//{

//    public string Name {  get; set; }
//    public double Salary {  get; set; }

//    public void ComparableTo(object obj)
//    {
//        Emploue otherEmploue = obj as Emploue;

//        if (this.Salary > otherEmploue.Salary)
//        {
//            Console.WriteLine("my ZP bolshe");

//        }

//        else if (this.Salary < otherEmploue.Salary) { Console.WriteLine("My ZP menshe "); }

//        else { Console.WriteLine("ZP"); }

        
//    }
//}