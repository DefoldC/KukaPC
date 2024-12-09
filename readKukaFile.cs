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
        //public string pathKukaFile;  // полный путь до файла (изменяется при нажатии кнопки "Выбрать фаил")
        public char[] separators = new char[] { '{', '}' };
        public string[] pieces = new string[] { };
        public List<double> coords = new List<double> { };

        public StreamReader sr;
        public string line;
        public bool start = false;
        
        public void init(string pathKukaFile){
        	sr = new StreamReader(pathKukaFile);
        	line = sr.ReadLine();
        }
             
        
        public void Loop(ref E6AXIS posAx, ref E6POS posCar1, ref E6POS posCar2, ref bool mPTP, ref bool mLIN, ref bool mCIRC,MainView MV)
        {
            //while (line != null)
            //{
            if(!mPTP && !mLIN && !mCIRC && start){
            	MV.Debug("исполнение строки:"+line);
                pieces = line.Split(separators);
                if (pieces[0].Contains("$"))
                {

                }
                else if (pieces[0].Contains("PTP "))
                {
                	Debug.Write("PTP ");
                    coords = Disect(pieces);
                    foreach (var entry in coords){Debug.Write(entry+" ");}
                    Debug.WriteLine("");
                    //Disect(pieces);
					posAx.A1 = (float)coords[0];
					posAx.A2 = (float)coords[1];
					posAx.A3 = (float)coords[2];
					posAx.A4 = (float)coords[3];
					posAx.A5 = (float)coords[4];
					posAx.A6 = (float)coords[5];
					mPTP = true;			
                }
                else if (pieces[0].Contains("LIN "))
                {
                    Debug.Write("LIN ");
                    coords = Disect(pieces);
                    foreach (var entry in coords){Debug.Write(entry+" ");}
                    Debug.WriteLine("");
                    posCar1.X = (float)coords[0];
                    posCar1.Y = (float)coords[1];
                    posCar1.Z = (float)coords[2];
                    posCar1.A = (float)coords[3];
                    posCar1.B = (float)coords[4];
                    posCar1.C = (float)coords[5];
                    mLIN = true;
                }
                else if (pieces[0].Contains("CIRC "))
                {
                    Debug.Write("CIRC ");
                    coords = Disect(pieces);
                    foreach (var entry in coords){Debug.Write(entry+" ");}
                    Debug.WriteLine("");
                    posCar1.X = (float)coords[0];
                    posCar1.Y = (float)coords[1];
                    posCar1.Z = (float)coords[2];
                    posCar1.A = (float)coords[3];
                    posCar1.B = (float)coords[4];
                    posCar1.C = (float)coords[5];
                    	
                    posCar2.X = (float)coords[6];
                    posCar2.Y = (float)coords[7];
                    posCar2.Z = (float)coords[8];
                    posCar2.A = (float)coords[9];
                    posCar2.B = (float)coords[10];
                    posCar2.C = (float)coords[11];
                    mCIRC = true;
                }
                    //Debug.WriteLine(pieces[0]);
                //  foreach (var e in pieces)
                //    Console.WriteLine(e);
                line = sr.ReadLine();
            }
            //}
            //sr.Close();
            //Console.ReadLine();
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
               if (piece.Contains("X") || piece.Contains("A1"))
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
