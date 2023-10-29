using Homework8;

Triangle triangle1 = new Triangle(6,7,8);
Triangle triangle2 = new Triangle(3, 4, 5);

////8.2
//if (triangle1 == triangle2)
//{
//    Console.WriteLine("triangle1 equals triangle2");
//}
//else
//{
//    Console.WriteLine("they are not equals each ather");
//}

////8.3
//if (triangle1 > triangle2)
//{
//    Console.WriteLine("triangle1's  is Greater than triangle2");
//}
//else if (triangle1 < triangle2)
//{
//    Console.WriteLine("triangle1 is less than triangle2");
//}
//else
//{
//    Console.WriteLine("they are equals each other");
//}

////8.4
//Triangle sumTriangle = triangle1 + triangle2;
//Console.WriteLine($"new Triangle's area equals {sumTriangle.GetArea()}");


//8.6
double sideA = 10;
EquirateralTriangle equirateral = (EquirateralTriangle)sideA;
Console.WriteLine($"Area eqauals: {equirateral.GetPerimeter()}");