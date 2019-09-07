
using Newtonsoft.Json;
using System;
using System.IO;
using System.Web.Script.Serialization;

namespace BackEnd
{
    public class JsonSeriza
    {
        private static JsonSeriza Instancia;
        private object Data;
        private string RutaDirecctorio;
        private JavaScriptSerializer Serializer = new JavaScriptSerializer();
        private JsonSeriza()
        {
            this.Data = null;
            this.RutaDirecctorio = "null";
            this.CargarDatosDesdeArchivo();
        }
        public static JsonSeriza GetInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new JsonSeriza();
            }
            return Instancia;
        }
        private void CargarDatosDesdeArchivo()
        {
            this.RutaDirecctorio = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\Json\");
            if (!Directory.Exists(this.RutaDirecctorio))
            {
                Directory.CreateDirectory(this.RutaDirecctorio);
            }
            Environment.CurrentDirectory = this.RutaDirecctorio;
            DirectoryInfo infoDir = new DirectoryInfo(".");
            this.RutaDirecctorio = infoDir.FullName;
            Console.WriteLine("Directory Info:   " + this.RutaDirecctorio);
        }
        public object GetDatosDelArchivoJson(string pNombreArchivo)
        {
            string path = @"" + this.RutaDirecctorio + @"\" + pNombreArchivo + ".json";
            if (pNombreArchivo.Trim() != "" && File.Exists(path))
            {
                String salidaJSON = File.ReadAllText(path);
                this.Data = Serializer.Deserialize<object>(salidaJSON);
                return this.Data;
            }
            return null;
        }

        private T Deserialize<T>(string salidaJSON)
        {
            throw new NotImplementedException();
        }

        public string CrearArchivoJsonApartirDeUnObjeto(object pObjeto, string pNombreArchivo)
        {
            string path = @"" + this.RutaDirecctorio + @"\" + pNombreArchivo + ".json";
            if (pNombreArchivo.Trim() != "" && !File.Exists(path))
            {
                String salidaJSON = JsonConvert.SerializeObject(pObjeto);
                File.WriteAllText(path, salidaJSON);
                return path;
            }
            return "No se logro crear el archivo Json!. Verique el nombre del archivo, puede que ya exista.";
        }
        public string ActualizarArchivoJsonApartirDeUnObjeto(Object pObjeto, string pNombreArchivo)
        {
            string path = @"" + this.RutaDirecctorio + @"\" + pNombreArchivo + ".json";
            if (pNombreArchivo.Trim() != "" && File.Exists(path))
            {
                String salidaJSON = JsonConvert.SerializeObject(pObjeto);
                File.WriteAllText(path, salidaJSON);
                return path;
            }
            return "No se logro actualizar el archivo Json!. Verique el nombre del archivo, puede que no exista.";
        }
    }
}
