namespace Topic_4._5___Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eeyoreX, eeyoreY;
            KnockKnock();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Since we're on the topic of animals, I will draw some Winnie the Pooh characters!");
            Console.WriteLine("Where should I draw Eeyore? Please give me two numbers!");
            Console.WriteLine("First number (x location) is: ");
            while (!Int32.TryParse(Console.ReadLine(), out eeyoreX) || eeyoreX > 80 || eeyoreX < 0)
            {
                Console.WriteLine("That position is not possible! Try again.");
                Console.WriteLine();
            }
            Console.WriteLine("Second number (y location) is: ");
            while (!Int32.TryParse(Console.ReadLine(), out eeyoreY) || eeyoreY >= Console.BufferHeight || eeyoreY < 0)
            {
                Console.WriteLine("That position is not possible! Try again.");
                Console.WriteLine();
            }
            
            DrawEeyore(eeyoreX, eeyoreY);

            Console.WriteLine("Now I'll draw Tigger so Eeyore has a friend!");
            DrawTigger();
            Console.WriteLine("Now I'll draw Winnie the Pooh to complete the trio!");
            DrawPooh();
        }

        // Knock Knock Joke method
        public static void KnockKnock()
        {
            Console.WriteLine("I will tell you a knock knock joke! \nRespond how you would if your friend told you the joke and then hit ENTER after responding!");
            Console.WriteLine("Knock, knock.");
            Console.ReadLine();
            Thread.Sleep(1000);
            Console.WriteLine("Kanga");
            Console.ReadLine();
            Thread.Sleep(1000);
            Console.WriteLine("Actually it's kangaroo!");
            Thread.Sleep(3000);
            Console.Clear();

        }

        // ASCII Art Methods
        public static void DrawTigger()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("        __  _-==-=_,-.");
            Console.WriteLine("        /--`' \\_@-@.--<");
            Console.WriteLine("        `--'\\ \\   <___/.  ");
            Console.WriteLine("            \\ \\\\   \" /  ");
            Console.WriteLine("             >=\\_/`<");
            Console.WriteLine("  ____       /= |  \\_|/");
            Console.WriteLine("_'    `\\   _/=== \\___/");
            Console.WriteLine("`___/ //\\./=/~\\====\\");
            Console.WriteLine("    \\   // /   | ===:");
            Console.WriteLine("     |  ._/_,__|_ ==:        __");
            Console.WriteLine("      \\/    \\\\ \\\\`--|       / \\\\  ");
            Console.WriteLine("       |    _     \\:       /==:-\\ ");
            Console.WriteLine("       `.__' `-____/       |--|==:");
            Console.WriteLine("          \\    \\ ===\\      :==:`-'");
            Console.WriteLine("          _>    \\ ===\\    /==/");
            Console.WriteLine("         /==\\   |  ===\\__/--/");
            Console.WriteLine("        <=== \\  /  ====\\ \\\\/");
            Console.WriteLine("        _`--  \\/  === \\/--'");
            Console.WriteLine("       |       \\ ==== |");
            Console.WriteLine("        -`------/`--' /");
            Console.WriteLine("                \\___-'");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

        }

        public static void DrawEeyore(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("   /`\"'-,__");
            Console.SetCursorPosition(x, y+1);
            Console.WriteLine("   \\/\\)`   `'-.");
            Console.SetCursorPosition(x, y+2);
            Console.WriteLine("  // \\ .--.\\   '.");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine(" //|-.  \\_o `-.  \\---._");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine(" || \\_o\\  _.-.\\`'-'    `-.");
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine(" || |\\.-'`    |           `.");
            Console.SetCursorPosition(x, y + 6);
            Console.WriteLine(" || | \\  \\    |             `\\");
            Console.SetCursorPosition(x, y + 7);
            Console.WriteLine(" \\| /  \\ ,\\' /                \\");
            Console.SetCursorPosition(x, y + 8);
            Console.WriteLine("  `'    `---'                  ;");
            Console.SetCursorPosition(x, y + 9);
            Console.WriteLine("         `))          .-'      |");
            Console.SetCursorPosition(x, y + 10);
            Console.WriteLine("      .-.// .-.     .'        ,;=D");
            Console.SetCursorPosition(x, y + 11);
            Console.WriteLine("     /  // /   \\  .'          ||");
            Console.SetCursorPosition(x, y + 12);
            Console.WriteLine("   |..-' |     '-'          //");
            Console.SetCursorPosition(x, y + 13);
            Console.WriteLine("    ((    \\         .===. _,//");
            Console.SetCursorPosition(x, y + 14);
            Console.WriteLine("     '`'--`'---''',--\\_/-;-'`");
            Console.SetCursorPosition(x, y + 15);
            Console.WriteLine("                   `~/^\\`");
            Console.SetCursorPosition(x, y + 16);
            Console.WriteLine("                    '==='");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void DrawPooh()
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("            _     _");
            Console.WriteLine("           /\\\\.--/\\\\");
            Console.WriteLine("           \\_ _  \\//\\");
            Console.WriteLine("         __/o o`     |");
            Console.WriteLine("        (/           |");
            Console.WriteLine("         \\__,        /");
            Console.WriteLine("        __\\-'       /");
            Console.WriteLine("   .-'``\\ /`\"-=.-=\"`)");
            Console.WriteLine(" /`  _.-.'          \\");
            Console.WriteLine(" \\_.\"   ,`-._ /    /_\\");
            Console.WriteLine("       /     /-.._/ |");
            Console.WriteLine("      |     /    /  |");
            Console.WriteLine("     ,|    '.__.'   |");
            Console.WriteLine(" _  /  \\     .-\"\".  /");
            Console.WriteLine("/ \\/   /`-._|     |");
            Console.WriteLine("\\  \\  /     \\     |");
            Console.WriteLine(" \\   /       \\    |");
            Console.WriteLine("  '-'         `.  |");
            Console.WriteLine("           .-\"`   \\");
            Console.WriteLine("jgs        \\__,.-'`");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
