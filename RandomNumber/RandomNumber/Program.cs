int i = 0;
Random random = new Random();
int randNum = random.Next(1, 10);

while (i < 3){
    
    if (int.TryParse(Console.ReadLine(), out int num)){
        i++;
        if (randNum == num)
        {
            Console.WriteLine(" Great, Correct number is " + randNum + " and you win");
            break;
        }else if(randNum != num)
        {
            Console.WriteLine("Try Again");
        }
    }
    else
    {
        Console.WriteLine("Invalid, Enter Number between 1-10:");
    }
    if (i >= 3)
    {
        Console.WriteLine("Correct Number was " + randNum + " You Lost");
    }

}




Console.ReadKey();