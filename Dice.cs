﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class Dice
    {
        public string type {  get; private set; }
        public int[] numbers { get; private set; } = {1,2,3,4,5,6 };
        public BugPart[] parts { get; private set; } = {
                    new BugPart(BugParts.Body, 1, 1),
                    new BugPart(BugParts.Head, 2, 2),
                    new BugPart(BugParts.Eyes, 4, 3),
                    new BugPart(BugParts.Antennaes, 5, 3),
                    new BugPart(BugParts.Legs, 3, 4),
                    new BugPart(BugParts.Tail, 6, 5) };


        /*
        public int Testresult = 0;
        public int count = 0;
        public bool oneLeg = true;
        */

    public Dice(String type)
        {
            this.type = type;
        }

        public IRollResult Roll() {
            Random randomResult = new Random();
            
            var result = randomResult.Next(0, 6);

            if (type == "numbers")
            {
                return new RollResultNumber(parts[result]);

            }
            else
            {
                /*
                if (count == 2)
                {
                    Testresult += 1;
                    count = 0;
                    if (Testresult == 5 && oneLeg)
                    {
                        count = 0;
                        Testresult = 4;
                        oneLeg = false;
                    }
                }

                count += 1;
                return new RollResultPart(parts[Testresult]);*/
        
                return new RollResultPart(parts[result]);

            }
        }
    }
}