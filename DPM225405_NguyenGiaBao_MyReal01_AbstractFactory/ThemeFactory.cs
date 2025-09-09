using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225405_NguyenGiaBao_MyReal01_AbstractFactory
{
    abstract class ThemeFactory
    {
        public abstract Button CreateButton();
        public abstract Textbox CreateTextbox();
    }
}
