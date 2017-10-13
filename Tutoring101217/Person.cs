using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoring101217
{
    class Person
    {
        public bool IsAlive { get; set; }
        public bool HasFace { get; set; }

        public Person()
        {

        }

        public Person(bool isAlive, bool hasFace)
        {
            this.IsAlive = isAlive;
            this.HasFace = hasFace;
        }

    }
}
