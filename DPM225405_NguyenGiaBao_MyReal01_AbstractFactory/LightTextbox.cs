using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225405_NguyenGiaBao_MyReal01_AbstractFactory
{
    class LightTextbox : Textbox
    {
        public override void Render()
        {
            Console.WriteLine("Rendering Light Textbox (White background, Black text)");
        }
    }
}
