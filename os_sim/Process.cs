using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os_sim
{
    class Process
    {
        private int id;
        private int arrival_cycle;
        private int total_cycles;
        private int current_cycles;
        private int total_cpu;
        private int current_cpu;
        private int total_io1;
        private int current_io1;
        public Process(int next_id, int cycle, int avrg, Random rand)
        {
            id = next_id;
            arrival_cycle = cycle;
            total_cycles = rand.Next(Convert.ToInt32(avrg*0.25), Convert.ToInt32(avrg*0.75));
            total_cpu = rand.Next(1,total_cycles);
            total_io1 = rand.Next(0,total_cycles-total_cpu);
            current_cycles = 0;
            current_cpu = 0;
            current_io1 = 0;
        }
        public string getData()
        {
            string data = String.Format("{0}\t,{1}\t,{2}\t,{3}\t,{4}\t,{5}\t,{6}\t,{7}",
                id,arrival_cycle,total_cycles,current_cycles,total_cpu,current_cpu,total_io1,current_io1);
            return data;
        }
        public string getId()
        { return ""+id; }
    }
}
