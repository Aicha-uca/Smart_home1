using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_home1
{
    internal class lampe
    {
        int id;
        Boolean status;

        public lampe(int id, bool status)
        {
            this.Id = id;
            this.Status = status;
        }

        public int Id { get => id; set => id = value; }
        public bool Status { get => status; set => status = value; }
    }
}
