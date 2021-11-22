﻿/*using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using Archivos;

using WinFormsAppEscuela;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GuardarLeerArchivo() 
        {
            string archivo = "prueba";
           
            List<int> lista = new List<int>()
            {
            new List(10, new object())
            };
            JsonFiler<List<int>> json = new JsonFiler<List<int>>();


            json.Guardar(archivo, lista);

            json.Leer(archivo, out juegosTest);

            Assert.AreEqual(juegos[0].Ubicacion, lista[0].Ubicacion);

        }



        [TestMethod]
        [ExpectedException(typeof(ErrorArchivosExcepction))]
        public void GuardarLeerArchivoException()
        {
            List<Juego> juegos = new List<Juego>()
            {
                new Juego(10, new object())
            };
            JsonFiler<List<Juego>> json = new JsonFiler<List<Juego>>();

            json.Guardar(" ", juegos);
        }

        [TestMethod]
        public void AvanzarJuego()
        {
            Juego j = new Juego(10, new object());
            j.Velocidad = 15;
            short expexted = j.Avanzar();

            Assert.AreEqual(expexted, 25);
        }
    }
}*/
