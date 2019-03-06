using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace Ex5.UI
{
    // $G$ SFN-013 (+20) Bonus: UI with richer graphics / motion / sound.

    public class Program
    {
        public static void Main()
        {
            StartPlaying checkersGame = new StartPlaying();
            checkersGame.StartCheckersGame();
        }
    }
}