
using Bank;

namespace BankTests
{
    [TestClass]
    public sealed class BanckAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            //Arange
            double saldoInicial = 11.99;
            double quantidaDebito = 4.55;
            double expectativa = 7.44;
            BankAccount conta = new("Isaac Oliveira Loiola", saldoInicial);

            //Act
            conta.Debit(quantidaDebito);

            //Assert
            double atual = conta.Balance;
            Assert.AreEqual(expectativa, atual, 0.001, "Conta não debitada corretamente");
        }
    }
}
