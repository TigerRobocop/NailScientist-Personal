using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NS_Personal.Basicas
{
    class Polish
    {
        Guid iD;
        string name;
        string color;
        string brand;
        string finish;


        public Guid ID
        {
            get { return iD; }
            set { iD = value; }
        }       

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string Color
        {
            get { return color; }
            set { color = value; }
        }        

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }       

        public string Finish
        {
            get { return finish; }
            set { finish = value; }
        }
    }
}
