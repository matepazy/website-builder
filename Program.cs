using System;
using System.IO;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(String[] args)
        {
            

            Console.WriteLine("Üdvözöllek a WebBuilder-ben!");
            Console.WriteLine("Kérlek szánj 5 percet a weboldalad elkészítésére!");
            Console.WriteLine("");
            Console.WriteLine("Hova szeretnéd a fájlt?");
            string? fullPath = Console.ReadLine();
            if(!File.Exists(fullPath))
            {
                Console.WriteLine("Nem tatlálható a fájl ezen az úton: " + fullPath);
                Console.ReadLine();
            } else
            {
            Console.WriteLine("");
            // title
            Console.WriteLine("Mi legyen a weboldalad címe (title-je)? ");
            string? title = Console.ReadLine();
            Console.WriteLine("");
            // h1
            Console.WriteLine("Mi legyen a weboldalad nagy címe (h1)? ");
            string? h1 = Console.ReadLine();
            Console.WriteLine("");
            // p
            Console.WriteLine("Írj magadról! ");
            string? bio = Console.ReadLine();
            // háttér színe
            Console.WriteLine("");
            Console.WriteLine("Mi legyen a háttér színe? (angol szín, hex, rgb(a))");
            string? bgColor = Console.ReadLine();
            // betű színe
            Console.WriteLine("");
            Console.WriteLine("Mi legyen a betűszín? (angol szín, hex, rgb(a))? ");
            string? textColor = Console.ReadLine();
            // szöveg helye
            Console.WriteLine("");
            Console.WriteLine("Hol legyen a szöveg?");
            Console.WriteLine("left = bal");
            Console.WriteLine("center = közép");
            Console.WriteLine("right = jobb");
            string? textAlign = Console.ReadLine();
            // facebook
            Console.WriteLine("");
            Console.WriteLine("Facebook linked(ha nincs hagyd üresen): ");
            string? fb = Console.ReadLine();
            // tiktok
            Console.WriteLine("");
            Console.WriteLine("TikTok linked(ha nincs hagyd üresen): ");
            string? tiktok = Console.ReadLine();
            // instagram
            Console.WriteLine("");
            Console.WriteLine("Instagram linked(ha nincs hagyd üresen): ");
            string? ig = Console.ReadLine();
            // youtube
            Console.WriteLine("");
            Console.WriteLine("YouTube linked(ha nincs hagyd üresen): ");
            string? yt = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Hogyan szeretnéd elrendeni?");
            Console.WriteLine("flex = középen");
            Console.WriteLine("block = egymás mellett");
            string? buttonLayout = Console.ReadLine();

        

            using (StreamWriter sw = new StreamWriter(fullPath, false, Encoding.UTF8))
        {
            // Weboldal megcsinálása
            sw.WriteLine("<html>");
            sw.WriteLine("<head>");
            sw.WriteLine("<title>" + title + "</title>");
            sw.WriteLine("</head>");
            sw.WriteLine("<style>");
            sw.WriteLine("body{");
            sw.WriteLine("color: " + textColor + ";");
            sw.WriteLine("background-color: " + bgColor + " ;");
            sw.WriteLine("text-align: " + textAlign + ";");
            sw.WriteLine("}");
            sw.WriteLine(".buttons{");
            sw.WriteLine("display: " + buttonLayout + ";");
            sw.WriteLine("}");
            sw.WriteLine("</style>");
            sw.WriteLine("<body>");
            sw.WriteLine("<h1>" + h1 + "</h1>");
            sw.WriteLine("<p>" + bio + "</p>");
            sw.WriteLine("<div class='buttons'>");
            sw.WriteLine("<!--Az ez alatti sort töröld ki, ha nem adtál meg linket!-->");
            sw.WriteLine("<button href='" + fb + "'>Facebook</button>");
            sw.WriteLine("<!--Az ez alatti sort töröld ki, ha nem adtál meg linket!-->");
            sw.WriteLine("<button href='" + tiktok + "'>TikTok</button>");
            sw.WriteLine("<!--Az ez alatti sort töröld ki, ha nem adtál meg linket!-->");
            sw.WriteLine("<button href='" + ig + "'>Instagram</button>");
            sw.WriteLine("<!--Az ez alatti sort töröld ki, ha nem adtál meg linket!-->");
            sw.WriteLine("<button href='" + yt + "'>YouTube</button>");
            sw.WriteLine("</div>");
            sw.WriteLine("</body>");
            sw.WriteLine("</html>");
        
        }

            Console.WriteLine("");
            Console.WriteLine("Weboldalhoz szükséges fileok létrehozva!");
            Console.WriteLine("Itt találod meg: " + fullPath);
            Console.WriteLine("Nyomj egy ENTER-t a kilépéshez!");
            Console.ReadLine();
            }
        }
    }
}