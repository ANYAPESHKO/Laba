using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This app play music with help function beep (Hz, msec) 

// I'm sorry, my Engish is very bad. I use GoogleTranslate

//  My app include:
//1. 7 melodies (full and not full)
//2. Free play
//3. Listen and play my melodies
//4. Basic notes
  
//  My app future changes:
//1. Optimizing notes with the help of Console.ReadKey, because there are a lot of notes, but not enough keys
//2. Error converting to short/int, if a person enters a non-number in the input string
//3. Optimizing the function Choice
//4. Calculation of flats and sharps
//5. Lots of songs(it's very hard, because I select some notes and bpm by hands, for example, Shut Your Mouth)
  
//Help me, please


namespace ConsoleApp1
{
    class Program
    {
        static int ChoiceOfPeople;

        // Note frequencies of the main octaves 

        // static Int32 E1 = 41, F1 = 43, G1 = 49, A1 = 55, H1 = 61; //kontroktava
        static Int32 /*C2 = 65, D2 = 73, E2 = 82, F2 = 87, G2 = 98, A2 = 110,*/ H2 = 123; //large octave
        static Int32 C3 = 130, D3 = 146, E3 = 165/*, F3 = 174*/, G3 = 196, /*A3 = 200,*/ H3 = 246;//small octave
        static Int32 C4 = 261, D4 = 293, E4 = 329, F4 = 349, G4 = 392, A4 = 440/*, H4 = 493*/; //first octave
        static Int32 C5 = 523, D5 = 587, E5 = 659, F5 = 698, G5 = 783, A5 = 880/*, H5 = 987*/;//second octave
        static Int32 /*C6 = 1046,*/ D6 = 1174, /*E6 = 1318,*/ F6 = 1396, G6 = 1568/*, A6 = 1760, H6 = 1975*/; //third octave
        static void ListenJingleBells()
        {
            Console.Beep(E5, 300);
            Console.Beep(E5, 300);
            Console.Beep(E5, 300);
            System.Threading.Thread.Sleep(600);
            Console.Beep(E5, 300);
            Console.Beep(E5, 300);
            Console.Beep(E5, 300);
            System.Threading.Thread.Sleep(600);
            Console.Beep(E5, 300);
            Console.Beep(G5, 300);
            Console.Beep(C5, 300);
            Console.Beep(D5, 300);
            Console.Beep(E5, 300);
            Console.Beep(C4, 300);
            Console.Beep(D4, 300);
            Console.Beep(E4, 300);
            Console.Beep(F5, 300);
            Console.Beep(F5, 300);
            Console.Beep(F5, 300);
            Console.Beep(E5, 300);
            System.Threading.Thread.Sleep(600);
            Console.Beep(F5, 300);
            Console.Beep(E5, 300);
            Console.Beep(E5, 300);
            System.Threading.Thread.Sleep(600);
            Console.Beep(E5, 300);
            Console.Beep(D5, 300);
            Console.Beep(D5, 300);
            Console.Beep(E5, 300);
            Console.Beep(D5, 300);
            System.Threading.Thread.Sleep(600);
            Console.Beep(G5, 300);
            System.Threading.Thread.Sleep(600);

        }

        static void ListenSevenNationArmy()
        {
            Console.Beep(E3, 600);
            Console.Beep(E3, 200);
            Console.Beep(G3, 500);     
            Console.Beep(E3, 300);
            Console.Beep(D3, 200);
            Console.Beep(C3, 800);
            Console.Beep(H2, 800);
        } //This function have music(not full)

        static void Menu()
        {
        Flag:
            Console.WriteLine("Enter 1 to enable free mode");// not full
            Console.WriteLine("Enter 2 to play the finished music ");
            Console.WriteLine("Enter 3 to exit the program ");
            string str; int choice;
            str = Console.ReadLine();
            choice = Convert.ToInt32(str);
            switch (choice)
            {
                case 1:
                    {
                        Console.Clear();
                        NoteForUser();
                        Play();
                        Console.Clear(); break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Listen();
                        Console.Clear(); break;
                    }
                case 3: Environment.Exit(0); break;//выйти из приложения
                default:
                    {
                        Console.Clear(); goto Flag;
                    }

            }
       
        }
       
