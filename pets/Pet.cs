using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Pet
    {
        private Specie specie;
        private string name;

        public Pet(Specie specie, string name )

        {
            this.name = name;
            this.specie = specie;

        }
    }


}
