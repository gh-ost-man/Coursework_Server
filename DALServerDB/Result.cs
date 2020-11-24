﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALServerDB
{
   public class Result
    {
        public int Id { get; set; }

        public User User { get; set; }

        public Test Test { get; set; }

        public int QtyOfRightAnswers { get; set; }

        public float Mark { get; set; }
    }
}
