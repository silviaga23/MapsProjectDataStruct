using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    public class Vertex<T>
    {
        public string Name { get; set; }
        public T Info { get; set; }
        public bool IsVisit { get; set; }

        public Vertex(string pName)
        {
            this.Name = pName;
            this.IsVisit = false;
        }
        public Vertex(T pInfo)
        {
            this.Info = pInfo;
            this.IsVisit = false;
        }

        public Vertex(bool pIsVisit)
        {
            this.IsVisit = pIsVisit;
        }
        public Vertex(string pName, T pInfo)
        {
            this.Name = pName;
            this.Info = pInfo;
            this.IsVisit = false;
        }
        public Vertex(bool pIsVisit, string pName, T pInfo)
        {
            this.Name = pName;
            this.Info = pInfo;
            this.IsVisit = pIsVisit;
        }
    }
}
