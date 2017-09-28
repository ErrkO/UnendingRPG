using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnendingRPG
{

    public class Item
    {

        private string name;

        public string Name
        {

            get
            {

                return this.name;

            }

            set
            {

                this.name = value;

            }

        }

        public Item()
        {



        }

        public Item(string name)
        {

            Name = name;

        }

        public Item(Item item)
        {

            Name = item.name;

        }

    }

}
