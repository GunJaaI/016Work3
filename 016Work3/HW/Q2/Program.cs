    class Program
{
    static void Main(string[] args) {
        Queue<char> Belt = new Queue<char>();

        PrintMenuScreen();
        string Beforecut = " ";
        string Cutitem = " ";
        Beforecut = InputOnBelt(Belt, Beforecut);
        Cutitem = Calculate(Belt, Cutitem);
        Cutitem = Calculate(Belt, Cutitem);

        Beforecut += Cutitem;
        Console.WriteLine(Beforecut);
    }
    static void PrintMenuScreen() {
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("       Insert ( L,M,S ) or other letter to finish          ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    }
    static string InputOnBelt(Queue<char> Belt, string Beforecut) {
        while (true) {
            Console.Write("Input : ");
            char checkInput = char.Parse(Console.ReadLine());
            if ((checkInput == 'L')||(checkInput == 'M')||(checkInput == 'S')) {
                if (checkInput == 'L') {
                    Belt.Push('1');
                    Beforecut += "1";
                } else if (checkInput == 'M') {
                    Belt.Push('2');
                    Beforecut += "2";
                } else if (checkInput == 'S') {
                    Belt.Push('3');
                    Beforecut += "3";
                }
            } else {break;}
        }
        return Beforecut;
    }
    static string Calculate(Queue<char> Belt,string Cutitem) {
            for (int i = 0; i < Belt.GetLength(); i++) {
                char Fruit = Belt.Pop();
                if (Fruit == '1') {
                    for (int j = 0; j < 2; j++) {
                        //Cutitem += "2";
                        Belt.Push('2');
                    }
                    Cutitem += "22 ";
                } else if (Fruit == '2') {
                    for (int k = 0; k < 3; k++) {
                        //Cutitem += "3";
                        Belt.Push('3');
                    }
                    Cutitem += "333 ";
                }
            }
            return Cutitem;
    }
}