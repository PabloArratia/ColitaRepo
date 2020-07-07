using System;
using System.Collections.Generic;
using System.Text;
using ColitaWeb.DataAccess;
using ColitaWeb.Models;
using NUnit.Framework;

namespace ColitaUnitTest
{
    public class ColitaEFTest
    {
        [Test]
        [Author("Pablo Arratia", "Arratia.Ch.Pablo@gmail.com")]
        [Description("Testeando tu colita")]
        public void TestDeColita()
        {
            var unitOfWork = new UnitOfWork();
            var idColita = new Guid("{e0938b38-ed12-417d-bce0-38add17c4bfa}");

            var colitaDeBarron = new ColitaEF()
            {
                Id = idColita,
                ColitaName = "ColitaDeBarron",
                ColitaDescription = "sin comentarios",
                EstadoDeColita = EstadoDeColita.CheMugrero,
                IsActive = true,
                TimeStamp = DateTime.Now
            };

            unitOfWork.ColitaEFRepository.Insert(colitaDeBarron);
            var colitaResponse = unitOfWork.Save();

            Assert.IsTrue(colitaResponse.Success);

            var colitaById = unitOfWork.ColitaEFRepository.GetByID(idColita);

            Assert.IsNotNull(colitaById);
            Assert.AreEqual(colitaById.ColitaName, "ColitaDeBarron");
            Assert.AreEqual(colitaById.EstadoDeColita, EstadoDeColita.CheMugrero);
        }
        [Test]
        [Author("Pablo Arratia", "Arratia.Ch.Pablo@gmail.com")]
        [Description("Testeando tu colita | delete")]
        public void TestDeColita_Delete()
        {
            var unitOfWork = new UnitOfWork();
            var idColita = new Guid("{e0938b38-ed12-417d-bce0-38add17c4bfa}");
            unitOfWork.ColitaEFRepository.Delete(idColita);
            var deleteRes = unitOfWork.Save();
            Assert.IsTrue(deleteRes.Success);
        }
    }
}
