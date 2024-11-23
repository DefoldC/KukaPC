using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MxAutomation_Example
{
    class readKukaFile
    {
        public string pathKukaFile;  // полный путь до файла (изменяется при нажатии кнопки "Выбрать фаил")
        public void Start()
        {
            char[] separators = new char[] { '{', '}' };
            string workingDirectory = Environment.CurrentDirectory;
            string[] pieces = new string[] { };
            List<double> coords = new List<double> { };

            StreamReader sr = new StreamReader(pathKukaFile);
            string line = sr.ReadLine();

            while (line != null)
            {
                pieces = line.Split(separators);
                if (pieces[0].Contains("$"))
                {

                }
                else
                {
                    if (pieces[0].Contains("PTP"))
                    {
                        //Disect(pieces);
                    }
                    else if (pieces[0].Contains("LIN"))
                    {
                        coords = Disect(pieces);
                        foreach (var entry in coords)
                        {
                            Console.Write(entry + " ");
                        }
                        Console.WriteLine();
                        // foreach (var e in pieces)
                        //      Console.WriteLine(e);
                    }
                    else if (pieces[0].Contains("CIRC"))
                    {
                    }
                }
                //  foreach (var e in pieces)
                //    Console.WriteLine(e);
                line = sr.ReadLine();
            }
            sr.Close();
            Console.ReadLine();
        }

        public static List<double> Disect(string[] pieces)
        {
            List<double> coords = new List<double> { }; // X  Y  Z  A  B  C
                                                    // A1 A2 A3 A4 A5 A6 E1 E2 E3 E4 E5 E6
            char[] separators = new char[] { ' ', ',' };
            int i = pieces.Count();
            string[] bits = new string[] { };

            foreach (var piece in pieces)
            {
                if (piece.Contains("X"))
                {
                    bits = piece.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    for (i = 0; i < bits.Count() / 2; i++)
                    coords.Add(Convert.ToDouble(bits[i * 2 + 1].Replace('.', ',')));
                }
            }
            return coords;
            //Console.WriteLine(i);
        }
}
}
