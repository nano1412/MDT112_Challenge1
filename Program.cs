using System;

namespace Challenge{
          class Program{
                    static void Main(string[] args){
                              Threesome_01();                //No.01 ★
                              IsItTooMuch_02();              //No.02 ★
                              TwoPowerOfn_03();              //No.03 ★★☆
                              absolute_04();                 //No.04 ★★☆
                              roundtable_05();               //No.05 ★☆
                              BTS_06();                      //No.06 ★
                              JapaneseCalendar_07();         //No.07 ★★★
                              WarningSign_08();              //No.08 ★★*
                              OnlineShopping_09();           //No.09 ★
                              Doubledoor_10();               //No.10 ★
                              Hamlet_11();                   //No.11 ★☆
                              SquareAF_12();                 //No.12 ★★
                              GCD_13();                      //No.13 ★★☆
                              Triangle_14();                 //No.14 ★
                              RetiredYear_15();              //No.15 ★
                    }

                    static void Threesome_01(){
                              Console.Write("Please input number 1:");
                              int number1 = int.Parse(Console.ReadLine());
                              Console.Write("Please input number 2:");
                              int number2 = int.Parse(Console.ReadLine());
                              Console.Write("Please input number 3:");
                              int number3 = int.Parse(Console.ReadLine());

                              Console.Write("Sum: {0}",number1 + number2 + number3);
                    }

                    static void IsItTooMuch_02(){
                              double a = double.Parse(Console.ReadLine());
                              double b = double.Parse(Console.ReadLine());
                              double x = double.Parse(Console.ReadLine());

                              if(x >= a && x <= b){Console.Write("True");}
                              else{Console.Write("False");}
                    }

                    static void TwoPowerOfn_03(){
                              //2 stars
                              int n = int.Parse(Console.ReadLine());
                              Console.WriteLine("{0}", Math.Pow(2,n));
                    }

                    static void absolute_04(){
                              //2 stars
                              int x = int.Parse(Console.ReadLine());
                              Console.WriteLine("{0}", Math.Abs(x));
                    }

                    static void roundtable_05(){
                              //1 star
                              int x = int.Parse(Console.ReadLine());
                              for(int i = 0; i < 4; i++){
                                        x++;
                                        if(x > 8){x = 1;}
                                        Console.WriteLine("{0}",x);
                              }
                    }

                    static void BTS_06(){
                              Console.Write("Please input a number of stations:");
                              int station = int.Parse(Console.ReadLine());
                              int price = 16;

                              if(station >= 2){price+=7;}
                              if(station >= 8 && station <= 15){price = 44;}
                              if(station > 15){price = 59;}
                              if(station > 2 && station <8){
                                        for(int i = 3;i <= station; i++){
                                                  if(i % 2 == 1){
                                                            price+=3;
                                                  }
                                                  if(i % 2 == 0){
                                                            price+=4;
                                                  }     
                                        }
                              }
                              
                              Console.WriteLine("Cost (THB): {0}", price);
                    }

                    static void JapaneseCalendar_07(){
                              //3 stars
                              int year = int.Parse(Console.ReadLine());
                              int month = int.Parse(Console.ReadLine());
                              int day = int.Parse(Console.ReadLine());

                              if((year == 1912 && month == 7 && day <= 29) || (year == 1912 && month < 7) || year < 1912){
                                        Console.WriteLine("明治 meji");
                              }

                              if(((year == 1912 && month == 7 && day > 29) || (year == 1912 && month >= 7) || year > 1912) && ((year == 1926 && month == 12 && day <= 24) || (year == 1926 && month < 12) || year < 1926)){
                                        Console.WriteLine("大正 Taisho");
                              }

                              if(((year == 1926 && month == 12 && day > 24) || (year == 1926 && month >= 12) || year > 1926) && ((year == 1989 && month == 1 && day <= 7) || (year == 1989 && month < 1) || year < 1989)){
                                        Console.WriteLine("昭和 Showa");
                              }

                              if(((year == 1989 && month == 1 && day > 7) || (year == 1989 && month >= 1) || year > 1989) && ((year == 2019 && month == 4 && day <= 30) || (year == 2019 && month < 4) || year < 2019)){
                                        Console.WriteLine("平成 Heisei");
                              }

                              if((year == 2019 && month == 4 && day > 30) || (year == 2019 && month >= 4) || year > 2019){
                                        Console.WriteLine("令和 Reiwa");
                              }
                    }

