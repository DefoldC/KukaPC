using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using MxA;

namespace MxAutomation_Example
{
    class readKukaFile
    {
        public string pathKukaFile;  // полный путь до файла (изменяется при нажатии кнопки "Выбрать фаил")
        public void Start(ref E6AXIS posAx, ref E6POS posCar1, ref E6POS posCar2)
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
                            //Debug.WriteLine(entry + " ");
                        }
                        Console.WriteLine();
                        // foreach (var e in pieces)
                        //      Console.WriteLine(e);
                    }
                    else if (pieces[0].Contains("CIRC"))
                    {
                    	coords = Disect(pieces);
                        foreach (var entry in coords)
                        {
                            //Debug.WriteLine(entry + " ");
                        }
                        Debug.WriteLine(coords[0]);
                        
                        posCar1.X = (float)coords[0];
                    	//MainView._cartesianPosition1.Y = (float)coords[1];
                    	//MainView._cartesianPosition1.Z = (float)coords[2];
                    	//MainView._cartesianPosition1.A = (float)coords[3];
                    	//MainView._cartesianPosition1.B = (float)coords[4];
                    	//MainView._cartesianPosition1.C = (float)coords[5];
                    	
                    	//MainView._cartesianPosition2.X = (float)coords[6];
                    	//MainView._cartesianPosition2.Y = (float)coords[7];
                    	//MainView._cartesianPosition2.Z = (float)coords[8];
                    	//MainView._cartesianPosition2.A = (float)coords[9];
                    	//MainView._cartesianPosition2.B = (float)coords[10];
                    	//MainView._cartesianPosition2.C = (float)coords[11];
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
