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

        public int quantum;

        public string status;
        public Process(int next_id, int cycle, int avrg, Random rand, int q)
        {
            id = next_id;
            arrival_cycle = cycle;

            //total_cycles = rand.Next(Convert.ToInt32(avrg*0.75), Convert.ToInt32(avrg*1.25));
            total_io1 = rand.Next(0, 20);
            total_cpu = rand.Next(Convert.ToInt32(avrg * 0.75), Convert.ToInt32(avrg * 1.25));

            current_cycles = 0;
            current_cpu = 0;
            current_io1 = 0;

            quantum = q;

            status = "In System";
        }

        public string getData(int clock)
        {
            string data = String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\r\n",
                getID(), arrival_cycle, total_cpu, current_cpu, clock - arrival_cycle, total_io1, current_io1, (status!="In System"?""+finishing_cycle:"-"), (status!="In System"?""+time_in_system:"-"), (status!="In System"?(idle_time<0?"-":(""+idle_time)):"-"),status);
            return data;
        }
        public string getID()
        { return "P" + (id < 10 ? "0" : "") + id; }
    }
}
