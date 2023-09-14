using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Minutes
    {
        private int _withinUkraine;
        private int _inRoaming;
        public int InRoaming { get => _inRoaming;}
        public int WithinUkraine { get => _withinUkraine; }
        public Minutes(int withinUkraine, int inRoaming)
        {
            _inRoaming = inRoaming;
            _withinUkraine = withinUkraine;
        }

        

    }
}
