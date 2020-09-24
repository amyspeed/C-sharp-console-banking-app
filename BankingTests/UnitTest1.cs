using System;
using banking_class_library;
using Xunit;

namespace BankingTests
{
    public class UnitTest1
    {
        [Fact]
        public void TrueIsTrue()
        {
            Assert.True(true);
        }

        [Fact]
        public void CantTakeMoreThanYouHave()
        {
            var account = new BankAccount("Amy", 2000);


            //Test for negative balace:
            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(3000, DateTime.Now, "Attempt to Overdraw")
            );
        }

        [Fact]
        public void NeedMoneyToStart()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new BankAccount("invalid", -55)
            );
        }
    }
}
