﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_de_la_vie
{
    public class Cell
    {
        public bool IsAlive { get; set; }
        public bool NextState { get; set; }

        public Cell(bool state)
        {

        }

        public void ComeAlive()
        {
            NextState = true;
        }

        public void PassAway()
        {

        }

        public void Update()
        {

        }
    }
}