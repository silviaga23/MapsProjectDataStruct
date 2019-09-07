using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    public class Gestor
    {
        private static Gestor Instancia;
        private Graph<Place> Graph;
        private Gestor()
        {
            Graph = new Graph<Place>(false);
        }
        public static Gestor GetInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new Gestor();
            }
            return Instancia;
        }
        public bool InsertarVertice(string pNombre, double pLongitud, double pLatitud)
        {
            return Graph.InsertVertex(pNombre, new Place(pNombre, pLatitud, pLongitud));
        }
        public bool InsertarArco(string pNombreVerticeA, string pNombreVerticeB, double pPeso)
        {
            return Graph.InsertEdge(pNombreVerticeA, pNombreVerticeB, pPeso);
        }
        public List<Place> GetRutaMinimaDijkstra(string pNombreVerticeA, string pNombreVerticeB)
        {
            try
            {
                ListD<Vertex<Place>> ListaCaminoMinimo = Graph.MiniDijkstraWay(pNombreVerticeA, pNombreVerticeB);
                if (ListaCaminoMinimo != null)
                {
                    List<Place> ListaLugares = new List<Place>();
                    Iterator<Vertex<Place>> iterador = new Iterator<Vertex<Place>>(ListaCaminoMinimo.GetCabeza());
                    for (Vertex<Place> verticeAdyac = iterador.Next(); verticeAdyac != null; verticeAdyac = iterador.Next())
                    {
                        ListaLugares.Add(verticeAdyac.Info);
                    }
                    return ListaLugares;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
        public Edge<Place> GetArco(string pNombreVerticeA, string pNombreVerticeB)
        {
            Edge<Place> Arco = Graph.GetEdge(pNombreVerticeA, pNombreVerticeB);
            if (Arco != null)
            {
                return Arco;
            }
            Console.WriteLine("No se encontro arco que conecte los vertices " + pNombreVerticeA + " y " + pNombreVerticeB);
            return null;
        }
        public Place BuscarVerticePorNombre(string pNombreVertice)
        {
            Vertex<Place> verticeEncontrado = Graph.GetVerticeByName(pNombreVertice);
            if (verticeEncontrado == null)
            {
                Console.WriteLine("No se encontro vertice con el nombre de " + pNombreVertice);
                return null;
            }
            return verticeEncontrado.Info;
        }
        public List<Place> ObtenerVerticesAyacentes(string pNombreVertice)
        {
            ListD<Vertex<Place>> ListaAyacentes = Graph.GetListaSuccessors(pNombreVertice);
            if (ListaAyacentes != null)
            {
                List<Place> ListaLugaresAyacentes = new List<Place>();
                Iterator<Vertex<Place>> iterador = new Iterator<Vertex<Place>>(ListaAyacentes.GetCabeza());
                for (Vertex<Place> verticeAdyac = iterador.Next(); verticeAdyac != null; verticeAdyac = iterador.Next())
                {
                    ListaLugaresAyacentes.Add(verticeAdyac.Info);
                }

                return ListaLugaresAyacentes;
            }
            Console.WriteLine("No se encontraron vertices ayacentes para el vertice " + pNombreVertice + " !");
            return null;
        }
    }
}
