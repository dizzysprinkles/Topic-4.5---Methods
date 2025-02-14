namespace Topic_4._5___Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int eeyoreX, eeyoreY;
            KnockKnock();
            Console.WriteLine();
            //Console.WriteLine("Where should I draw Eeyore? Give me two numbers");
            //Console.WriteLine("First number (x location) is: ");
            //Int32.TryParse(Console.ReadLine(), out eeyoreX);
            //Console.WriteLine("Second number (y location) is: ");
            //Int32.TryParse(Console.ReadLine(), out eeyoreY);
            DrawEeyore(/*eeyoreX, eeyoreY*/);
            DrawTigger();
            DrawPooh();
        }

        // Knock Knock Joke method
        public static void KnockKnock()
        {
            Console.WriteLine("Knock, knock.");
            Console.ReadLine();
            Thread.Sleep(1000);
            Console.WriteLine("Kanga");
            Console.ReadLine();
            Thread.Sleep(1000);
            Console.WriteLine("Actually it's kangaroo");
            Thread.Sleep(3000);

        }

        // ASCII Art Methods
        public static void DrawTigger()
        {
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

        }

        public static void DrawEeyore(/*int x,int y*/)
        {
            //Console.SetCursorPosition(x, y);
            Console.WriteLine("   /`\"'-,__");
            Console.WriteLine("   \\/\\)`   `'-.");
            Console.WriteLine("  // \\ .--.\\   '.");
            Console.WriteLine(" //|-.  \\_o `-.  \\---._");
            Console.WriteLine(" || \\_o\\  _.-.\\`'-'    `-.");
            Console.WriteLine(" || |\\.-'`    |           `.");
            Console.WriteLine(" || | \\  \\    |             `\\");
            Console.WriteLine(" \\| /  \\ ,\\' /                \\");
            Console.WriteLine("  `'    `---'                  ;");
            Console.WriteLine("         `))          .-'      |");
            Console.WriteLine("      .-.// .-.     .'        ,;=D");
            Console.WriteLine("     /  // /   \\  .'          ||");
            Console.WriteLine("   |..-' |     '-'          //");
            Console.WriteLine("    ((    \\         .===. _,//");
            Console.WriteLine("     '`'--`'---''',--\\_/-;-'`");
            Console.WriteLine("                   `~/^\\`");
            Console.WriteLine("                    '==='");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void DrawPooh()
        {
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
        }

    }
}
