using Microsoft.VisualStudio.TestTools.UnitTesting;
using Linkedin.DogMeasures.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linkedin.DogMeasures.Models;

namespace Linkedin.DogMeasures.Services.Tests
{
    [TestClass()]
    public class ServicioParaProbarTests
    {
        ServicioParaProbar _servicio = new();
        [TestMethod()]
        public void ServicioParaProbarCreacion()
        {
            Assert.IsNotNull(_servicio);
            Assert.IsInstanceOfType(_servicio,typeof(ServicioParaProbar));
        }
        [TestMethod()]
        public void ServicioParaProbarCreacionConLista()
        {
            Assert.IsNotNull(_servicio);
            Assert.IsInstanceOfType(_servicio, typeof(ServicioParaProbar));
            Assert.AreEqual(3, _servicio._weightInfos.Count);
            Assert.IsInstanceOfType(_servicio._weightInfos[0], typeof(DogWeightInfo));

        }
        [TestMethod()]
        public void DameDesviacionTestFlaco()
        {
            Assert.AreEqual(1.0M, _servicio.DameDesviacion(DogWeightInfo.WeightDeviationType.BelowWeight));
        }

        [TestMethod()]
        public void DameDesviacionTestNormal()
        {
            Assert.AreEqual(0.5M, _servicio.DameDesviacion(DogWeightInfo.WeightDeviationType.InRange));
        }

        [TestMethod()]
        public void DameDesviacionTestGordo()
        {
            Assert.AreEqual(0.8M, _servicio.DameDesviacion(DogWeightInfo.WeightDeviationType.Overweight));
        }
    }
}