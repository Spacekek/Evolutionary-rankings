using System;
using System.Text;
using System.Linq;

namespace Aoe_rankings_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string invoer;
            int iterations;
            Console.WriteLine("Voer de spelers in: abcd (aan elkaar vast, 1 letter per speler)");
            invoer = Console.ReadLine();
            char[] tijdelijkearray = invoer.ToCharArray();
            int arraylength = tijdelijkearray.Length;
            string[,] templatearray = new string[arraylength, 2];
            for (int x = 0; x < tijdelijkearray.Length; x++)
            {
                templatearray[x, 0] = Convert.ToString(tijdelijkearray[x]);
            }
            Console.WriteLine("Hoeveel vergelijkingen?");
            int aantal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Schrijf ze zo op: ab>c (geen spaties, winnend aan linker kant, geen plusjes)");
            string[,] vergelijkingboi = new string[aantal, 14];
            for (int i = 0; i < aantal; i++)
            {
                invoer = Console.ReadLine();
                tijdelijkearray = invoer.ToCharArray();
                int x = 0;
                while ('>' != tijdelijkearray[x])
                {
                    vergelijkingboi[i, x] = Convert.ToString(tijdelijkearray[x]);
                    x++;
                }
                x++;
                int y = 7;
                while (x < tijdelijkearray.Length)
                {
                    vergelijkingboi[i, y] = Convert.ToString(tijdelijkearray[x]);
                    x++;
                    y++;
                }
            }
            Console.WriteLine("Hoeveel generaties maximaal?");
            iterations = Convert.ToInt32(Console.ReadLine());
            string[,] templatearray1 = templatearray;
            templatearray1 = Arrayrandomizer(templatearray1, arraylength);
            string[,] templatearray2 = templatearray;
            templatearray2 = Arrayrandomizer(templatearray2, arraylength);
            string[,] templatearray3 = templatearray;
            templatearray3 = Arrayrandomizer(templatearray3, arraylength);
            string[,] templatearray4 = templatearray;
            templatearray4 = Arrayrandomizer(templatearray4, arraylength);
            string[,] templatearray5 = templatearray;
            templatearray5 = Arrayrandomizer(templatearray5, arraylength);
            string[,] templatearray6 = templatearray;
            templatearray6 = Arrayrandomizer(templatearray6, arraylength);
            string[,] templatearray7 = templatearray;
            templatearray7 = Arrayrandomizer(templatearray7, arraylength);
            string[,] templatearray8 = templatearray;
            templatearray8 = Arrayrandomizer(templatearray8, arraylength);
            string[,] templatearray9 = templatearray;
            templatearray9 = Arrayrandomizer(templatearray9, arraylength);
            string[,] templatearray10 = templatearray;
            templatearray10 = Arrayrandomizer(templatearray10, arraylength);
            string[,] templatearray11 = templatearray;
            templatearray11 = Arrayrandomizer(templatearray11, arraylength);
            string[,] templatearray12 = templatearray;
            templatearray12 = Arrayrandomizer(templatearray12, arraylength);
            string[,] templatearray13 = templatearray;
            templatearray13 = Arrayrandomizer(templatearray13, arraylength);
            string[,] templatearray14 = templatearray;
            templatearray14 = Arrayrandomizer(templatearray14, arraylength);
            string[,] templatearray15 = templatearray;
            templatearray15 = Arrayrandomizer(templatearray15, arraylength);
            string[,] templatearray16 = templatearray;
            templatearray16 = Arrayrandomizer(templatearray16, arraylength);
            string[,] templatearray17 = templatearray;
            templatearray17 = Arrayrandomizer(templatearray17, arraylength);
            string[,] templatearray18 = templatearray;
            templatearray18 = Arrayrandomizer(templatearray18, arraylength);
            string[,] templatearray19 = templatearray;
            templatearray19 = Arrayrandomizer(templatearray19, arraylength);
            string[,] templatearray20 = templatearray;
            templatearray20 = Arrayrandomizer(templatearray20, arraylength);
            string[,] beste1 = new string[arraylength, 2];
            string[,] beste2 = new string[arraylength, 2];
            string[,] beste3 = new string[arraylength, 2];
            string[,] beste4 = new string[arraylength, 2];
            string[,] bestetijdelijk = new string[arraylength, 2];
            int teller = 0;

            while (iterations > 0){
                int[] beste4array = BesteArray(arraylength, aantal, vergelijkingboi, templatearray1, templatearray2, templatearray3, templatearray4, templatearray5, templatearray6, templatearray7, templatearray8, templatearray9, templatearray10, templatearray11, templatearray12, templatearray13, templatearray14, templatearray15, templatearray16, templatearray17, templatearray18, templatearray19, templatearray20);
                if (beste4array[0] == 0) { beste1 = templatearray1; } else if (beste4array[0] == 1) { beste1 = templatearray2; } else if (beste4array[0] == 2) { beste1 = templatearray3; } else if (beste4array[0] == 3) { beste1 = templatearray4; } else if (beste4array[0] == 4) { beste1 = templatearray5; } else if (beste4array[0] == 5) { beste1 = templatearray6; } else if (beste4array[0] == 6) { beste1 = templatearray7; } else if (beste4array[0] == 7) { beste1 = templatearray8; } else if (beste4array[0] == 8) { beste1 = templatearray9; } else if (beste4array[0] == 9) { beste1 = templatearray10; } else if (beste4array[0] == 10) { beste1 = templatearray11; } else if (beste4array[0] == 11) { beste1 = templatearray12; } else if (beste4array[0] == 12) { beste1 = templatearray13; } else if (beste4array[0] == 13) { beste1 = templatearray14; } else if (beste4array[0] == 14) { beste1 = templatearray15; } else if (beste4array[0] == 15) { beste1 = templatearray16; } else if (beste4array[0] == 16) { beste1 = templatearray17; } else if (beste4array[0] == 17) { beste1 = templatearray18; } else if (beste4array[0] == 18) { beste1 = templatearray19; } else if (beste4array[0] == 19) { beste1 = templatearray20; }
                if (beste4array[1] == 0) { beste2 = templatearray1; } else if (beste4array[1] == 1) { beste2 = templatearray2; } else if (beste4array[1] == 2) { beste2 = templatearray3; } else if (beste4array[1] == 3) { beste2 = templatearray4; } else if (beste4array[1] == 4) { beste2 = templatearray5; } else if (beste4array[1] == 5) { beste2 = templatearray6; } else if (beste4array[1] == 6) { beste2 = templatearray7; } else if (beste4array[1] == 7) { beste2 = templatearray8; } else if (beste4array[1] == 8) { beste2 = templatearray9; } else if (beste4array[1] == 9) { beste2 = templatearray10; } else if (beste4array[1] == 10) { beste2 = templatearray11; } else if (beste4array[1] == 11) { beste2 = templatearray12; } else if (beste4array[1] == 12) { beste2 = templatearray13; } else if (beste4array[1] == 13) { beste2 = templatearray14; } else if (beste4array[1] == 14) { beste2 = templatearray15; } else if (beste4array[1] == 15) { beste2 = templatearray16; } else if (beste4array[1] == 16) { beste2 = templatearray17; } else if (beste4array[1] == 17) { beste2 = templatearray18; } else if (beste4array[1] == 18) { beste2 = templatearray19; } else if (beste4array[1] == 19) { beste2 = templatearray20; }
                if (beste4array[2] == 0) { beste3 = templatearray1; } else if (beste4array[2] == 1) { beste3 = templatearray2; } else if (beste4array[2] == 2) { beste3 = templatearray3; } else if (beste4array[2] == 3) { beste3 = templatearray4; } else if (beste4array[2] == 4) { beste3 = templatearray5; } else if (beste4array[2] == 5) { beste3 = templatearray6; } else if (beste4array[2] == 6) { beste3 = templatearray7; } else if (beste4array[2] == 7) { beste3 = templatearray8; } else if (beste4array[2] == 8) { beste3 = templatearray9; } else if (beste4array[2] == 9) { beste3 = templatearray10; } else if (beste4array[2] == 10) { beste3 = templatearray11; } else if (beste4array[2] == 11) { beste3 = templatearray12; } else if (beste4array[2] == 12) { beste3 = templatearray13; } else if (beste4array[2] == 13) { beste3 = templatearray14; } else if (beste4array[2] == 14) { beste3 = templatearray15; } else if (beste4array[2] == 15) { beste3 = templatearray16; } else if (beste4array[2] == 16) { beste3 = templatearray17; } else if (beste4array[2] == 17) { beste3 = templatearray18; } else if (beste4array[2] == 18) { beste3 = templatearray19; } else if (beste4array[2] == 19) { beste3 = templatearray20; }
                if (beste4array[3] == 0) { beste4 = templatearray1; } else if (beste4array[3] == 1) { beste4 = templatearray2; } else if (beste4array[3] == 2) { beste4 = templatearray3; } else if (beste4array[3] == 3) { beste4 = templatearray4; } else if (beste4array[3] == 4) { beste4 = templatearray5; } else if (beste4array[3] == 5) { beste4 = templatearray6; } else if (beste4array[3] == 6) { beste4 = templatearray7; } else if (beste4array[3] == 7) { beste4 = templatearray8; } else if (beste4array[3] == 8) { beste4 = templatearray9; } else if (beste4array[3] == 9) { beste4 = templatearray10; } else if (beste4array[3] == 10) { beste4 = templatearray11; } else if (beste4array[3] == 11) { beste4 = templatearray12; } else if (beste4array[3] == 12) { beste4 = templatearray13; } else if (beste4array[3] == 13) { beste4 = templatearray14; } else if (beste4array[3] == 14) { beste4 = templatearray15; } else if (beste4array[3] == 15) { beste4 = templatearray16; } else if (beste4array[3] == 16) { beste4 = templatearray17; } else if (beste4array[3] == 17) { beste4 = templatearray18; } else if (beste4array[3] == 18) { beste4 = templatearray19; } else if (beste4array[3] == 19) { beste4 = templatearray20; }
                if(teller == 5 && VergelijkArray(beste1,bestetijdelijk,arraylength))
                {
                    break;
                }
                if (teller == 5)
                {
                    teller -= 5;
                    bestetijdelijk = OverwriteArray(bestetijdelijk, beste1, arraylength);
                }
                templatearray1 = OverwriteArray(templatearray1, beste1, arraylength);
                templatearray2 = OverwriteArray(templatearray2, beste2, arraylength);
                templatearray3 = OverwriteArray(templatearray3, beste3, arraylength);
                templatearray4 = OverwriteArray(templatearray4, beste4, arraylength);
                templatearray5 = templatearray;
                templatearray5 = Arrayrandomizer(templatearray5, arraylength);
                templatearray6 = templatearray;
                templatearray6 = Arrayrandomizer(templatearray6, arraylength);
                templatearray7 = Mutatie(beste1, arraylength);
                templatearray8 = Mutatie(beste1, arraylength);
                templatearray9 = Mutatie(beste1, arraylength);
                templatearray10 = Mutatie(beste2, arraylength);
                templatearray11 = Mutatie(beste2, arraylength);
                templatearray12 = Mutatie(beste2, arraylength);
                templatearray13 = Mutatie(beste3, arraylength);
                templatearray14 = Mutatie(beste3, arraylength);
                templatearray15 = Mutatie(beste4, arraylength);
                templatearray16 = Mutatie(beste4, arraylength);
                templatearray17 = Kruislings(beste1, beste2, arraylength);
                templatearray18 = Kruislings(beste2, beste3, arraylength);
                templatearray19 = Kruislings(beste3, beste4, arraylength);
                templatearray20 = Kruislings(beste1, beste3, arraylength);
                iterations--;
                teller++;
                
            }
            Console.WriteLine("Resultaten:");
            for (int i = 0; i < arraylength; i++)
            {
                Console.WriteLine(beste1[i, 0] + " " + beste1[i, 1]);
            }
        }
        public static string[,] Arrayrandomizer (string[,] templateboio, int arraylength)
        {
            for (int i = 0; i < arraylength; i++)
            {
                Random rnd = new Random();
                double rating = Convert.ToDouble(rnd.Next(0, 1001))/100;
                templateboio[i, 1] = Convert.ToString(rating);
            }
            return templateboio;
        }
        public static int[] BesteArray(int arraylength, int aantal, string[,] vergelijkingboi, string[,] templatearray1, string[,] templatearray2, string[,] templatearray3, string[,] templatearray4, string[,] templatearray5, string[,] templatearray6, string[,] templatearray7, string[,] templatearray8, string[,] templatearray9, string[,] templatearray10, string[,] templatearray11, string[,] templatearray12, string[,] templatearray13, string[,] templatearray14, string[,] templatearray15, string[,] templatearray16, string[,] templatearray17, string[,] templatearray18, string[,] templatearray19, string[,] templatearray20)
        {
            double[,] rangschikkingsarray = new double[20,2];
            int[] ranking = new int[4];
            for (int i = 0; i < 20; i++)
            {
                rangschikkingsarray[i, 0] = i;
            }

            rangschikkingsarray[0, 1] = Vergelijker(arraylength, aantal, vergelijkingboi, templatearray1);
            rangschikkingsarray[1, 1] = Vergelijker(arraylength, aantal, vergelijkingboi, templatearray2);
            rangschikkingsarray[2, 1] = Vergelijker(arraylength, aantal, vergelijkingboi, templatearray3);
            rangschikkingsarray[3, 1] = Vergelijker(arraylength, aantal, vergelijkingboi, templatearray4);
            rangschikkingsarray[4, 1] = Vergelijker(arraylength, aantal, vergelijkingboi, templatearray5);
            rangschikkingsarray[5, 1] = Vergelijker(arraylength, aantal, vergelijkingboi, templatearray6);
            rangschikkingsarray[6, 1] = Vergelijker(arraylength, aantal, vergelijkingboi, templatearray7);
            rangschikkingsarray[7, 1] = Vergelijker(arraylength, aantal, vergelijkingboi, templatearray8);
            rangschikkingsarray[8, 1] = Vergelijker(arraylength, aantal, vergelijkingboi, templatearray9);
            rangschikkingsarray[9, 1] = Vergelijker(arraylength, aantal, vergelijkingboi, templatearray10);
            rangschikkingsarray[10, 1] = Vergelijker(arraylength, aantal, vergelijkingboi, templatearray11);
            rangschikkingsarray[11, 1] = Vergelijker(arraylength, aantal, vergelijkingboi, templatearray12);
            rangschikkingsarray[12, 1] = Vergelijker(arraylength, aantal, vergelijkingboi, templatearray13);
            rangschikkingsarray[13, 1] = Vergelijker(arraylength, aantal, vergelijkingboi, templatearray14);
            rangschikkingsarray[14, 1] = Vergelijker(arraylength, aantal, vergelijkingboi, templatearray15);
            rangschikkingsarray[15, 1] = Vergelijker(arraylength, aantal, vergelijkingboi, templatearray16);
            rangschikkingsarray[16, 1] = Vergelijker(arraylength, aantal, vergelijkingboi, templatearray17);
            rangschikkingsarray[17, 1] = Vergelijker(arraylength, aantal, vergelijkingboi, templatearray18);
            rangschikkingsarray[18, 1] = Vergelijker(arraylength, aantal, vergelijkingboi, templatearray19);
            rangschikkingsarray[19, 1] = Vergelijker(arraylength, aantal, vergelijkingboi, templatearray20);

            for (int i = 1; i < 20; i++)
            {
                for (int e = i; e < 0; e--)
                {
                    if (rangschikkingsarray[i, 1] < rangschikkingsarray[i - 1, 1])
                    {
                        double nummer1 = rangschikkingsarray[i, 0];
                        double nummer2 = rangschikkingsarray[i, 1];
                        rangschikkingsarray[i, 0] = rangschikkingsarray[i - 1, 0];
                        rangschikkingsarray[i, 1] = rangschikkingsarray[i - 1, 1];
                        rangschikkingsarray[i - 1, 0] = nummer1;
                        rangschikkingsarray[i - 1, 1] = nummer2;
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                ranking[i] = Convert.ToInt32(rangschikkingsarray[i, 0]);
            }
            return ranking;


        }
        public static double Vergelijker(int arraylength, int aantal, string[,] vergelijkingboi, string[,] templatearray)
        {
            double optelgetal = 0;
            for (int i = 0; i < aantal; i++)
            {
                double linkerhelft = 0;
                double rechterhelft = 0;
                for (int u = 0; u < 7; u++)
                {
                    string x = vergelijkingboi[i, u];
                    if (x == null)
                    {
                        break;
                    }
                    for (int p = 0; p < arraylength; p++)
                    {
                        if (templatearray[p, 0] == x)
                        {
                            linkerhelft += Convert.ToDouble(templatearray[p, 1]);
                        }
                    }
                }
                for (int o = 7; o < 14; o++)
                {
                    string x = vergelijkingboi[i, o];
                    if (x == null)
                    {
                        break;
                    }
                    for (int p = 0; p < arraylength; p++)
                    {
                        if (templatearray[p, 0] == x)
                        {
                            rechterhelft += Convert.ToDouble(templatearray[p, 1]);
                        }
                    }
                }
                if (linkerhelft <= rechterhelft)
                {
                    optelgetal += rechterhelft - linkerhelft;
                }
            }
            return optelgetal;
        }
        public static string[,] Mutatie(string[,] startarray, int arraylength)
        {
            for (int i = 0; i < arraylength/2; i++)
            {
                Random rnd1 = new Random();
                int random1 = rnd1.Next(0, arraylength);
                Random rnd2 = new Random();
                double random2 = Convert.ToDouble(rnd2.Next(-501, 501))/1000;
                double tijdelijkding = Convert.ToDouble(startarray[random1, 1]);
                tijdelijkding += random2;
                startarray[random1, 1] = Convert.ToString(tijdelijkding);
                if (Convert.ToDouble(startarray[random1,1]) < 0)
                {
                    startarray[random1, 1] = "0";
                }
                if (Convert.ToDouble(startarray[random1, 1]) > 10)
                {
                    startarray[random1, 1] = "10";
                }
            }
            return startarray;
        }
        public static string[,] Kruislings(string[,] startarray, string[,] anderstartarray, int arraylength)
        {
            Random rnd1 = new Random();
            int random1 = rnd1.Next(0, 2);
            if (random1 == 1)
            {
                for (int i = 0; i < arraylength / 2; i++)
                {
                    startarray[i, 1] = anderstartarray[i, 1];
                }
            }
            else
            {
                for (int i = arraylength/2-1; i < arraylength; i++)
                {
                    startarray[i, 1] = anderstartarray[i, 1];
                }
            }
            return startarray;
        }
        public static string[,] OverwriteArray(string[,] overwritten, string[,] nieuwedata, int arraylength)
        {
            for (int i = 0; i < arraylength; i++)
            {
                overwritten[i, 1] = nieuwedata[i, 1];
            }
            return overwritten;
        }
        public static bool VergelijkArray(string[,] array1, string[,] array2, int arraylength)
        {
            for (int i = 0; i < arraylength; i++)
            {
                if (array1[i, 1] != array2[i, 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
