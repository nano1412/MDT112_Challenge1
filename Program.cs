using System;

namespace Challenge{
          class Program{
                    static void Main(string[] args){
                              Threesome_01_1of1();          //No.01 ★

                              IsItTooMuch_02_1of1();        //No.02 ★

                              TwoPowerOfn_03_1of3();        //No.03 ★☆☆
                              TwoPowerOfn_03_2of3();        //No.03 ★★☆
                              TwoPowerOfn_03_3of3();        //No.03 ★★★

                              absolute_04_1of3();           //N0.04 ★☆☆
                              absolute_04_2of3();           //No.04 ★★☆
                              absolute_04_3of3();           //No.04 ★★★

                              roundtable_05_1of2();         //No.05 ★☆
                              roundtable_05_2of2();         //No.05 ★★

                              BTS_06_1of1();                //No.06 ★
                              BTS_06_3if();                 //No.06 ★ with 3 if

                              JapaneseCalendar_07_3of3();   //No.07 ★★★

                              WarningSign_08_2of2();        //No.08 ★★

                              OnlineShopping_09_1of1();     //No.09 ★

                              Doubledoor_10_1of1();         //No.10 ★

                              Hamlet_11_1of2();             //No.11 ★☆

                              SquareAF_12_2of2();           //No.12 ★★

                              GCD_13_2of3();                //No.13 ★★☆

                              Triangle_14_1of1();           //No.14 ★

                              RetiredYear_15_1of1();        //No.15 ★
                    }

                    static void Threesome_01_1of1(){
                              Console.Write("Please input number 1:");
                              int number1 = int.Parse(Console.ReadLine());
                              Console.Write("Please input number 2:");
                              int number2 = int.Parse(Console.ReadLine());
                              Console.Write("Please input number 3:");
                              int number3 = int.Parse(Console.ReadLine());

                              Console.Write("Sum: {0}",number1 + number2 + number3);
                    }

                    static void IsItTooMuch_02_1of1(){
                              double a = double.Parse(Console.ReadLine());
                              double b = double.Parse(Console.ReadLine());
                              double x = double.Parse(Console.ReadLine());

                              if(x >= a && x <= b){Console.Write("True");}
                              else{Console.Write("False");}
                    }

                    static void TwoPowerOfn_03_1of3(){
                              int n = int.Parse(Console.ReadLine());
                              int answer = 2;
                              while(n > 1){
                                        answer = answer * 2;
                                        n--;
                              }
                              Console.WriteLine(answer);
                    }

                    static void TwoPowerOfn_03_2of3(){
                              //2 stars
                              int n = int.Parse(Console.ReadLine());
                              Console.WriteLine(Math.Pow(2,n));
                    }

                    static void TwoPowerOfn_03_3of3(){
                              //3 stars
                              int n = int.Parse(Console.ReadLine());
                              int answer = 1;
                              answer = answer << n;
                              Console.WriteLine(answer);
                    }

                    static void absolute_04_1of3(){
                              //1 star
                              int x = int.Parse(Console.ReadLine());
                              if(x < 0){
                                        x = -x;
                              }
                              Console.WriteLine(x);
                    }

                    static void absolute_04_2of3(){
                              //2 stars
                              int x = int.Parse(Console.ReadLine());
                              Console.WriteLine(Math.Abs(x));
                    }

                    static void absolute_04_3of3(){
                              //3 stars
                              int x = int.Parse(Console.ReadLine());
                              Console.WriteLine((x ^ (x >> 31)) - (x >> 31));
                    }

                    static void roundtable_05_1of2(){
                              //1 star
                              int x = int.Parse(Console.ReadLine());
                              for(int i = 0; i < 4; i++){
                                        x++;
                                        if(x > 8){x = 1;}
                                        Console.WriteLine("{0}",x);
                              }
                    }

                    static void roundtable_05_2of2(){
                              //2 stars
                              int x = int.Parse(Console.ReadLine());

                              Console.WriteLine(((x++) % 8)+1);
                              Console.WriteLine(((x++) % 8)+1);
                              Console.WriteLine(((x++) % 8)+1);
                              Console.WriteLine(((x++) % 8)+1);
                    }

                    static void BTS_06_1of1(){
                              Console.Write("Please input a number of stations:");
                              int station = int.Parse(Console.ReadLine());
                              int price = 16;

                              if(station >= 2){price+=7;}
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
                              if(station >= 8 && station <= 15){price = 44;}
                              if(station > 15){price = 59;}    

                              Console.WriteLine("Cost (THB): {0}", price);
                    }

                    static void BTS_06_3if(){
                              int station = int.Parse(Console.ReadLine());
                              int price = 16 + 7 * (station / 2);

                              if(station % 2 != 0 && station > 2){price += 3;}
                              if(station > 8){price = 44;}
                              if(station > 15){price = 59;}

                              Console.WriteLine("Cost (THB): {0}", price);
                    }

                    static void JapaneseCalendar_07_3of3(){
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

                    static void WarningSign_08_2of2(){
                              //2 stars 
                              int signal = int.Parse(Console.ReadLine());

                              string binary = Convert.ToString(signal + 8, 2);
                              char[] reversedbinary = binary.ToCharArray();
                              Array.Reverse(reversedbinary);
                              
                              if(reversedbinary[0] == '1'){Console.WriteLine("yellow");}
                              if(reversedbinary[1] == '1'){Console.WriteLine("orange");}
                              if(reversedbinary[2] == '1'){Console.WriteLine("red");}
                    }

                    static void OnlineShopping_09_1of1(){
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

                    static void Doubledoor_10_1of1(){
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

                    static void Hamlet_11_1of2(){
                              //1 star
                              int number = int.Parse(Console.ReadLine());
                              for(int i = 1;i <= number;i++){
                                        Console.WriteLine("Hamlet");
                              }
                    }

                    static void SquareAF_12_2of2(){
                              //2 star
                              int number = int.Parse(Console.ReadLine());
                              Console.WriteLine("{0}", (number * ((number * number * 4) - 1)) / 3);
                    }

                    static void GCD_13_2of3(){
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

                    static void Triangle_14_1of1(){
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

                    static void RetiredYear_15_1of1(){
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