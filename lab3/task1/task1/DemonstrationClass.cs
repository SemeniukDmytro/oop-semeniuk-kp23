using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class DemonstrationClass
    {
        public static void Demonstrate()
        {
            Composite course = new Composite("course");

            Composite streamKV2x = new Composite("kv2x");
            Composite streamKP2x = new Composite("kp2x");

            Composite kp23 = new Composite("kp23");
            Composite kp22 = new Composite("kp22");

            Composite kv23 = new Composite("kv23");
            Composite kv22 = new Composite("kv22");

            Student Dimas = new Student("Dimas", new List<int> { 20, 40, 30 });
            Student Glibas = new Student("Glibas", new List<int> { 40, 60, 50 });

            kp23.AddComponent(Dimas);
            kp23.AddComponent(Glibas);

            Student Jordan = new Student("Jordan", new List<int> { 20, 20, 20 });
            Student George = new Student("George", new List<int> { 30, 30, 30 });

            kp22.AddComponent(Jordan);
            kp22.AddComponent(George);

            Student Andrew = new Student("Andrew", new List<int> { 20, 40, 30 });
            Student Tristan = new Student("Tristan", new List<int> { 40, 60, 50 });

            kv23.AddComponent(Andrew);
            kv23.AddComponent(Tristan);

            Student Monica = new Student("Monica", new List<int> { 20, 20, 20 });
            Student Sally = new Student("Sally", new List<int> { 30, 30, 30 });

            kv22.AddComponent(Monica);
            kv22.AddComponent(Sally);

            streamKP2x.AddComponent(kp22);
            streamKP2x.AddComponent(kp23);
            streamKV2x.AddComponent(kv22);
            streamKV2x.AddComponent(kv23);
            course.AddComponent(streamKV2x);
            course.AddComponent(streamKP2x);

            course.Display();
            Console.WriteLine($"Average grade on course: {course.GetAverageGrade()}");
        }
    }
}
