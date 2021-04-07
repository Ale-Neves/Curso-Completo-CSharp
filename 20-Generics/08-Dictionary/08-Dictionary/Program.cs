using System;
using System.Collections.Generic;

namespace _08_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando 
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "alexandre";
            cookies["email"] = "alexandre@gmail.com";
            cookies["phone"] = "99712345";
            cookies["phone"] = "997321321";

            Console.WriteLine(cookies["email"]); //return: alexandre@gmail.com
            Console.WriteLine(cookies["phone"]); // return: 997321321

            cookies.Remove("email");

            if(cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count); // return: 2

            Console.WriteLine("ALL COOKIES: ");
            foreach(KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
