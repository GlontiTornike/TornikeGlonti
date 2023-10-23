using Homework7;

////Triangle
//Triangle triangle = new Triangle(2, 3, 4);

//double trianglePerimeter = triangle.Perimeter();
//Console.WriteLine("The Perimeter of this Triangle is: " + trianglePerimeter);
//double tirangleArea = triangle.Area();
//Console.WriteLine("The Area of this Triangle is: " + tirangleArea);


////Rectangle
//Rectangle rectangle = new Rectangle(20, 10);

//double rectperimeter = rectangle.Perimeter();
//Console.WriteLine("The Perimeter of this Rectangle is: " + rectperimeter);
//double rectArea = rectangle.Area();
//Console.WriteLine("The Area of this Rectangle is: " + rectArea);


////Circle
//Circle circle = new Circle(4);  

//double circlePerimeter = circle.Perimeter();
//Console.WriteLine("Perimeter of The Circle is: "+circlePerimeter);
//double circleArea =  circle.Area();
//Console.WriteLine("Area of the Circle is: "+ circleArea);

Console.Write("Enter 1 for triangle, 2 for Rectange, 3 for Circle: ");
int figure = int.Parse(Console.ReadLine());

if (figure == 1)
{
    Console.Write("Enter size a: ");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Enter size b: ");
    double b = double.Parse(Console.ReadLine());
    Console.Write("Enter size c: ");
    double c = double.Parse(Console.ReadLine());

    Shape triangle = new Triangle(a, b, c);
    double trianglePerimeter = triangle.Perimeter();
    Console.WriteLine("The Perimeter of this Triangle is: " + trianglePerimeter);
    double tirangleArea = triangle.Area();
    Console.WriteLine("The Area of this Triangle is: " + tirangleArea);


}else if(figure == 2)
{
    Console.Write("Enter size a: ");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Enter size b: ");
    double b = double.Parse(Console.ReadLine());
    Shape rectangle = new Rectangle(a, b);

    double rectperimeter = rectangle.Perimeter();
    Console.WriteLine("The Perimeter of this Rectangle is: " + rectperimeter);
    double rectArea = rectangle.Area();
    Console.WriteLine("The Area of this Rectangle is: " + rectArea);

}else if(figure == 3)
{
    Console.Write("Enter a radius: ");
    double r = double.Parse(Console.ReadLine());
    Shape circle = new Circle(r);

    double circlePerimeter = circle.Perimeter();
    Console.WriteLine("Perimeter of The Circle is: " + circlePerimeter);
    double circleArea = circle.Area();
    Console.WriteLine("Area of the Circle is: " + circleArea);

}else Console.WriteLine("Invalid number, Enter between 1-3");