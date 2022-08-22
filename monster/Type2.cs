using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace monster
{
    internal class Type2 : Monster
    {
        public Type2(int id,string name)
        {
            monster_id = id;
            monster_name = name;
            monster_type = "Type2";
            time = 7;
        }
    }
}
