﻿class Program
{
    static void Main(string[] args) {
        PrintMenuScreen();
        Input();
    }
    static void PrintMenuScreen() {
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("       Insert ( J,G,O,R ) or other letter to finish          ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    }
    static void Input() {
        CircularLinkedList<char> l = new CircularLinkedList<char>();
            int num = 0;
            int Radius = l.GetLength();
        
        while (true)
        {
            Console.Write("Input : ");
            char checkInput = char.Parse(Console.ReadLine());
            if ((checkInput != 'J') && (checkInput != 'G') && (checkInput != 'O') && (checkInput != 'R')) {
                break; 
            }

            if (Radius == 0) {
                if ((checkInput == 'J') || (checkInput == 'G') || (checkInput == 'O')) {
                    l.Add(checkInput);
                    num += 1;
                    Radius++;
                } else {
                    Console.WriteLine("Invalid pattern.");
                }
            } else if (checkInput == 'R') {
                if (l.Get(l.GetLength() + num - 1) == 'R') {
                    Console.WriteLine("Invalid pattern.");
                } else {
                    l.Add(checkInput);
                    num += 1;
                }
            } else if ((checkInput == 'J') || (checkInput == 'G') || (checkInput == 'O')) {
                if (l.Get(l.GetLength() + num - 1) == 'R') {
                    if (l.Get(l.GetLength() + num - 2) == checkInput) {
                        Console.WriteLine("Invalid pattern.");
                    } else if ((checkInput == 'J') || (checkInput == 'G') || (checkInput == 'O')) {
                        l.Add(checkInput);
                        num += 1;
                    } else { Console.WriteLine("Invalid pattern."); }
                } else if ((l.Get(l.GetLength() + num - 3) == 'G') &&
                           (l.Get(l.GetLength() + num - 2) == 'G') &&
                           (l.Get(l.GetLength() + num - 1) == 'G') && checkInput == 'G') {
                    if (l.Get(l.GetLength() + num - 4) == 'G') {
                        Console.WriteLine("Invalid pattern.");
                    } else {
                        Console.WriteLine("Invalid pattern.");
                    }
                } else {
                    l.Add(checkInput);
                    num += 1;
                }
            }
        }
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=");
        for (int i = 0; i < l.GetLength(); i++) {
            Console.Write(l.Get(i));
        }
    }
}