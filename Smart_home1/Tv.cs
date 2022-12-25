using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_home1
{
    internal class Tv
    {
        int id;
        Boolean status;

        public Tv(int id, Boolean status)
        {
            this.id = id;
            this.status = status;
        }

        public int Id { get => id; set => id = value; }
        public Boolean Status { get => status; set => status = value; }
    }
}