        static void ListenGeese()
        {
             Console.Beep(F4, 300);
             Console.Beep(E4, 300);
             Console.Beep(D4, 300);
             Console.Beep(C4, 300);
             Console.Beep(G4, 600);
             Console.Beep(G4, 600);
             Console.Beep(F4, 300);
             Console.Beep(E4, 300);
             Console.Beep(D4, 300);
             Console.Beep(C4, 300);
             Console.Beep(G4, 600);
             Console.Beep(G4, 600);
             Console.Beep(F4, 300);
             Console.Beep(A4, 300);
             Console.Beep(A4, 300);
             Console.Beep(F4, 300);
             Console.Beep(E4, 300);
             Console.Beep(G4, 300);
             Console.Beep(G4, 300);
             Console.Beep(E4, 300);
             Console.Beep(D4, 300);
             Console.Beep(E4, 300);
             Console.Beep(F4, 300);
             Console.Beep(D4, 300);
             Console.Beep(C4, 600) ;//???
             Console.Beep(C4, 600);//??
        }

        static void ListenFirWasBorn()
        {
            Console.Beep(H3, 500);
            Console.Beep(417, 500);//Ab4
            Console.Beep(417, 500);
            Console.Beep(370, 500);//Gb4
            Console.Beep(417, 500);
            Console.Beep(E4, 500);
            Console.Beep(H3, 500);
            Console.Beep(H3, 500);
            Console.Beep(H3, 500);
            Console.Beep(417, 500);
            Console.Beep(417, 500);
            Console.Beep(370, 500);
            Console.Beep(417, 500);
            Console.Beep(497, 500);//CB5
            System.Threading.Thread.Sleep(300);
            Console.Beep(497, 500);
            Console.Beep(277, 500);//DB4
            Console.Beep(277, 500);
            Console.Beep(A4, 500);
            Console.Beep(A4, 500);
            Console.Beep(417, 500);
            Console.Beep(370, 500);
            Console.Beep(E4, 500);
            Console.Beep(H3, 500);
            Console.Beep(417, 500);
            Console.Beep(417, 500);
            Console.Beep(370, 500);
            Console.Beep(417, 500);
            Console.Beep(E4, 500);
        }

        static void ListenShutYourMouth()
        {
              Console.Beep(C5, 500);
              Console.Beep(G5, 250);
              Console.Beep(C5, 250);
              Console.Beep(831, 500);//Ab5
              Console.Beep(G5, 250);
              Console.Beep(F5, 250);
              Console.Beep(G5, 500);
              Console.Beep(F5, 250);
              Console.Beep(G5, 250);
              Console.Beep(831, 250);
              Console.Beep(831, 250);
              Console.Beep(G5, 250);
              Console.Beep(F5, 250);
              Console.Beep(C5, 500);
              Console.Beep(G5, 250);
              Console.Beep(C5, 250);
              Console.Beep(831, 500);
              Console.Beep(G5, 250);
              Console.Beep(F5, 250);
              Console.Beep(623, 250);//EB5
              Console.Beep(F5, 250);
              Console.Beep(623, 250);
              Console.Beep(D5, 250);
              Console.Beep(D5, 250);
              System.Threading.Thread.Sleep(50);
              Console.Beep(623, 250);//Eb5
              System.Threading.Thread.Sleep(50);
              Console.Beep(D5, 250);
              System.Threading.Thread.Sleep(50);
              Console.Beep(C5, 800);
        }

