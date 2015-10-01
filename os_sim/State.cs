using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os_sim
{
    class State : Queue<Process>
    {
        private int size;
        public State(int s)
        {
            size = s;
        }
        public State()
        {
            size = -1;
        }
        public void addProcess(Process new_process)
        {
            if (Count < size || size == -1)
                Enqueue(new_process);
        }
        public void resize(int s)
        {
            size = s;
        }
    }
}
