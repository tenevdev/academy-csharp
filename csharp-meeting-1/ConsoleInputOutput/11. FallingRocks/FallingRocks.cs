using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class FallingRocks
{
    private enum AllowedDirections
    {
        Left = 0,
        Right = 1
    }

    //^, @, *, &, +, %, $, #, !, ., ;, -
    private static char[] rockSymbols = new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ',', '-' };

    const int LINE_LENGTH = 20, LINES = 10;

    private static string dwarf = "(0)";
    private static int dwarfPosition = LINE_LENGTH / 2 - 1; // the left part of the dwarf
    private static bool isAlive = true;

    private static List<string> lines;

    private static Stopwatch watch = new Stopwatch();
    private static long highScore = 0;

    private const string SONG_NAME = "POA.wav";
    private static SoundPlayer player = new SoundPlayer(SONG_NAME);

    private static string GenerateRocksLine(int length = 20)
    {
        string line = new string(' ', length);
        StringBuilder builder = new StringBuilder(line);
        Random random = new Random();
        int rocksCount = random.Next(length / 15, length / 8);
        int typeOfRock, rockPosition;
        for (int i = 0; i < rocksCount; i++)
        {
            typeOfRock = random.Next(0, rockSymbols.Length - 1);
            rockPosition = random.Next(0, length - 1);
            builder.Insert(rockPosition, rockSymbols[typeOfRock]);
        }

        return builder.ToString();
    }

    private static void RenderField()
    {
        Console.Clear();

        lines.RemoveAt(lines.Count - 1);
        lines.Insert(0, GenerateRocksLine());

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        Console.SetCursorPosition(dwarfPosition, LINES - 1);
        Console.Write(dwarf);

        Console.SetCursorPosition(5, LINES + 2);
        Console.WriteLine("SCORE : {0}", watch.ElapsedMilliseconds);
    }

    private static void SetupLines(int linesCount, int lineLength)
    {
        lines = new List<string>(linesCount);

        for (int i = 0; i < linesCount; i++)
        {
            lines.Add(new string(' ', lineLength));
        }
    }

    private static void MoveDwarf(AllowedDirections direction)
    {
        switch (direction)
        {
            case AllowedDirections.Left:
                if (dwarfPosition > 0)
                {
                    dwarfPosition -= 1;
                }
                break;
            case AllowedDirections.Right:
                if (dwarfPosition + 2 < LINE_LENGTH)
                {
                    dwarfPosition += 1;
                }
                break;
            default:
                break;
        }
    }

    private static bool CheckCollision()
    {
        string bottomLine = lines.Last();
        for (int i = dwarfPosition; i < dwarfPosition + 3; i++)
        {
            if (bottomLine[i] != ' ')
            {
                return true;
            }
        }
        return false;
    }

    private static void ControlDwarf()
    {
        ConsoleKeyInfo keyInfo;

        while (isAlive)
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        MoveDwarf(AllowedDirections.Left);
                        break;
                    case ConsoleKey.RightArrow:
                        MoveDwarf(AllowedDirections.Right);
                        break;
                    default:
                        break;
                }
            }
        }
    }

    private static void Play()
    {
        StartGame();

        Task controlDwarfTask = new Task(new Action(ControlDwarf));
        controlDwarfTask.Start();

        while (isAlive)
        {
            Thread.Sleep(150);
            RenderField();
            isAlive = !CheckCollision();
        }

        EndGame();
    }

    private static void ResetGame()
    {
        watch.Reset();
        dwarfPosition = LINE_LENGTH / 2 - 1;
        isAlive = true;
    }

    private static void EndGame()
    {
        if (watch.ElapsedMilliseconds > highScore)
        {
            highScore = watch.ElapsedMilliseconds;
        }
        watch.Stop();
        player.Stop();
        Console.Clear();
        DisplayEndGameMessage();


    }

    private static void StartGame()
    {
        ResetGame();

        player.PlayLooping();

        SetupLines(LINES, LINE_LENGTH);
        RenderField();

        watch.Start();
    }

    private static void DisplayGameMessage()
    {
        Console.WriteLine("Press p to start game");
    }

    private static void DisplayEndGameMessage()
    {
        Console.WriteLine("GAME OVER");
        Console.WriteLine();
        Console.WriteLine("Your score is : {0}", watch.ElapsedMilliseconds);
        Console.WriteLine("High score : {0}", highScore);
        Console.WriteLine();
        Console.WriteLine("Press p to start game");
    }

    static void Main(string[] args)
    {
        char command = ' ';
        Console.CursorVisible = false;

        DisplayGameMessage();

        while (command != 'q' || command != 'Q')
        {
            command = Console.ReadKey(true).KeyChar;
            switch (command)
            {
                case 'p':
                case 'P':
                    {
                        Play();
                    }
                    break;
                default:
                    break;
            }


        }
    }
}