        static void ListenImperialMarch()
        {
            Console.Beep(A4, 500);
            Console.Beep(A4, 500);
            Console.Beep(A4, 500);
            Console.Beep(F4, 350);
            Console.Beep(C5, 150);
            Console.Beep(A4, 500);
            Console.Beep(F4, 350);
            Console.Beep(C5, 150);
            Console.Beep(A4, 1000);
            Console.Beep(E5, 500);
            Console.Beep(E5, 500);
            Console.Beep(E5, 500);
            Console.Beep(F5, 350);
            Console.Beep(C5, 150);
            Console.Beep(415, 500);//Ab4
            Console.Beep(F4, 350);
            Console.Beep(C5, 150);
            Console.Beep(A4, 1000);
            Console.Beep(A5, 500);
            Console.Beep(A4, 350);
            Console.Beep(A4, 150);
            Console.Beep(A5, 500);
            Console.Beep(830, 250);//Ab5
            Console.Beep(G5, 250);
            Console.Beep(740, 125);//Gb5
            Console.Beep(F5, 125);
            Console.Beep(740, 250);
            System.Threading.Thread.Sleep(250);
            Console.Beep(455, 250);
            Console.Beep(622, 500);//Eb5
            Console.Beep(D5, 250);
            Console.Beep(554, 250);//Db5
            Console.Beep(C5, 125);
            Console.Beep(466, 125);//Hb4
            Console.Beep(C5, 250);
            System.Threading.Thread.Sleep(250);
            Console.Beep(F4, 125);
            Console.Beep(415, 500);
            Console.Beep(F4, 375);
            Console.Beep(A4, 125);
            Console.Beep(C5, 500);
            Console.Beep(A4, 375);
            Console.Beep(C5, 125);
            Console.Beep(E5, 1000);
            Console.Beep(A5, 500);
            Console.Beep(A4, 350);
            Console.Beep(A4, 150);
            Console.Beep(A5, 500);
            Console.Beep(830, 250);
            Console.Beep(G5, 250);
            Console.Beep(740, 125);
            Console.Beep(F5, 125);
            Console.Beep(740, 250);
            System.Threading.Thread.Sleep(250);
            Console.Beep(455, 250);
            Console.Beep(622, 500);
            Console.Beep(D5, 250);
            Console.Beep(554, 250);
            Console.Beep(C5, 125);
            Console.Beep(466, 125);
            Console.Beep(C5, 250);
            System.Threading.Thread.Sleep(250);
            Console.Beep(F4, 250);
            Console.Beep(415, 500);
            Console.Beep(F4, 375);
            Console.Beep(C5, 125);
            Console.Beep(A4, 500);
            Console.Beep(F4, 375);
            Console.Beep(C4, 125);
            Console.Beep(A4, 1000);
            System.Threading.Thread.Sleep(250);
        }

        static void ListenTragedy()
        {
            Console.Beep(G6, 200);
            Console.Beep(G6, 200);
            Console.Beep(G6, 200);
            Console.Beep(1245, 1000);//Eb6
            Console.Beep(F6, 200);
            Console.Beep(F6, 200);
            Console.Beep(F6, 200);
            Console.Beep(D6, 1000);
        }

        static void Main(string[] args)
        {
            for(; ; )
            {
                Menu();
            }
        }

        static void Listen()
        {
        Flag:
            Console.WriteLine("Enter 1 to listen and play Jingle Bells");
            Console.WriteLine("Enter 2 to listen and play Seven Nation Army");
            Console.WriteLine("Enter 3 to listen and play Geese");
            Console.WriteLine("Enter 4 to listen and play Fir Was Born");
            Console.WriteLine("Enter 5 to listen and play Shut Your Mouth");
            Console.WriteLine("Enter 6 to listen and play Tragedy");
            Console.WriteLine("Enter 7 to listen and play Imperial March");
            Console.WriteLine("Enter 8 to exit in menu ");
            string str; int choice;
            str = Console.ReadLine();
            choice = Convert.ToInt16(str);
            ChoiceOfPeople = choice;
            switch (choice)
            {
                case 1:
                    {
                        ListenJingleBells();
                        Console.Clear();
                        Choice();
                        Console.Clear(); break;
                    }
                case 2:
                    {
                        ListenSevenNationArmy();
                        Console.Clear();
                        Choice();
                        Console.Clear(); break;
                    }
                case 3:
                    {
                        ListenGeese();
                        Console.Clear();
                        Choice();
                        Console.Clear(); break;
                    }
                case 4:
                    {
                        ListenFirWasBorn();
                        Console.Clear();
                        Choice();
                        Console.Clear(); break;
                    }
                case 5:
                    {
                        ListenShutYourMouth();
                        Console.Clear();
                        Choice();
                        Console.Clear(); break;
                    }
                case 6:
                    {
                        ListenTragedy();
                        Console.Clear();
                        Choice();
                        Console.Clear(); break;
                    }
                case 7:
                    {
                        ListenImperialMarch();
                        Console.Clear();
                        Choice();
                        Console.Clear(); break;
                    }
                case 8:
                    {
                        Console.Clear();
                        Menu(); break;//выйти из приложения
                    }
                default:
                    {
                        Console.Clear(); 
                        goto Flag; 
                    }
            }
        }//Person listen to music

