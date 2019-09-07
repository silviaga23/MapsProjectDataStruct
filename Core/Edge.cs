using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    public class Edge<T>
    {
        private double Weight;
        private string Label;
        private bool IsVisit;
        private Vertex<T> VertexA;
        private Vertex<T> VertexB;
        private T Information { get; set; }

        public T Info
        {
            get
            {
                return Information;
            }
            set
            {
                if (value != null)
                {
                    Information = value;
                }
            }
        }
        public Edge(Vertex<T> pVertA, Vertex<T> pVertB, double pWeight)
        {
            this.VertexA = pVertA;
            this.VertexB = pVertB;
            this.Weight = pWeight;
            this.IsVisit = false;
        }
        public Edge(string pLabel,Vertex<T> pVertA, Vertex<T> pVertB, double pWeight)

        {
            this.Weight = pWeight;
            this.Label = pLabel;
            this.IsVisit = false;
            this.VertexA = pVertA;
            this.VertexB = pVertB;
        }
        public Vertex<T> GetVertA()
        {
            return VertexA;
        }
        public void SetVertA(Vertex<T> pVertA)
        {
            this.VertexA = pVertA;
        }
        public Vertex<T> GetVertB()
        {
            return VertexB;
        }
        public void SetVertB(Vertex<T> pVertB)
        {
            this.VertexB = pVertB;
        }
        public double GetWeight()
        {
            return Weight;
        }
        public string GetLabel()
        {
            return this.Label;
        }
        public void SetWeigth(int pWeig)
        {
            this.Weight = pWeig;
        }
        public void SetLabel(string pLabel)
        {
            this.Label = pLabel;
        }
        public bool GetIsVisit()
        {
            return IsVisit;
        }
        public void SetVisit(bool pIsVisit)
        {
            this.IsVisit = pIsVisit;
        }
        public override String ToString()
        {
            return "(" + this.VertexA.Name + " ----- " + (this.Weight == 0 ? "" : "" + Weight) + " " + (this.Label == "" || this.Label == null ? "" : this.Label) + " ----- " + this.VertexB.Name + ")";
        }
        public String ToString(bool pGuid)
        {
            if (pGuid)
            {
                return "(" + this.VertexA.Name + " ----- " + (this.Weight == 0 ? "" : "" + Weight) + " " + (this.Label == "" || this.Label == null ? "" : this.Label) + " ----> " + this.VertexB.Name + ")";
            }
            return "(" + this.VertexA.Name + " ----- " + (this.Weight == 0 ? "" : "" + Weight) + " " + (this.Label == "" || this.Label == null ? "" : this.Label) + " ----- " + this.VertexB.Name + ")";
        }
    }
}
