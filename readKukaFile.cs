using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using MxA;
using System.Timers;

namespace MxAutomation_Example
{
    class readKukaFile
    {
        public char[] separators = new char[] { '{', '}' };
        public string[] pieces = new string[] { };
        public List<double> coords = new List<double> { };
		System.Timers.Timer timer = new System.Timers.Timer(500);
        public StreamReader sr;
        public string line;
        public bool start = false;
        public bool tick;
        
        public void init(string pathKukaFile){ 
        	sr = new StreamReader(pathKukaFile);// полный путь до файла (изменяется при нажатии кнопки "Выбрать фаил")
        	line = sr.ReadLine();
        	timer.Elapsed += new ElapsedEventHandler((sender, e) => {
                tick = true;
            });
        	tick=false;
        }
             
        
        public void Loop(MainView MV)
        {
            //while (line != null)
            //{
            if (!MV._moveToPosPTP && !MV._moveToPosLIN && !MV._moveToPosCIRC && start) // проверка разрешения перемещения
            {
            	if (!tick)
                {
                	timer.Start(); // если перемещение разрешено, но таймер не запущен, то запускаем таймер
                }
                else // если перемещение разрешено и таймер отработал, то анализируем и исполняем следущую строку
                {
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
						MV._axisPosition.A1 = (float)coords[0];
						MV._axisPosition.A2 = (float)coords[1];
						MV._axisPosition.A3 = (float)coords[2];
						MV._axisPosition.A4 = (float)coords[3];
						MV._axisPosition.A5 = (float)coords[4];
						MV._axisPosition.A6 = (float)coords[5];
						MV._moveToPosPTP = true;			
                	}
                	else if (pieces[0].Contains("LIN "))
                	{
                    	Debug.Write("LIN ");
                    	coords = Disect(pieces);
                    	foreach (var entry in coords){Debug.Write(entry+" ");}
                    	Debug.WriteLine("");
                   		MV._cartesianPosition1.X = (float)coords[0];
                   		MV._cartesianPosition1.Y = (float)coords[1];
                   		MV._cartesianPosition1.Z = (float)coords[2];
                    	MV._cartesianPosition1.A = (float)coords[3];
                    	MV._cartesianPosition1.B = (float)coords[4];
                    	MV._cartesianPosition1.C = (float)coords[5];
                    	MV._moveToPosLIN = true;
                	}
                	else if (pieces[0].Contains("CIRC "))
                	{
                    	Debug.Write("CIRC ");
                    	coords = Disect(pieces);
                    	foreach (var entry in coords){Debug.Write(entry+" ");}
                    	Debug.WriteLine("");
                    	MV._cartesianPosition1.X = (float)coords[0];
                    	MV._cartesianPosition1.Y = (float)coords[1];
                    	MV._cartesianPosition1.Z = (float)coords[2];
                    	MV._cartesianPosition1.A = (float)coords[3];
                    	MV._cartesianPosition1.B = (float)coords[4];
                    	MV._cartesianPosition1.C = (float)coords[5];
                    	
                    	MV._cartesianPosition2.X = (float)coords[6];
                    	MV._cartesianPosition2.Y = (float)coords[7];
                    	MV._cartesianPosition2.Z = (float)coords[8];
                    	MV._cartesianPosition2.A = (float)coords[9];
                    	MV._cartesianPosition2.B = (float)coords[10];
                    	MV._cartesianPosition2.C = (float)coords[11];
                    	MV._moveToPosCIRC = true;
                	}
                    //Debug.WriteLine(pieces[0]);
                	//  foreach (var e in pieces)
                	//    Console.WriteLine(e);
                	line = sr.ReadLine();
                    timer.Stop();    // сбрасываем и выключаем таймер
                    tick = false;
                }

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
