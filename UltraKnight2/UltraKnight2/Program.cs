using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltraKnight2;

namespace UltraKnight2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nombre de la ventana.
            Console.Title = "Ultra Knight 2: La maldad del Drágon de plata";
            Console.SetWindowSize(140, 40);
            // Mensajes del juego.
            string UltraKnight = " ##   ##   ###       ##                                ###  ##             ##              ###        ##               ####\r\n ##   ##    ##       ##                                 ##  ##                              ##        ##              ##  ##\r\n ##   ##    ##      #####   ######    ####              ## ##   #####     ###      ### ##   ##       #####                ##\r\n ##   ##    ##       ##      ##  ##      ##             ####    ##  ##     ##     ##  ##    #####     ##                ###\r\n ##   ##    ##       ##      ##       #####             ## ##   ##  ##     ##     ##  ##    ##  ##    ##               ##\r\n ##   ##    ##       ## ##   ##      ##  ##             ##  ##  ##  ##     ##      #####    ##  ##    ## ##           ##  ##\r\n  #####    ####       ###   ####      #####            ###  ##  ##  ##    ####        ##   ###  ##     ###            ######\r\n                                                                                  #####\r\n";
            string Muerte = " ##   ##                               ##\r\n ### ###                               ##\r\n #######  ##  ##    ####    ######    #####    ####\r\n #######  ##  ##   ##  ##    ##  ##    ##     ##  ##\r\n ## # ##  ##  ##   ######    ##        ##     ######\r\n ##   ##  ##  ##   ##        ##        ## ##  ##\r\n ##   ##   ######   #####   ####        ###    #####\r\n\r\n";
            string Fin = " #######    ##\r\n  ##   #\r\n  ## #     ###     #####\r\n  ####      ##     ##  ##\r\n  ## #      ##     ##  ##\r\n  ##        ##     ##  ##\r\n ####      ####    ##  ##\r\n\r\n";
            string mensajeDeMuerte = "";
            // Titulo de entrada.
            // Titulo: UltraKnight.
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(UltraKnight);
            Console.ResetColor();
            // Sub titulo.
            Console.ForegroundColor = ConsoleColor.Yellow;
            string subTitulo = "La maldad del Dragón de plata.";
            int anchoConsola = Console.WindowWidth;
            int posicionX = (anchoConsola - subTitulo.Length) / 2;
            Console.SetCursorPosition(posicionX, Console.CursorTop);
            Console.WriteLine(subTitulo);
            // Dedicaciones.
            Console.WriteLine("| Este juego fue diseñado, escrito y hecho por Matías Otamendi Moreno (MtrVoid8899).");
            Console.ReadKey();
            Console.Clear();
            // Configuración de la ventana.
            Console.WriteLine("| Configuración de ventana.");
            Console.WriteLine("| La ventana se medirá en caracteres: Ancho 170 max y Altura 44 max.");
            Console.Write("| Anchura: ");
            int ventanaAncho = Convert.ToInt32(Console.ReadLine());
            Console.Write("| Altura: ");
            int ventanaAlto = Convert.ToInt32(Console.ReadLine());
            Console.SetWindowSize(ventanaAncho, ventanaAlto);
            Console.WriteLine("| Resolución final: " + ventanaAlto + "x" + ventanaAncho);
            Console.ReadKey();
            // Inicio del juego.
            Console.WriteLine("| Puedes personalizar las stats de tu personaje junto al nombre, ten en cuenta que soy 4:");
            Console.WriteLine("| Fuerza, Defensa, Vida y Energía.");
            Console.WriteLine("| Fuerza define cuánto daño tendrás, además de que se tomará en cuenta para tus puntos de energía (Fuerza x 2= Energía).");
            Console.WriteLine("| ");
            Console.WriteLine("| ");
            Console.WriteLine("| ");
            Console.WriteLine("| Elige cuántos puntos de vida tendrás");
            Console.ReadKey();
        }
    }
}
