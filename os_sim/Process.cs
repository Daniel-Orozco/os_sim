using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os_sim
{
    public class Process
    {
        public int id;                 //ID
        public int arrival_cycle;      //Tiempo de llegada
        public int total_cpu;          //Uso de CPU
        public int current_cpu;        //Tiempo acum. de uso de CPU

        public int total_cycles;       //

        public int current_cycles;     //Tiempo en el sistema
        public int total_io1;          //Tiempo de uso de I/O
        public int current_io1;        //Tiempo
        public int io1_arrival;        //Hora de uso de I/O
        public int finishing_cycle;    //Tiempo finalizacion

        public int time_in_system;
        public int idle_time;

        public int size;
        public int frames;
        public float wait_ratio;

        public int quantum;

        public string status;
        public Process(int next_id, int cycle, int avrg, Random rand, int q, int iouse, int iochance, int frame_size)
        {
            id = next_id;
            arrival_cycle = cycle;

            if (rand.Next(0, 101) <= iochance)
                total_io1 = rand.Next(Convert.ToInt32(iouse * 0.75), Convert.ToInt32(iouse * 1.25));
            else
                total_io1 = 0;
            total_cpu = rand.Next(Convert.ToInt32(avrg * 0.75), Convert.ToInt32(avrg * 1.25));

            size = rand.Next(1,256);

            frames = Convert.ToInt32((size / frame_size)+(size%frame_size==0?0:1));

            current_cycles = 0;
            current_cpu = 0;
            current_io1 = 0;

            wait_ratio = 0;

            quantum = q;

            status = "In System";
        }
        public string[] getValues(int clock)
        {
            string[] data = new string[]{getID(), ""+arrival_cycle, ""+total_cpu, ""+current_cpu, ""+(clock - arrival_cycle), ""+total_io1, ""+current_io1, (status != "In System" ? "" + finishing_cycle : "-"), "" + time_in_system, (status != "In System" ? (idle_time < 0 ? "-" : ("" + idle_time)) : "-"), status, ""+size, ""+frames, ""+wait_ratio};
            return data;
        }
        public string getID()
        { return "P" + (id < 10 ? "0" : "") + id; }
    }
}
