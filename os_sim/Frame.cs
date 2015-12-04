using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os_sim
{
    public class Frame
    {
        public int process_id;
        public string location;
        public int frame_id;
        public int requests;
        public int ramtime;
        public int size;

        public Frame(int p_id, int f_id, int s)
        {
            process_id = p_id;
            location = "Disk";
            frame_id = f_id;
            requests = 0;
            ramtime = 0;
            size = s;
        }
    }
}
