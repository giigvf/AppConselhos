using System;
using System.Collections.Generic;
using System.Text;

namespace AppConselhos.Model
{
    class Conselho
    {
        public string ID { get; set; }
        public string Conselhos { get; set; }

        public Conselho()
        {
            this.ID = " ";
            this.Conselhos = " ";
        }
    }
}
