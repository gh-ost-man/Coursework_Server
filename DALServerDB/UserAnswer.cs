﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALServerDB
{
    public class UserAnswer
    {
        public int Id { get; set; }

        public User User { get; set; }

        public Answer Answer { get; set; }
        public DateTime  DT { get; set; }
    }
}
