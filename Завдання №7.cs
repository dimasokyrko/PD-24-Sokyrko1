using System;

namespace Lab_7
{
    /*Написати програму, що виконує наступні функції:
1. Виводить на екран введене число з клавіатури в зворотному порядку(1234-&gt;4321)
2. Виводить будь-яку строку в зворотному порядку(АБВ-&gt; ВБА)
3. Дробові числа виводяться в зворотному порядку і ціла частина і дробова(123.456-
&gt;321.654)
4. Виводити будь-яку строку в зворотному порядку і всі елементи після “магічного
знаку” теж в зворотному(АБВ, ГДЕ-&gt; ВБА,ЕДГ)
5. Реалізувати пункти 1-4 за допомогою методів, перевантаживши методи для різних
типів
6. Реалізувати пункти 1-4 за допомогою рекурсії, методи для різних типів
перевантажити
7. Реалізувати метод, що буде масив повертати задом навпаки(Використання
Array.Reverse() заборонено!)
8. Виконати пункт 7 з використанням ключових слів ref i out*/
    class Program
    {
        static char[] method(char[] a, char[] b)
        {
            int j = 0;
            for (int i = b.Length; i > 0; i--)
            {

                a[j] = b[i - 1];
                j++;
            }
            return a;
        }

        static string revers_arr(string a)       //не використовується
        {
            char[] arr_f = a.ToCharArray();
            char[] arr_char_revers = new char[a.Length];
            int j = 0;
            for (int i = a.Length; i > 0; i--)
            {

                arr_char_revers[j] = a[i - 1];
                j++;
            }
            string revers_string = new string(arr_char_revers);
            return revers_string;
        }

        static char[] revers_arr(char[] a) //7
        {
            char[] arr_char_revers = new char[a.Length];
            int j = 0;
            for (int i = a.Length; i > 0; i--)
            {

                arr_char_revers[j] = a[i - 1];
                j++;
            }
            for (int i = 0; i < a.Length; i++)
            {

                a[i] = arr_char_revers[i];
                j++;
            }
            return a;
        }

        static void revers_arr(ref char[] a) //8
        {
            char[] arr_char_revers = new char[a.Length];
            int j = 0;
            for (int i = a.Length; i > 0; i--)
            {

                arr_char_revers[j] = a[i - 1];
                j++;
            }
            for (int i = 0; i < a.Length; i++)
            {

                a[i] = arr_char_revers[i];
                j++;
            }
        }

