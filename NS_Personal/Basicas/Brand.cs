﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NS_Personal.Basicas
{
    class Brand
    {

        Guid id;
        string name;

       
        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
