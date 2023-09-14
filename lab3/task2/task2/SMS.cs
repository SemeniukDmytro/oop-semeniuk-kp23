using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class SMS
    {
        private int _withinUkraine;
        private int _inRoaming;
        public int InRoaming { get => _inRoaming; }
        public int WithinUkraine { get => _withinUkraine; }
        public SMS(int withinUkraine, int inRoaming)
        {
            _inRoaming = inRoaming;
            _withinUkraine = withinUkraine;
        }
    }
}
