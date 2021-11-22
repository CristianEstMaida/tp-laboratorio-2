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
            //string archivo = "prueba";

            List<float> lista = new List<float>()
            {
            //new List(10, new object())
            };
            JsonFiler<List<float>> json = new JsonFiler<List<float>>();


            //json.Guardar(archivo, lista);

            //json.Leer(archivo, out juegosTest);

            //Assert.AreEqual(juegos[0].Ubicacion, lista[0].Ubicacion);
        }
        [TestMethod]
        [ExpectedException(typeof(ErrorArchivosExcepction))]
        public void GuardarLeerArchivoException()
        {
            List<float> juegos = new List<float>()
            {
                //new Juego(10, new object())
            };
            JsonFiler<List<float>> json = new JsonFiler<List<float>>();

            json.Guardar(" ", juegos);
        }

    }
}
