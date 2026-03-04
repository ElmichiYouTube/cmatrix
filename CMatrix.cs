// Proyecto creado por ElmichiYT en C#
// Compilado en C# 5
// Canal del creador: https://www.youtube.com/@El_michiYouTube

using System;
using System.Threading;

class MatrixCompacta
{
    static void Main()
    {
        int width = 100;
        int height = 30;

        try 
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(width, height);
            Console.SetWindowSize(width, height);
        } 
        catch 
        {
            width = Console.WindowWidth;
            height = Console.WindowHeight;
        }

        Console.CursorVisible = false;
        Console.Title = "CMatrix - Hecho por ElmichiYT";
        
        int[] y = new int[width];
        Random rand = new Random();

        for (int i = 0; i < width; i++) 
        {
            y[i] = rand.Next(height);
        }

        while (true)
        {
            for (int x = 0; x < width; x++)
            {
                // Cabeza blanca
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(x, y[x]);
                Console.Write(GetChar(rand));

                // Estela verde
                int tail = (y[x] - 1 + height) % height;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(x, tail);
                Console.Write(GetChar(rand));

                // Limpieza
                int erase = (y[x] - 8 + height) % height;
                Console.SetCursorPosition(x, erase);
                Console.Write(' ');

                y[x] = (y[x] + 1) % height;
            }
            Thread.Sleep(0);
        }
    }

    // Cambiado a formato tradicional
    static char GetChar(Random r) 
    {
        return (char)r.Next(33, 126);
    }
}