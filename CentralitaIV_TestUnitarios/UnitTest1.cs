using CentralitaIV_Entidades;

namespace CentralitaIV_TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerificarInstanciaListaLlamadas_CuandoSeCreeInstanciaCentralita_ListaLlamadasDeberiaEstarInstanciada()
        {
            //Arrange
            List<Llamada> actual;

            //Act - ejecutar método
            Centralita centralita = new Centralita();
            actual = centralita.Llamadas;

            //Assert - Verificar que el resultado obtenido coincida con el esperado
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void LanzarCentralitaException_CuandoSeCargueLlamadaLocalRepetida_DeberiaLanzarCentralitaException()
        {
            //Arrange
            Local local1 = new Local(21, "100", "200", 20);
            Local local2 = new Local(21, "100", "200", 20);
            Centralita centralita = new Centralita("PanchoDotto");

            //Act
            centralita += local1;
            centralita += local2;
        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void LanzarCentralitaException_CuandoSeCargueLlamadaProvincialRepetida_DeberiaLanzarCentralitaException()
        {
            //Arrange
            Provincial provincial1 = new Provincial(21, "100", "200", Provincial.Franja.Franja_1);
            Provincial provincial2 = new Provincial(21, "100", "200", Provincial.Franja.Franja_1);
            Centralita centralita = new Centralita("PanchoDotto");

            //Act
            centralita += provincial1;
            centralita += provincial2;
        }
    }
}