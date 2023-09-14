using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Composite : IComponent
    {
        private string _name;
        private List<IComponent> components;

        public string Name { get => _name; set => _name = value; }
        public Composite(string name)
        {
            _name = name;
            components = new List<IComponent>();
        }

        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }

        public void Display(int margin = 0)
        {
            Console.WriteLine(new string('-', margin) + _name);
            foreach (var component in components)
            {
                component.Display(margin+2);
            }
        }

        public double GetAverageGrade()
        {
            double result = 0;
            foreach (var component in components)
            {
                int i = 0;
                while (i != components.Count - 1)
                {
                    result += component.GetAverageGrade();
                    i++;
                }
            }
            return result/components.Count;
            
        }

        public bool IsComposite() => true;
    }
}
