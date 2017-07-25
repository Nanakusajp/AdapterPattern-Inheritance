﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_Inheritance
{
    public class PrintBanner : Banner, IPrint
    {
        public PrintBanner(String str) : base(str)
        {
        }

        public void PrintStrong()
        {
            ShowWithParen();
        }

        public void PrintWeak()
        {
            ShowWithAster();
        }
    }
}