        static void Choice()
        {
            Flag:
            Console.WriteLine("Will you play this melody?");
            Console.WriteLine("Enter 1, if yes");
            Console.WriteLine("Enter 2, if no");
            string str;
            short choice;
            str = Console.ReadLine();
            choice = Convert.ToInt16(str);
            switch(choice)
            {
                case 1 :
                    {
                        Console.Clear();
                        if(ChoiceOfPeople==1)
                        {
                            TextJingleBells();
                        }
                        if (ChoiceOfPeople == 2)
                        {
                            TextSevenNationArmy();
                        }
                        if (ChoiceOfPeople == 3)
                        {
                            TextGeese();
                        }
                        if (ChoiceOfPeople == 4)
                        {
                            TextFirWasBorn();
                        }
                        if (ChoiceOfPeople == 5)
                        {
                            TextShutYourMouth();
                        }
                        if (ChoiceOfPeople == 6)
                        {
                            TextTragedy();
                        }
                        if (ChoiceOfPeople == 7)
                        {
                            TextImperialMarch();
                        }

                        Play();
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Menu();
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        goto Flag;
                    }
            }
        }//Person desides to play or not

        static void Play()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Enter ESC to exit");
            ConsoleKeyInfo keypress;
            while(true)
            {
                keypress = Console.ReadKey();
                if (keypress.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Menu();
                }
                //first octave
                if (keypress.Key==ConsoleKey.Q)
                {
                    Console.Beep(C4,600);
                }
                if (keypress.Key == ConsoleKey.W)
                {
                    Console.Beep(D4, 600);
                }
                if (keypress.Key == ConsoleKey.E)
                {
                    Console.Beep(E4, 600);
                }
                if (keypress.Key == ConsoleKey.R)
                {
                    Console.Beep(F4, 600);
                }
                if (keypress.Key == ConsoleKey.T)
                {
                    Console.Beep(G4, 600);
                }
                if (keypress.Key == ConsoleKey.Y)
                {
                    Console.Beep(A4, 600);
                }
                if (keypress.Key == ConsoleKey.U)
                {
                    Console.Beep(H2, 600);
                }
                //second octave
                if (keypress.Key == ConsoleKey.A)
                {
                    Console.Beep(C5, 600);
                }
                if (keypress.Key == ConsoleKey.S)
                {
                    Console.Beep(D5, 600);
                }
                if (keypress.Key == ConsoleKey.D)
                {
                    Console.Beep(E5, 600);
                }
                if (keypress.Key == ConsoleKey.F)
                {
                    Console.Beep(F5, 600);
                }
                if (keypress.Key == ConsoleKey.G)
                {
                    Console.Beep(G5, 600);
                }
                if (keypress.Key == ConsoleKey.H)
                {
                    Console.Beep(A5, 600);
                }
                if (keypress.Key == ConsoleKey.J)
                {
                    Console.Beep(H3, 600);
                }
                //third octave
                if (keypress.Key == ConsoleKey.Z)
                {
                    Console.Beep(C3, 600);
                }
                if (keypress.Key == ConsoleKey.X)
                {
                    Console.Beep(D6, 600);
                }
                if (keypress.Key == ConsoleKey.C)
                {
                    Console.Beep(D3, 600);
                }
                if (keypress.Key == ConsoleKey.V)
                {
                    Console.Beep(F6, 600);
                }
                if (keypress.Key == ConsoleKey.B)
                {
                    Console.Beep(G6, 600);
                }
                if (keypress.Key == ConsoleKey.N)
                {
                    Console.Beep(E3, 600);
                }
                if (keypress.Key == ConsoleKey.M)
                {
                    Console.Beep(G3, 600);
                }
                if (keypress.Key == ConsoleKey.I)//AB4
                {
                    Console.Beep(417, 600);
                }
                if (keypress.Key == ConsoleKey.O)//GB4
                {
                    Console.Beep(370, 600);
                }
                if (keypress.Key == ConsoleKey.P)//CB5
                {
                    Console.Beep(497, 600);
                }
                if (keypress.Key == ConsoleKey.K)//AB5
                {
                    Console.Beep(831, 600);
                }
                if (keypress.Key == ConsoleKey.L)//EB5
                {
                    Console.Beep(623, 600);
                }
                if (keypress.Key == ConsoleKey.NumPad1)//GB5
                {
                    Console.Beep(740, 600);
                }
                if (keypress.Key == ConsoleKey.NumPad2)//DB5
                {
                    Console.Beep(554, 600);
                }
                if (keypress.Key == ConsoleKey.NumPad3)//HB4
                {
                    Console.Beep(446, 600);
                }
                if (keypress.Key == ConsoleKey.NumPad4)//DB4
                {
                    Console.Beep(277, 600);
                }
                if (keypress.Key == ConsoleKey.NumPad5)//EB6
                {
                    Console.Beep(1245, 600);
                }

            }
        }//Person plays music

