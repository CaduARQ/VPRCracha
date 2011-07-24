using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using VPRCracha.Tests.Common;

namespace VPRCracha.Tests.Repository
{
    [TestFixture]
    public class CriaSessao
    {
        [Test]
        public void CriaConexao()
        {
            var teste = new TestSessionFactorySQLLite();

            var sessao = teste.CreateSession();

            Assert.IsTrue(sessao.IsOpen);
        }
    }
}
