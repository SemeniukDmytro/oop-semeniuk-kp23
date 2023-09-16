using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal interface IComponent
    {
        string Name { get; set; }

        public void Display(int margin);
        public double GetAverageGrade();
        public bool IsComposite();
    }
}