                    static void WarningSign_08(){
                              //2 stars with error lol
                              int signal = int.Parse(Console.ReadLine());

                              string binary = Convert.ToString(signal, 2);
                              char[] reversedbinary = binary.ToCharArray();
                              Array.Reverse(reversedbinary);
                              
                              if(reversedbinary[0] == '1'){Console.WriteLine("yellow");}
                              if(reversedbinary[1] == '1'){Console.WriteLine("orange");}
                              if(reversedbinary[2] == '1'){Console.WriteLine("red");}
                    }

                    static void OnlineShopping_09(){
                              int lapee_promotion = int.Parse(Console.ReadLine());
                              int shopzada_promotion = int.Parse(Console.ReadLine());

                              double lapee_price = lapee_promotion * 100;
                              double shopzada_price = (100 * ((100 - shopzada_promotion)/100)) * (lapee_promotion + 1);

                              if(lapee_price > shopzada_price){
                                        Console.WriteLine("Shopzada");
                              } else if(lapee_price < shopzada_price){
                                        Console.WriteLine("Lapee");
                              } else {
                                        Console.WriteLine("E-mazon");
                              }
                    }

                    static void Doubledoor_10(){
                              string position = Console.ReadLine();

                              switch (position[0]){
                                        case '-':
                                                  Console.WriteLine("Please input a positive integer.");
                                        break;

                                        case char t when t >= '0' && t <= '9':
                                                  int number = int.Parse(position);

                                                  if(number % 2 == 0){
                                                            Console.WriteLine("{0}, {1}", number / 2, (number / 2) + 1);
                                                  } else {
                                                            Console.WriteLine("Please input an even positive integer.");
                                                  }
                                        break;

                                        default:
                                                  Console.WriteLine("Please input an integer");
                                        break;
                              }
                    }

                    static void Hamlet_11(){
                              //1 star
                              int number = int.Parse(Console.ReadLine());
                              for(int i = 1;i <= number;i++){
                                        Console.WriteLine("Hamlet");
                              }
                    }

                    static void SquareAF_12(){
                              //2 star
                              int number = int.Parse(Console.ReadLine());
                              Console.WriteLine("{0}", (number * ((number * number * 4) - 1)) / 3);
                    }

                    static void GCD_13(){
                              //2 star
                              int n = int.Parse(Console.ReadLine());
                              int[] number = new int[n];

                              for(int i = 0; i < n; i++){
                                        number[i] = int.Parse(Console.ReadLine());
                              }

                              int answer;      
                              for(int j = 0; j < n; j++){
                                        while(number[j] != 0 && number[j+1] != 0){
                                                  if(number[j + 1] == 0){
                                                            number[j] = number[j + 1];
                                                  }
                                                  
                                                  if(number[j] > number[j+1]){
                                                            number[j] %= number[j+1];
                                                  } else {
                                                            number[j+1] %= number[j];
                                                  }      
                                        }
                              }
                              if(number[n - 1] == 0){
                                        Console.WriteLine("{0}", number[n - 2]);
                              } else {
                                        Console.WriteLine("{0}", number[n - 1]);
                              }
                              
                    }

                    static void Triangle_14(){
                              int height = int.Parse(Console.ReadLine());
                              height--;
                              for(int i = 0; i < height; i++){
                                        for(int j = height; j > i; j--){
                                                  Console.Write(" ");     
                                        }
                                        if(i > 0){
                                                  Console.Write("*");
                                        }
                                        
                                        for(int k = 0;k < (i*2)-1;k++){        
                                                  Console.Write(" ");     
                                        }
                                        Console.WriteLine("*"); 
                              }
                              for(int i = 0; i < (height * 2)+1;i++){
                                        Console.Write("*");
                              }
                    }

                    static void RetiredYear_15(){
                              string job = "";
                              string job_first = "";

                              int year = 0;
                              int year_first = 2565;
                              int year_diff = 0;

                              while(year != 2565){
                                        job = Console.ReadLine();
                                        year = int.Parse(Console.ReadLine());

                                        if(year < year_first){
                                                  year_first = year;
                                                  job_first = job;
                                        }
                              }
                              year_diff = 2566 - year_first;

                              Console.WriteLine("{0}",job_first);
                              Console.WriteLine("{0}",year_first);
                              Console.WriteLine("{0}",job);
                              Console.WriteLine("2565");
                              Console.WriteLine("{0}",year_diff);
                    }
          }
}