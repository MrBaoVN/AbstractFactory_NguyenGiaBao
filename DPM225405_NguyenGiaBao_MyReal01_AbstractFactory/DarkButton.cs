using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225405_NguyenGiaBao_MyReal01_AbstractFactory
{
    class DarkButton : Button
    {
        public override void Render()
        {
            Console.WriteLine("Rendering Dark Button (Black background, White text)");
        }
    }
}
