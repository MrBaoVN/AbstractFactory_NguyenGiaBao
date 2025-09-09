using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225405_NguyenGiaBao_MyReal01_AbstractFactory
{
    class Application
    {
        private Button _button;
        private Textbox _textbox;

        public Application(ThemeFactory factory)
        {
            _button = factory.CreateButton();
            _textbox = factory.CreateTextbox();
        }

        public void RenderUI()
        {
            _button.Render();
            _textbox.Render();
        }
    }
}
