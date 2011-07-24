using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using VPRCracha.Tests.Common;
using VPRCracha.Domain.Model.Repository.SQServer.Impl;

namespace VPRCracha.Tests.Repository
{
    [TestFixture]
    public class Dado_Um_Repositorio_De_Regiao
    {
        [Test]
        public void Setup()
        {
            var testeconexao = new RegiaoRepository();


            //_Repository = new Regiao
            //Assert.IsTrue(true);
        }
    }
}
