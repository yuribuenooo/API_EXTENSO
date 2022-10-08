using NUnit.Framework;
using API_EXTENSO;


namespace API_Extenso_TDD
{
    [TestFixture]

    public class TesteExtensoTDD

    {
        [TestCase("oito",8)]
        [TestCase("cinco", 5)]
        [TestCase("dois", 2)]
        public void TestarUnidade( string esperado, int valor) {
            
            Assert.That(esperado, Is.EqualTo (APiExtenso.Imprimir(valor)));
                }

        [Test]
            public void TestarDezena() {
            Assert.AreEqual("dezoito", APiExtenso.Imprimir(18));
            Assert.AreEqual("cinquenta e nove", APiExtenso.Imprimir(59));

        }

        [Test]

        public void TestarCentena() {

            Assert.AreEqual("cento e cinquenta e sete", APiExtenso.Imprimir(157));
        }

    }
}