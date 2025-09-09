using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225405_NguyenGiaBao_MyReal01_AbstractFactory
{
    class DarkTextbox : Textbox
    {
        public override void Render()
        {
            Console.WriteLine("Rendering Dark Textbox (Black background, White text)");
        }
    }
}
