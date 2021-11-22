using Microsoft.VisualStudio.TestTools.UnitTesting;
using Archivos;
using System.Collections.Generic;
using System.Text.Json;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GuardarLeerArchivo()
        {
            List<float> lista = new List<float>();
            JsonFiler<List<float>> json = new JsonFiler<List<float>>();
        }
        [TestMethod]
        [ExpectedException(typeof(ErrorArchivosExcepction))]
        public void GuardarLeerArchivoException()
        {
            List<float> juegos = new List<float>();
            JsonFiler<List<float>> json = new JsonFiler<List<float>>();

            json.Guardar(" ", juegos);
        }

    }
}
