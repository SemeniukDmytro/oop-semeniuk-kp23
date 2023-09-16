using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class BFS : Iterator
    {
        Person current;
        List<Person> visited;
        Queue<Person> queue;

        public BFS(Person current)
        {
            this.current = current;
            visited = new List<Person> ();
            queue = new Queue<Person> ();
            queue.Enqueue (current);
        }

        private void InitializeBFS()
        {
            visited.Clear();
            queue.Clear();
            queue.Enqueue(current);
            visited.Add(current);
        }

        public override Person Current()
        {
            if (queue.Count == 0)
            {
                throw new InvalidOperationException("Enumeration has not started or has already finished.");
            }

            return current;
        }

        public override bool MoveNext()
        {
            if (queue.Count == 0)
            {
                return false;
            }

            current = queue.Dequeue(); 
            foreach (var friend in current.GetAllFriends())
            {
                if (!visited.Contains(friend))
                {
                    queue.Enqueue(friend);
                    visited.Add(friend);
                }
            }

            return true;
        }

        public override void Reset()
        {
            InitializeBFS();
        }
    }
}
