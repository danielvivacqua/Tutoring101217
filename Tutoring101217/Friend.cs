using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoring101217
{
    class Friend : Person
    {
        public bool IsFriendly { get; set; }
        public string Name { get; set; }

        public Friend() : base()
        {

        }

        public Friend(bool isFriendly) : base(true,true)
        {
            this.IsFriendly = isFriendly;
        }
    }
}
