﻿using System;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Regex User Registration Problem");
            Pattern pattern = new Pattern();
            Console.WriteLine("Enter the first name");
            string fname = Console.ReadLine();
            pattern.validateName(fname);
            Console.WriteLine("Enter the Last name");
            string lastName = Console.ReadLine();
            pattern.validateName(lastName);
            Console.WriteLine("Enter the the email id");
            string email = Console.ReadLine();
            pattern.validateEmail(email);
            Console.WriteLine("Enter the the mobile num with country code");
            string mob = Console.ReadLine();
            pattern.validateMobile(mob);
        }
    }
}