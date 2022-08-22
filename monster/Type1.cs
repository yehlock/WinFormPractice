using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monster
{
    internal class Type1 : Monster
    {
        public Type1(int id, String name)
        {
            monster_id = id;
            monster_name = name;
            monster_type = "Type1";
            time = 3;
        }
    }
}
