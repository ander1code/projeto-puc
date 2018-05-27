using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinMatriculaApp
{
    [TestFixture]
    public class ClasseTeste
    {
        //Implementação simples de teste unitário.
        [Test]
        public void TestarInformarMatricula()
        {
            string resultado = MatriculaTeste.InformarMatricula("9876");
            Assert.AreEqual("9876-E", resultado);
        }

        [Test]
        public void TestarVerificacaoMatriculaArquivo()
        {
            int resultado = MatriculaTeste.TestarVerificacaoMatriculaArquivo(@"matriculasParaVerificar.txt");
            Assert.AreEqual(1, resultado);
        }

        [Test]
        public void TestarVerificarMatriculaArquivo()
        {
            int resultado = MatriculaTeste.VerificarMatriculaArquivo(@"matriculasSemDV.txt");
            Assert.AreEqual(1, resultado);
        }
    }
}
