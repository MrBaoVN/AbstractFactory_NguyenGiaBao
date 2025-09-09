using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225405_NguyenGiaBao_MyReal01_AbstractFactory
{
    class LightButton : Button
    {
        public override void Render()
        {
            Console.WriteLine("Rendering Light Button (White background, Black text)");
        }
    }
}
