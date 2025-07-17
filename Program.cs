namespace ConsoleApps;

    public class program
{
    public static void Main()
    {
        int secretNum = 7;
        int userNum = 0;

        Console.WriteLine("-----DESCUBRA O NÚMERO SECRETO-----");

        while (userNum != secretNum)
        {
            Console.WriteLine("-----CHUTE UM NÚMERO DE 0 A 7");
            userNum = Convert.ToInt32(Console.ReadLine());

            if (userNum < secretNum)
                Console.WriteLine("Muito baixo, chute um valor mais alto");
            else if (userNum > secretNum)
                Console.WriteLine("Muito alto, chute um valor mais baixo");
            else
                Console.WriteLine("Parabéns, acertou o número secreto!");

        }//Closing while
    }//Closing class
}//Closing program