        static void TextJingleBells()
        {
            Console.WriteLine(" D       D       D   ");
            Console.WriteLine(" D       D       D   ");
            Console.WriteLine(" D       G       A       S       D     ");
            Console.WriteLine(" Q       W       E       F       F       F       D       F       D       D");
            Console.WriteLine(" D       S       S       D       S");
            Console.WriteLine(" G");   
        }

        static void TextGeese()
        {
            Console.WriteLine(" R       E       W       Q       T       T");
            Console.WriteLine(" R       E       W       Q       T       T");
            Console.WriteLine(" R       Y       Y       R       E       T       T       E ");
            Console.WriteLine(" W       E       R       W       Q       Q");
        }

        static void TextFirWasBorn()
        {
            Console.WriteLine("     Please press the numbers on the num lock!!   ");
            Console.WriteLine(" J       I       I       O       J       E       J       J");
            Console.WriteLine(" J       I       I       O       P       P");
            Console.WriteLine(" P       4       4       Y       Y       I       O       E ");
            Console.WriteLine(" J       I       I       O       I       E");
        }

        static void TextShutYourMouth()
        {
            Console.WriteLine(" A       G       A       K       G       F       G       F       G");
            Console.WriteLine(" K       K       G       F       A       G       A       K ");
            Console.WriteLine(" G       F       L       F       L       S       S      ");
            Console.WriteLine(" L       S       A ");
        }// change! 

        static void TextImperialMarch()
        {
            Console.WriteLine("     Please press the numbers on the num lock!!   ");
            Console.WriteLine(" Y       Y       Y       R       A       Y       R       A       Y ");
            Console.WriteLine(" D       D       D       F       A       I       R       A       Y  ");
            Console.WriteLine(" H       Y       Y       H       K       G       1   ");
            Console.WriteLine(" F       1       3       L       S       A       3       A ");
            Console.WriteLine(" R       I       R       Y       A       Y       A       D       H       Y       Y       D");
            Console.WriteLine(" K       G       1       F       1       3       L       A       3       A");
            Console.WriteLine(" R       I       R       A       Y       R       Q       Y");

        }  

        static void TextSevenNationArmy() 
        {
            Console.WriteLine("     Please press the numbers on the num lock!!   ");
            Console.WriteLine(" N       N       M       N       C       Z       U");
        }

        static void TextTragedy()
        {
            Console.WriteLine("     Please press the numbers on the num lock!!   ");
            Console.WriteLine(" B       B       B       5");
            Console.WriteLine(" V       V       V       X");
        }

        static void NoteForUser()
        {
            Console.WriteLine("     Please press the numbers on the num lock!!   ");
            Console.WriteLine(" ");
            Console.WriteLine(" I - Ab4     O - Gb4       P - Cb5       K - Ab5     L - Eb5");
            Console.WriteLine(" ");
            Console.WriteLine(" 1 - Gb5     2 - Db5       3 - Hb4       4 - Db4     5 - Eb6");
            Console.WriteLine(" ");
            Console.WriteLine(" U - H2");
            Console.WriteLine(" ");
            Console.WriteLine(" Z - C3      C - D3        N - E3        M - G3      J - H3");
            Console.WriteLine(" ");
            Console.WriteLine(" Q - C4      W - D4        E - E4        R - F4      T - G4      Y - A4");
            Console.WriteLine(" ");
            Console.WriteLine(" A - C5      S - D5        D - E5        F - F5      G - G5      H - A5");
            Console.WriteLine(" ");
            Console.WriteLine(" Z - C6      X - D6        C - E6        V - F6      B - G6      N - A6      M - H6");
            Console.WriteLine(" ");
            Console.WriteLine(" A - C5      S - D5        D - E5        F - F5      G - G5      H - A5");
        }

    }
}


