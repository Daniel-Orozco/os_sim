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
        public float wait_ratio;

        public Frame[] pages;

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

            pages = new Frame[Convert.ToInt32((size / frame_size) + (size % frame_size == 0 ? 0 : 1))];

            for(int i = 0; i < pages.Length; i++)
                pages[i] = new Frame(id, i, frame_size);

            current_cycles = 0;
            current_cpu = 0;
            current_io1 = 0;

            wait_ratio = 0;

            quantum = q;

            status = "In System";
        }
        public string[] getFrames()
        {
            string[] frames = new string[pages.Length];
            for (int i = 0; i < frames.Length; i++)
                frames[i] = ""+getID()+";"+(i+1)+";"+pages[i].Location+";"+pages[i].Requests+";"+pages[i].Ramtime+";";
            return frames;
        }
        public string[] getValues(int clock)
        {
            wait_ratio = (int)100*(current_cpu+current_io1)/(clock - arrival_cycle != 0 ? clock - arrival_cycle : 1);
            string[] data = new string[]{getID(), ""+arrival_cycle, ""+total_cpu, ""+current_cpu, ""+(clock - arrival_cycle), ""+total_io1, ""+current_io1, (status != "In System" ? "" + finishing_cycle : "-"), "" + time_in_system, (status != "In System" ? (idle_time < 0 ? "-" : ("" + idle_time)) : "-"), status, ""+size, ""+pages.Length, ""+wait_ratio};
            return data;
        }
        public string getID()
        { return "P" + (id < 10 ? "0" : "") + id; }
    }
}
