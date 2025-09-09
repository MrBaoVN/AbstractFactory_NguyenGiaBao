using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225405_NguyenGiaBao_MyReal01_AbstractFactory
{
    class DarkThemeFactory : ThemeFactory
    {
        public override Button CreateButton()
        {
            return new DarkButton();
        }

        public override Textbox CreateTextbox()
        {
            return new DarkTextbox();
        }
    }
}
