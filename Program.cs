using System;

namespace Challenge{
          class Program{
                    static void Main(string[] args){
                              //Threesome();
                              //IsItTooMuch();
                              //TwoPowerOfn();
                              //absolute();
                              //roundtable();
                              //BTS();
                              //JapaneseCalendar();
                              //WarningSign(); //it's literally binary convertor
                              //OnlineShopping();
                              Doubledoor();
                    }

                    static void Threesome(){
                              Console.Write("Please input number 1:");
                              int number1 = int.Parse(Console.ReadLine());
                              Console.Write("Please input number 2:");
                              int number2 = int.Parse(Console.ReadLine());
                              Console.Write("Please input number 3:");
                              int number3 = int.Parse(Console.ReadLine());

                              Console.Write("Sum: {0}",number1 + number2 + number3);
                    }

                    static void IsItTooMuch(){
                              double a = double.Parse(Console.ReadLine());
                              double b = double.Parse(Console.ReadLine());
                              double x = double.Parse(Console.ReadLine());

                              if(x >= a && x <= b){Console.Write("True");}
                              else{Console.Write("False");}
                    }

                    static void TwoPowerOfn(){
                              //2 stars
                              int n = int.Parse(Console.ReadLine());
                              Console.WriteLine("{0}", Math.Pow(2,n));
                    }

                    static void absolute(){
                              //2 stars
                              int x = int.Parse(Console.ReadLine());
                              Console.WriteLine("{0}", Math.Abs(x));
                    }

                    static void roundtable(){
                              //1 star
                              int x = int.Parse(Console.ReadLine());
                              for(int i = 0; i < 4; i++){
                                        x++;
                                        if(x > 8){x = 1;}
                                        Console.WriteLine("{0}",x);
                              }
                    }

                    static void BTS(){
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

                    static void JapaneseCalendar(){
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

                    static void WarningSign(){
                              //2 stars with error lol
                              int signal = int.Parse(Console.ReadLine());

                              string binary = Convert.ToString(signal, 2);
                              char[] reversedbinary = binary.ToCharArray();
                              Array.Reverse(reversedbinary);
                              
                              if(reversedbinary[0] == '1'){Console.WriteLine("yellow");}
                              if(reversedbinary[1] == '1'){Console.WriteLine("orange");}
                              if(reversedbinary[2] == '1'){Console.WriteLine("red");}
                    }

                    static void OnlineShopping(){
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

                    static void Doubledoor(){
                              
                    }
          }
}