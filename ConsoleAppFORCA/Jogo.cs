namespace ConsoleAppFORCA;

public class Jogo
{
    private int rightLetters = 0;
    private string randomWord;

    string[] lista =
    {
        "Matrix",
        "Batman", "Brasil", "Gato", "Homem"
    };


    public void comecar()
    {
        Console.WriteLine("Bem Vindo ao Jogo da Forca!!!!!!!!!!");
        Random rd = new Random();
        int rand = rd.Next(0, 4);
        randomWord = lista[rand];

    }

    private static int printWord(List<char> guessedLetters, String randomWord)
    {

        int contador = 0;
        int rightLetters = 0;
        Console.Write("\r\n");
        foreach (char c in randomWord)
        {
            if (guessedLetters.Contains(c))
            {
                Console.Write(c + " ");
                rightLetters += 1;
            }
            else
            {
                Console.Write("  ");
            }

            contador += 1;
        }
        
        return rightLetters;
    }

    
    
    
    private static void sublinhas(String randomWord)
    {
        
        foreach (char c in randomWord)
        {
            Console.Write("_ ");
        }
    }

    
    
    
    public void jogando()
    {
        foreach (char x in randomWord)
        {
            Console.Write("_ ");
        }

        int lengthOfRandomWord = randomWord.Length;
        int amountOfTimesWrong = 0;
        List<char> currentLettersGuessed = new List<char>();
        int currentLettersRight = 0;

        while (amountOfTimesWrong != 6 && currentLettersRight != lengthOfRandomWord)
        {
            Console.Write("\nLetters guessed so far: ");
            foreach (char letter in currentLettersGuessed)
            {
                Console.Write(letter + " ");
            }

            Console.Write("\nGuess a letter: ");
            char letterGuessed = Console.ReadLine()[0];

            if (currentLettersGuessed.Contains(letterGuessed))
            {
                Console.Write("\r\n You have already guessed this letter");
                printwrong(amountOfTimesWrong);
                currentLettersRight = printWord(currentLettersGuessed, randomWord);
                sublinhas(randomWord);
            }
            else
            {
                bool right = false;
                for (int i = 0; i < randomWord.Length; i++)
                {
                    if (letterGuessed == randomWord[i])
                    {
                        right = true;
                    }
                }

                if (right)
                {
                    printwrong(amountOfTimesWrong);
                    currentLettersGuessed.Add(letterGuessed);
                    currentLettersRight = printWord(currentLettersGuessed, randomWord);
                    Console.Write("\r\n");
                    sublinhas(randomWord);
                }else
                {
                    amountOfTimesWrong += 1;
                    currentLettersGuessed.Add(letterGuessed);
                    printwrong(amountOfTimesWrong);
                    currentLettersRight = printWord(currentLettersGuessed, randomWord);
                    Console.Write("\r\n");
                    sublinhas(randomWord);
                }

            }


        }

    }

    private void printwrong(int wrong)
    {
        switch (wrong)
        {
            case 1:
                Console.WriteLine("\n1 errada");
                break;

            case 2:
                Console.WriteLine("\n2 erradas");
                break;
            case 3:
                Console.WriteLine("\n3 erradas");
                break;
            case 4:
                Console.WriteLine("\n4 erradas");
                break;
            case 5:
                Console.WriteLine("\n5 erradas");
                break;
            case 6:
                Console.WriteLine("\n6 erradas");
                break;
            
        }
    }
}


    
    

