using System;
using AtmMachine;
using Xunit;

namespace AtmTests
{
    public class AtmTesting
    {
        [Fact]
        public void ReturnCurrentBalance()
        {
            Program.balance = 10;
            Assert.Equal(10, Program.ViewBalance());
        }

        [Fact]
        public void ReturnIncorrectBalance()
        {
            Program.balance = 300.00M;
            Assert.NotEqual(200, Program.ViewBalance());
        }

        [Fact]
        public void OverDrawAmount()
        {
            Program.balance = 200.00M;
            Assert.Equal(200.00M, Program.Withdraw(300));
        }
        [Fact]
        public void WithdrawAmount()
        {
            Program.balance = 2000.50M;
            Assert.Equal(1900, Program.Withdraw(100.50M));
        }

        [Fact]
        public void DepositAmount()
        {
            Program.balance = 200.00M;
            Assert.Equal(1200, Program.Deposit(1000M));
        }
        [Fact]
        public void InvalidDepositUpdate()
        {
            Program.balance = 200.00M;
            Assert.NotEqual(800, Program.Deposit(1000M));
        }
        
    }
}
