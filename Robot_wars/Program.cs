﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_wars
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robots = new Robot();

            var your_bot = robots.choose_bot();
            your_bot.set_attributes();
            your_bot.print_attributes();

            var cpu_bot = robots.get_cpu_bot();
            cpu_bot.set_random_attributes();
            cpu_bot.print_attributes();

            robots.loop_battle(your_bot, cpu_bot);
            
            Console.ReadKey();
        }
    }
}

//I have: created a list. 
//Returned robot objects from choose_bot method.
//Generated random attributes with switch case for CPU.
//Taken user input to append "name, weapon, hitpoints, and war cry"
//Created an if else statement to determine the winner of robot battle