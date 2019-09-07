using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    class Data<Key, T> : Object
    {
        private T Information;
        private Key key;
        private int Status = 0;

        public Data()
        {
            this.key = default(Key);
            this.Information = default(T);
            this.Status = 0;
        }
        public Data(Key key, T objectt)
        {
            this.key = key;
            this.Information = objectt;
            this.Status = 2;
        }
        public Data(Key key)
        {
            this.Information = default(T);
            this.key = key;
            this.Status = 1;
        }
        public T GetInformation()
        {
            return this.Information;
        }


        public bool SetObject(T obje)
        {
            if (obje != null)
            {
                this.Information = obje;
                return true;
            }
            return false;
        }
        public int GetStatus()
        {
            return this.Status;
        }

        public bool SetStatus(int pstatus)
        {
            if (pstatus >= 0 && pstatus <= 2)
            {
                this.Status = pstatus;
                return true;
            }
            throw new Exception("El estado del componente debe estar entre 0 y 2 donde, 0 es nulo, 1 es borrado y 2 en uso");
        }

        public Key GetKey()
        {
            return this.key;
        }

        public bool SetKey(Key pKey)
        {
            if (pKey != null)
            {
                this.key = pKey;
                return true;
            }
            return false;
        }
        
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        public override String ToString()
        {
            if (this.Status == 2)
            {
                return ("La clave: " + this.key.ToString() + " del objeto es: " + this.Information.ToString() + "\n");
            }
            return "";
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                throw new Exception("No se puede agregar un objeto nulo");
            }
            Data<Key, T> x = (Data<Key, T>)obj;
            return (this.key.Equals(x.GetKey()));
        }
    }
}
