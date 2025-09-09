using DPM225405_NguyenGiaBao_MyReal01_AbstractFactory;
using System;

namespace DPM225405_NguyenGiaBao_Pattern1_AbstractFactory
{
    class Program
    {
        static void Main()
        {
            // Dùng Light Theme
            ThemeFactory lightTheme = new LightThemeFactory();
            Application app1 = new Application(lightTheme);
            app1.RenderUI();

            // Dùng Dark Theme
            ThemeFactory darkTheme = new DarkThemeFactory();
            Application app2 = new Application(darkTheme);
            app2.RenderUI();

            Console.ReadKey();
        }
    }
}
