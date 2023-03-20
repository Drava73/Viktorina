﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viktorina
{
    public interface IQuizBiology 
    {
        string[] questions { get; }
        string[][] answers { get; }
        int[] correctAnswers { get; }
        int bal { get; }

        void RunB();
    }
}
