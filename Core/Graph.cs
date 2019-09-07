using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    public class Graph<T>
    {
        private bool IsGuide = false;
        private Edge<T>[,] AdjacencMatrix;
        private HashTable<String, Vertex<T>> VerticesGroup;
        public Graph()
        {
            VerticesGroup = new HashTable<String, Vertex<T>>(40);
            AdjacencMatrix = new Edge<T>[HashTable<String, Vertex<T>>.GetPrimoN(40), HashTable<String, Vertex<T>>.GetPrimoN(40)];
        }
        public Graph(bool pIsGuide)
        {
            this.IsGuide = pIsGuide;
            VerticesGroup = new HashTable<String, Vertex<T>>(40);
            AdjacencMatrix = new Edge<T>[HashTable<String, Vertex<T>>.GetPrimoN(40), HashTable<String, Vertex<T>>.GetPrimoN(40)];
        }
        public bool InsertVertex(string pName, T pInfo)
        {
            return VerticesGroup.Insert(pName, new Vertex<T>(pName, pInfo));
        }
        public bool InsertEdge(string pVertexA, string pVertexB, double pWeight)
        {
            if (!(ExistEdge(pVertexA, pVertexB)))
            {
                CreateRelash(pVertexA, pVertexB, pWeight);
                return true;
            }
            return false;
        }
        public bool GetGuide()
        {
            return this.IsGuide;
        }
        public void SetGuide(bool pDirigido)
        {
            this.IsGuide = pDirigido;
        }

        private void CreateRelash(string pVertA, string pVertB, double pWeight = 0)
        {
            int indexA, indexB;
            indexA = VerticesGroup.GetIndex(pVertA);
            indexB = VerticesGroup.GetIndex(pVertB);
            if (indexA >= 0 && indexB >= 0)
            {
                AdjacencMatrix[indexA, indexB] = new Edge<T>(VerticesGroup.SearchByKey(pVertA), VerticesGroup.SearchByKey(pVertB), pWeight);
                if (!IsGuide)
                {
                    AdjacencMatrix[indexB, indexA] = new Edge<T>(VerticesGroup.SearchByKey(pVertB), VerticesGroup.SearchByKey(pVertA), pWeight);
                }

            }
        }
        private bool ExistVertex(string pVertA, string pVertB)
        {
            bool ifExist = false;
            int index1, index2;
            index1 = VerticesGroup.GetIndex(pVertA);
            index2 = VerticesGroup.GetIndex(pVertB);
            if (index1 >= 0 && index2 >= 0)
            {
                ifExist = true;
            }
            return ifExist;
        }
        private bool ExistEdge(string pVertA, string pVertB)
        {
            bool ifExists = false;
            int index1, index2;
            index1 = VerticesGroup.GetIndex(pVertA);
            index2 = VerticesGroup.GetIndex(pVertB);
            if (index1 >= 0 && index2 >= 0)
            {
                if (AdjacencMatrix[index1, index2] != null)
                {
                    ifExists = true;
                }
            }
            return ifExists;
        }
        public Edge<T> GetEdge(string pVertA, string pVertB)
        {
            int index1, index2;
            index1 = VerticesGroup.GetIndex(pVertA);
            index2 = VerticesGroup.GetIndex(pVertB);
            if (index1 >= 0 && index2 >= 0)
            {
                if (AdjacencMatrix[index1, index2] != null)
                {
                    return AdjacencMatrix[index1, index2];
                }
            }
            return null;
        }

        private Vertex<T> GetVertexByName(string pNameVertex)
        {
            int index_aux = VerticesGroup.GetIndex(pNameVertex);
            if (index_aux >= 0)
            {
                return VerticesGroup.GetForIndex(index_aux);
            }
            return null;
        }
        public ListD<T> GetLongestWay(string pNombreVerticeA, string pNombreVerticeB)
        {
            return null;
        }
        public ListD<Vertex<T>> GetListaSuccessors(string pVertice)
        {
            int index = VerticesGroup.GetIndex(pVertice);
            if (index >= 0)
            {
                ListD<Vertex<T>> ListVerticesSuccessors = new ListD<Vertex<T>>();
                for (int i = 0; i < AdjacencMatrix.GetLength(1); i++)
                {
                    if (AdjacencMatrix[index, i] != null)
                    {
                        ListVerticesSuccessors.InsertarAlFinal(AdjacencMatrix[index, i].GetVertB());
                    }
                }
                return ListVerticesSuccessors;
            }
            return null;
        }
        private ListD<Vertex<T>> GetListSuccessorNotVisited(string pVertice)
        {
            int index = VerticesGroup.GetIndex(pVertice);
            if (index >= 0)
            {
                ListD<Vertex<T>> ListVerticesSuce = new ListD<Vertex<T>>();
                for (int i = 0; i < AdjacencMatrix.GetLength(1); i++)
                {
                    if (AdjacencMatrix[index, i] != null && !AdjacencMatrix[index, i].GetVertB().IsVisit)
                    {
                        ListVerticesSuce.InsertarAlFinal(AdjacencMatrix[index, i].GetVertB());
                    }
                }
                return ListVerticesSuce;
            }
            return null;
        }
        public ListD<Vertex<T>> GetListPreSuce(string pVertice)
        {
            int index = VerticesGroup.GetIndex(pVertice);
            if (index >= 0)
            {
                ListD<Vertex<T>> ListVerticesPreSuc = new ListD<Vertex<T>>();
                for (int i = 0; i < AdjacencMatrix.GetLength(1); i++)
                {
                    if (AdjacencMatrix[index, i] != null)
                    {
                        ListVerticesPreSuc.InsertarAlFinal(AdjacencMatrix[i, index].GetVertA());
                    }
                }
                return ListVerticesPreSuc;
            }
            return null;
        }
        public Vertex<T> GetVerticeByName(string pNombre)
        {
            Vertex<T> vertice = VerticesGroup.SearchByKey(pNombre);
            if (vertice == null)
            {
                return null;
            }
            return vertice;
        }
        public string ShowAdjancMatrix()
        {
            string result = "", fila = "";
            for (int i = 0; i < AdjacencMatrix.GetLength(0); i++)
            {
                result += VerticesGroup.GetForIndex(i).Name + "|";
                fila += "\t" + VerticesGroup.GetForIndex(i).Name;
                for (int j = 0; j < AdjacencMatrix.GetLength(1); j++)
                {
                    if (AdjacencMatrix[i, j] == null)
                    {
                        result += "\tNULL";
                    }
                    else
                    {
                        result += "\t" + AdjacencMatrix[i, j].GetWeight();
                    }
                }
                result += "\n";
            }
            fila = fila + "\n" + result;
            result = fila;
            Console.WriteLine(result);
            return result;
        }
        private string ShowEdge()
        {
            string result = "";
            for (int i = 0; i < AdjacencMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < AdjacencMatrix.GetLength(1); j++)
                {
                    if (AdjacencMatrix[i, j] != null)
                    {
                        result += AdjacencMatrix[i, j].ToString(this.IsGuide);
                    }
                }
                result += "\n";
            }
            Console.WriteLine(result);
            return result;
        }
        public string ShowPreSuccesor(string pVertice)
        {
            string result = "";
            int index = VerticesGroup.GetIndex(pVertice);
            if (index >= 0)
            {
                for (int i = 0; i < AdjacencMatrix.GetLength(0); i++)
                {
                    if (AdjacencMatrix[i, index] != null)
                    {
                        result += AdjacencMatrix[i, index].GetVertA().Name;
                        result += "\n";
                    }
                }
            }
            Console.WriteLine(result);
            return result;
        }
        public string ShowSuccesors(string pVertice)
        {
            string result = "";
            int index = VerticesGroup.GetIndex(pVertice);
            if (index >= 0)
            {
                for (int i = 0; i < AdjacencMatrix.GetLength(1); i++)
                {
                    if (AdjacencMatrix[index, i] != null)
                    {
                        result += AdjacencMatrix[index, i].GetVertB().Name;
                        result += "\n";
                    }
                }
            }
            Console.WriteLine(result);
            return result;
        }
        private bool NegativeWeightatEdge()
        {
            for (int i = 0; i < AdjacencMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < AdjacencMatrix.GetLength(1); j++)
                {
                    if (AdjacencMatrix[i, j] != null)
                    {
                        if (AdjacencMatrix[i, j].GetWeight() < 0)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private void CleanVerticeVisit()
        {
            foreach (Data<string, Vertex<T>> Informacion in this.VerticesGroup.GetInitialInfo())
            {
                if (Informacion.GetInformation() != null)
                {
                    Informacion.GetInformation().IsVisit = false;
                }
            }
        }
        public ListD<Vertex<T>> MiniDijkstraWay(string pNombreVerticeA, string pNombreVerticeB)
        {
            if (pNombreVerticeA != pNombreVerticeB && !IsGuide)
            {
                if (this.NegativeWeightatEdge())
                {
                    throw new Exception("Existe algun valor negativo en el peso de los arcos");
                }
                HashTable<String, int> costosFinales = GetHashTableByDijkstra();
                HashTable<String, int> costosTemporales = GetHashTableByDijkstra();
                string clave = null;
                this.CleanVerticeVisit();
                ListD<Vertex<T>> ListaAuxiliarDSucesores, ListaSucesores = this.GetListaSuccessors(pNombreVerticeA);
                Vertex<T> verticeActual = this.GetVertexByName(pNombreVerticeA);
                verticeActual.IsVisit = true;
                Edge<T> arco = null;
                int peso = 0, costo = 0;
                Iterator<Vertex<T>> iterador = new Iterator<Vertex<T>>(ListaSucesores.GetCabeza());
                bool noSalir = true;
                costosTemporales.ActualizarDatoPorClave(pNombreVerticeA, 0);
                costosFinales.ActualizarDatoPorClave(pNombreVerticeA, 0);
                while (noSalir)
                {
                    for (Vertex<T> verticeAdyac = iterador.Next(); verticeAdyac != null; verticeAdyac = iterador.Next())
                    {
                        arco = GetEdge(verticeActual.Name, verticeAdyac.Name);
                        if (arco != null)
                        {
                            costo = (int)arco.GetWeight() + peso;
                            if (costosTemporales.SearchByKey(arco.GetVertB().Name) > costo || costosTemporales.SearchByKey(arco.GetVertB().Name) == -1)
                            {
                                costosTemporales.ActualizarDatoPorClave(arco.GetVertB().Name, costo);
                            }
                        }
                    }
                    int index = -1, auxiliar = 0;
                    clave = null;
                    for (int i = 0; i < costosTemporales.GetSize(); i++)
                    {
                        clave = costosTemporales.GetClave(i);
                        if ((auxiliar == 0 || auxiliar > costosTemporales.GetForIndex(i)) && (costosTemporales.GetForIndex(i) >= 0 && clave != null))
                        {
                            if (!VerticesGroup.SearchByKey(clave).IsVisit)
                            {
                                auxiliar = costosTemporales.GetForIndex(i);
                                index = i;
                            }
                        }
                    }
                    if (index != -1)
                    {
                        clave = costosTemporales.GetClave(index);
                        costosFinales.UpdateByIndex(index, auxiliar);
                        verticeActual = VerticesGroup.SearchByKey(clave);
                        verticeActual.IsVisit = true;
                    }
                    else
                    {
                        if (StopAnalisis())
                        {
                            noSalir = false;
                        }
                    }
                    ListaAuxiliarDSucesores = this.GetListSuccessorNotVisited(clave);
                    if (ListaAuxiliarDSucesores.GetCabeza() != null)
                    {
                        ListaSucesores = ListaAuxiliarDSucesores;
                    }
                    peso = auxiliar;
                    index = -1;
                    auxiliar = 0;
                    iterador = new Iterator<Vertex<T>>(ListaSucesores.GetCabeza());
                }
                ListD<Vertex<T>> ListaCaminoCorto = GetCaminoMinimo(costosFinales, pNombreVerticeB);
                return ListaCaminoCorto;
            }
            return null;
        }
        private HashTable<String, int> GetHashTableByDijkstra()
        {
            HashTable<String, int> tablasHas = new HashTable<string, int>(VerticesGroup.GetSize());
            string clave = null;
            for (int i = 0; i < this.VerticesGroup.GetSize(); i++)
            {
                if (this.VerticesGroup.GetForIndex(i) != null)
                {
                    clave = this.VerticesGroup.GetForIndex(i).Name;
                    tablasHas.Insert(clave, -1);
                }
            }
            return tablasHas;
        }
        private ListD<Vertex<T>> GetCaminoMinimo(HashTable<string, int> pVerticesFinales, string pVerticeDestino)
        {
            ListD<Vertex<T>> ListaCaminoCorto = new ListD<Vertex<T>>();
            ListaCaminoCorto.InsertarAlInicio(this.GetVertexByName(pVerticeDestino));
            ListD<Vertex<T>> ListaSucesores = this.GetListaSuccessors(pVerticeDestino);
            Iterator<Vertex<T>> iterador = new Iterator<Vertex<T>>(ListaSucesores.GetCabeza());
            Vertex<T> verticeActual = this.GetVertexByName(pVerticeDestino);
            Edge<T> arco = null;
            int pesoA, pesoB, pesoC, residuo;
            bool noSalir = true;
            while (noSalir)
            {
                for (Vertex<T> verticeAdyac = iterador.Next(); verticeAdyac != null; verticeAdyac = iterador.Next())
                {
                    arco = GetEdge(verticeActual.Name, verticeAdyac.Name);
                    if (arco != null)
                    {
                        pesoA = (int)arco.GetWeight();
                        pesoB = pVerticesFinales.SearchByKey(verticeActual.Name);
                        pesoC = pVerticesFinales.SearchByKey(verticeAdyac.Name);
                        residuo = pesoB - pesoA;
                        if (residuo == pesoC || residuo == 0)
                        {
                            ListaCaminoCorto.InsertarAlInicio(arco.GetVertB());
                            verticeActual = verticeAdyac;
                            verticeAdyac = null;
                            if (residuo == 0)
                            {
                                noSalir = false;
                            }
                        }
                    }
                }
                ListaSucesores = this.GetListaSuccessors(verticeActual.Name);
                iterador = new Iterator<Vertex<T>>(ListaSucesores.GetCabeza());
            }

            return ListaCaminoCorto;
        }
        private bool StopAnalisis()
        {
            for (int i = 0; i < VerticesGroup.GetSize(); i++)
            {
                if (VerticesGroup.GetForIndex(i) != null)
                {
                    if (!VerticesGroup.GetForIndex(i).IsVisit)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public override string ToString()
        {
            return ShowEdge();
        }


    }
}
