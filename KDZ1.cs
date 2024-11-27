using System;

class KDZ1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите режим игры:");
        Console.WriteLine("1. Игрок против игрока");
        Console.WriteLine("2. Игрок против компьютера");
        int mode = int.Parse(Console.ReadLine());

        if (mode == 1)
        {
            PlayerVsPlayer();
        }
        else if (mode == 2)
        {
            PlayerVsComputer();
        }
        else
        {
            Console.WriteLine("Неправильный ввод.");
        }
    }

    static void PlayerVsPlayer()
    {
        Console.WriteLine("ИГРОК 1: Введите загаданное четырехзначное число:");
        string secret = Console.ReadLine();

        while (secret.Length != 4 || !IsUniqueDigits(secret))
        {
            Console.WriteLine("Введите корректное число (четырехзначное, все цифры должны быть разными):");
            secret = Console.ReadLine();
        }

        string guess;
        int bulls, cows;

        do
        {
            Console.WriteLine("ИГРОК 2: Введите Вашу попытку:");
            guess = Console.ReadLine();
            (bulls, cows) = GetBullsAndCows(secret, guess);
            Console.WriteLine($"{bulls} быков и {cows} коров");
        } while (bulls < 4);

        Console.WriteLine("Поздравляем! Вы угадали число.");
    }

    static void PlayerVsComputer()
    {
        Console.WriteLine("Введите загаданное четырехзначное число:");
        string secret = Console.ReadLine();

        while (secret.Length != 4 || !IsUniqueDigits(secret))
        {
            Console.WriteLine("Введите корректное число (четырехзначное, все цифры должны быть разными):");
            secret = Console.ReadLine();
        }

        Random rand = new Random();
        string guess = GenerateGuess(rand);
        int bulls, cows;

        do
        {
            Console.WriteLine($"Компьютер угадывает: {guess}");
            (bulls, cows) = GetBullsAndCows(secret, guess);
            Console.WriteLine($"{bulls} быков и {cows} коров");

            if (bulls < 4)
            {
                guess = GenerateGuess(rand);
            }
        } while (bulls < 4);

        Console.WriteLine("Компьютер угадал число!");
    }

    static (int bulls, int cows) GetBullsAndCows(string secret, string guess)
    {
        int bulls = 0, cows = 0;
        bool[] secretChecked = new bool[4];
        bool[] guessChecked = new bool[4];

        //Подсчет быков
        for (int i = 0; i < 4; i++)
        {
            if (secret[i] == guess[i])
            {
                bulls++;
                secretChecked[i] = true;
                guessChecked[i] = true;
            }
        }

        // Подсчет коров
        for (int i = 0; i < 4; i++)
        {
            if (!guessChecked[i])
            {
                for (int j = 0; j < 4; j++)
                {
                    if (!secretChecked[j] && guess[i] == secret[j])
                    {
                        cows++;
                        secretChecked[j] = true;
                        break;
                    }
                }
            }
        }

        return (bulls, cows);
    }

    static bool IsUniqueDigits(string number)
    {
        return number.Length == 4 && number.Distinct().Count() == 4 && number.All(char.IsDigit);
    }

    static string GenerateGuess(Random rand)
    {
        int[] digits = new int[4];
        for (int i = 0; i < 4; i++)
        {
            digits[i] = rand.Next(0, 10);
            // Проверка на уникальность
            while (Array.IndexOf(digits, digits[i], 0, i) != -1)
            {
                digits[i] = rand.Next(0, 10);
            }
        }
        return string.Join("", digits);
    }
}