        static void Main(string[] args)
        {
            int v = 1;
            do
            {
                if (v < 1 || v > 8)
                {
                    Console.WriteLine("Select Task 1 or 2 or 3 or 4 or 5 or 6 or 7 or 8");
                }
                Console.WriteLine("Select a task (1-8):");
                v = Convert.ToInt32(Console.ReadLine());
                switch (v)
                {
                    case 1:
                        {
                            string enter_number;
                            char[] arr_char;

                            Console.WriteLine("Enter the number:");
                            enter_number = Console.ReadLine();
                            arr_char = enter_number.ToCharArray();
                            char[] arr_char_revers = new char[arr_char.Length];

                            int j = 0;
                            for (int i = arr_char.Length; i > 0; i--)
                            {

                                arr_char_revers[j] = arr_char[i - 1];
                                j++;
                            }
                            string revers_number = new string(arr_char_revers);
                            Console.WriteLine("{0}", revers_number);
                            break;
                        }
                    case 2:
                        {
                            string enter_string;
                            char[] arr_char;

                            Console.WriteLine("Enter the string:");
                            enter_string = Console.ReadLine(); 
                            arr_char = enter_string.ToCharArray();
                            char[] arr_char_revers = new char[arr_char.Length];

                            int j = 0;
                            for (int i = arr_char.Length; i > 0; i--)
                            {

                                arr_char_revers[j] = arr_char[i - 1];
                                j++;
                            }
                            string revers_string = new string(arr_char_revers);
                            Console.WriteLine("{0}", revers_string);
                            break;
                        }
                    case 3:
                        {
                            string enter_string;
                            char[] arr_char;

                            Console.WriteLine("Enter the fractional number:");
                            enter_string = Console.ReadLine();   
                            arr_char = enter_string.ToCharArray();

                            char[] arr_char_revers = new char[arr_char.Length];

                            int k = 0;

                            for (int i = 0; i < arr_char.Length; i++) //підрахунок знаків разом з крапкою
                            {
                                if (arr_char[i] == '.')
                                {
                                    k = i + 1;
                                }

                            }

                            char[] a = new char[k];
                            char[] b = new char[(arr_char.Length) - k];

                            int j_1 = 0;                        
                            for (int i = k - 2; i >= 0; i--)
                            {
                                a[j_1] = arr_char[i];
                                j_1++;
                            }
                            a[k - 1] = '.';  

                            int j_2 = 0;                                  
                            for (int i = arr_char.Length - 1; i > k - 1; i--)
                            {
                                b[j_2] = arr_char[i];
                                j_2++;
                            }

                            for (int i = 0; i < k; i++)
                            {
                                arr_char_revers[i] = a[i];

                            }

                            int j_3 = 0;                                
                            for (int i = k; i < arr_char.Length; i++)
                            {
                                arr_char_revers[i] = b[j_3];
                                j_3++;

                            }

                            string revers_string = new string(arr_char_revers);
                            Console.WriteLine("{0}", revers_string);
                            break;
                        }
                    case 4:
                        {
                            string enter_string;
                            char[] arr_char;

                            Console.WriteLine("Enter the string:");
                            enter_string = Console.ReadLine();      
                            arr_char = enter_string.ToCharArray();

                            char[] arr_char_revers = new char[arr_char.Length];

                            int k = 0;

                            for (int i = 0; i < arr_char.Length; i++) //підрахунок знаків разом з маг.знак
                            {
                                if (arr_char[i] == '.')
                                {
                                    k = i + 1;
                                }

                            }

                            char[] a = new char[k];
                            char[] b = new char[(arr_char.Length) - k];

                            int j_1 = 0;                   
                            for (int i = k - 2; i >= 0; i--)
                            {
                                a[j_1] = arr_char[i];
                                j_1++;
                            }
                            a[k - 1] = ','; 

                            int j_2 = 0;                     
                            for (int i = arr_char.Length - 1; i > k - 1; i--)
                            {
                                b[j_2] = arr_char[i];
                                j_2++;
                            }

                            for (int i = 0; i < k; i++)
                            {
                                arr_char_revers[i] = a[i];

                            }

                            int j_3 = 0;
                            for (int i = k; i < arr_char.Length; i++)
                            {
                                arr_char_revers[i] = b[j_3];
                                j_3++;

                            }

                            string revers_string = new string(arr_char_revers);
                            Console.WriteLine("{0}", revers_string);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Select a task (1-4)");
                            int v_1 = Convert.ToInt32(Console.ReadLine());
                            switch (v_1)
                            {
                                case 1:
                                    {
                                        string enter_number;
                                        char[] arr_char;

                                        Console.WriteLine("Enter the number:");
                                        enter_number = Console.ReadLine();
                                        arr_char = enter_number.ToCharArray();
                                        char[] arr_char_revers = new char[arr_char.Length];


                                        string revers_number = new string(method(arr_char_revers, arr_char));
                                        Console.WriteLine("{0}", revers_number);
                                        break;
                                    }
                                case 2:
                                    {
                                        string enter_string;
                                        char[] arr_char;

                                        Console.WriteLine("Enter the string:");
                                        enter_string = Console.ReadLine();   
                                        arr_char = enter_string.ToCharArray();
                                        char[] arr_char_revers = new char[arr_char.Length];


                                        string revers_string = new string(method(arr_char_revers, arr_char));
                                        Console.WriteLine("{0}", revers_string);
                                        break;
                                    }
                                case 3:
                                    {
                                        string enter_string;
                                        char[] arr_char;

                                        Console.WriteLine("Enter the fractional number:");
                                        enter_string = Console.ReadLine();    
                                        arr_char = enter_string.ToCharArray();

                                        char[] arr_char_revers = new char[arr_char.Length];

                                        int k = 0;

                                        for (int i = 0; i < arr_char.Length; i++) //підрахунок знаків разом з крапкою
                                        {
                                            if (arr_char[i] == '.')
                                            {
                                                k = i + 1;
                                            }

                                        }

                                        char[] a = new char[k];
                                        char[] b = new char[(arr_char.Length) - k];

                                        int j_1 = 0;                 
                                        for (int i = k - 2; i >= 0; i--)
                                        {
                                            a[j_1] = arr_char[i];
                                            j_1++;
                                        }
                                        a[k - 1] = '.';

                                        int j_2 = 0;                            
                                        for (int i = arr_char.Length - 1; i > k - 1; i--)
                                        {
                                            b[j_2] = arr_char[i];
                                            j_2++;
                                        }

                                        for (int i = 0; i < k; i++)
                                        {
                                            arr_char_revers[i] = a[i];

                                        }

                                        int j_3 = 0;           
                                        for (int i = k; i < arr_char.Length; i++)
                                        {
                                            arr_char_revers[i] = b[j_3];
                                            j_3++;

                                        }

                                        string revers_string = new string(arr_char_revers);
                                        Console.WriteLine("{0}", revers_string);
                                        break;
                                    }
                                case 4:
                                    {
                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }
                            break;
                        }
                    case 6:
                        {
                            break;
                        }
                    case 7:
                        {
                            string arr_str;
                            char[] arr_c;
                            Console.WriteLine("Enter array:");
                            arr_str = Console.ReadLine();
                            arr_c = arr_str.ToCharArray();
                            arr_str = new string(revers_arr(arr_c));
                            Console.WriteLine(arr_str);
                            break;
                        }
                    case 8:
                        {
                            string arr_str;
                            string l = "abcd";
                            char[] arr_c = l.ToCharArray();
                            Console.WriteLine("Enter array:");
                            arr_str = Console.ReadLine();

                            arr_c = arr_str.ToCharArray();
                            revers_arr(ref arr_c);
                            arr_str = new string(arr_c);
                            Console.WriteLine(arr_str);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            } while (v < 1 || v > 8);
            Console.ReadKey();
        }
    }
}