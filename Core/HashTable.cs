using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    class HashTable<Key, T>
    {
        private int NumberInfo;
        private int Size;
        private Data<Key, T>[] Vector;

        public HashTable()
        {
            this.NumberInfo = 0;
            this.Size = GetPrimoN(40);
            this.Vector = new Data<Key, T>[this.Size];
            this.InitialiceList();
        }
        public HashTable(int pSize)
        {
            this.NumberInfo = 0;
            this.Size = GetPrimoN(pSize);
            this.Vector = new Data<Key, T>[this.Size];
            this.InitialiceList();
        }
        private int Hashing_One(int pkey)
        {
            return (pkey % this.Size);
        }
        private int Hashing_Two(int pkey)
        {
            return 1 + (pkey % (this.Size - 1));
        }
        private int DobleHashing(Key Key, int index)
        {
            int hash = Key.GetHashCode();
            hash = Math.Abs(hash);
            return (Hashing_One(hash) + ((index * Hashing_Two(hash)) % Size));
        }
        public bool Insert(Key key, T pobject)
        {

            bool result = false, isTableFull = true;
            int position, i;

            for (i = 0; i < Size; i++)
            {
                position = DobleHashing(key, i);

                if (position > Size - 1)
                {
                    position -= Size;
                }
                if (Vector[position] == null || Vector[position].GetStatus() == 0)
                {
                    Vector[position].SetKey(key);
                    Vector[position].SetObject(pobject);
                    Vector[position].SetStatus(2);
                    this.NumberInfo = NumberInfo + 1;
                    isTableFull = false;
                    result = true;
                    break;
                }
                else
                {
                    Console.WriteLine("\nColision en la posición : " + position);
                }
            }
            if (isTableFull)
            {
                throw new IndexOutOfRangeException("La Tabla esta llena");
            }
            return result;
        }
        public bool ActualizarDatoPorClave(Key pKey, T pInfo)
        {
            int index = this.GetIndex(pKey);
            if (index >= 0)
            {
                Vector[index].SetObject(pInfo);
                return true;
            }
            return false;
        }
        public bool UpdateByIndex(int pIndex, T pDato)
        {
            if (pIndex >= 0)
            {
                Vector[pIndex].SetObject(pDato);
                return true;
            }
            return false;
        }
        public int GetIndex(Key key)
        {
            int posicion, i;
            for (i = 0; i < Size; i++)
            {
                posicion = DobleHashing(key, i);

                if (posicion > Size - 1)
                {
                    posicion -= Size;
                }
                if (Vector[posicion].GetKey().Equals(key) && Vector[posicion].GetStatus() == 2)
                {
                    return posicion;
                }
            }
            return -1;
        }
        public Key GetClave(int pIndex)
        {
            if (pIndex > -1 && pIndex < this.Size)
            {
                return Vector[pIndex].GetKey();
            }
            return default(Key);
        }
        public T GetForIndex(int pIndex)
        {
            if (pIndex > -1 && pIndex < this.Size)
            {
                return Vector[pIndex].GetInformation();
            }
            return default(T);
        }
        public Data<Key, T>[] GetInitialInfo()
        {
            return Vector;
        }
        public T SearchByKey(Key pKey)
        {
            bool isfindOne = false;
            int position, i;
            for (i = 0; i < Size; i++)
            {
                position = DobleHashing(pKey, i);

                if (position > Size - 1)
                {
                    position -= Size;
                }
                if (Vector[position].GetKey() != null)
                {
                    if (pKey.GetType() == typeof(string) && Vector[position].GetKey().GetType() == typeof(string) && Vector[position].GetStatus() == 2)
                    {
                        if (pKey.ToString().Equals(Vector[position].GetKey().ToString()))
                        {
                            return Vector[position].GetInformation();
                        }
                    }
                    else if (Vector[position].GetStatus().Equals(pKey) && Vector[position].GetStatus() == 2)
                    {
                        return Vector[position].GetInformation();
                    }
                }
            }
            if (!isfindOne)
            {
                // "No hay resultados";
                this.ToString();
            }
            return default(T);
        }
        private void InitialiceList()
        {
            for (int i = 0; i < this.Vector.Length; i++)
            {
                if (this.Vector[i] == null)
                {
                    this.Vector[i] = new Data<Key, T>();
                }
            }
        }
        public void ReHashing()
        {
            int size = GetPrimoN(this.Size * 2);
            this.Size = size;
            Data<Key, T>[] newVector = new Data<Key, T>[size];
            Vector.CopyTo(newVector, 0);
            Vector = newVector;
            InitialiceList();
        }
        public static int GetPrimoN(int pnum)
        {
            if (!IsPrimo(pnum))
            {
                while (!IsPrimo(pnum))
                {
                    pnum += 1;
                }
            }
            return pnum;
        }
        private static bool IsPrimo(int pnum)
        {
            int aux = 0;
            for (int i = 1; i < (pnum + 1); i++)
            {
                if (pnum % i == 0)
                {
                    aux++;
                }
            }
            if (aux != 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public int GetSize()
        {
            return this.Size;
        }
        public override String ToString()
        {
            String msg = "";
            for (int i = 0; i < this.Vector.Length; i++)
            {
                if (this.Vector[i] != null)
                {
                    msg += "Funcion Hash  " + i + " de la tabla Hash  ==> " + this.Vector[i].ToString() + "\n";

                }
            }
            return msg;
        }
        public bool IsEmpty()
        {
            return (this.NumberInfo == 0);
        }
    }
}
