using lab02_unit_testing;
using Xunit;

namespace XUnitTestProject_UnitTesting
{
    public class UnitTest1
    {

        //[Theory]
        //[InlineData(100)]
        //// [InlineData(500)]
        //// [InlineData(600)]

        //public void CanReturnNewBalance(decimal amtToWithdraw)
        //{

        //    // Assert
        //    Program.balance = 500m;


        //    decimal newBalance = Program.WithdrawFunds(amtToWithdraw);
        //    decimal comparisonNumber = 400m;

        //    Assert.Equal(Program.balance, comparisonNumber);
        //}

        [Fact]
        public void CanReturnNewBalanceFromWithdrawFunds()
        {
            // Arrange
            // Set initial account balance that Program.WithdrawFunds below will use
            Program.balance = 1000m;

            // Act
            decimal newBalanceAfterWithdraw = Program.WithdrawFunds(50m);
            
            // Assert
            Assert.Equal(950m, newBalanceAfterWithdraw);
        }

        [Fact]
        public void CannotOverdrawAccount()
        {
            // Arrange
            Program.balance = 500m;

            // Act
            decimal balanceAfterOverdraw = Program.WithdrawFunds(600m);

            // Assert
            Assert.NotEqual(-100m, balanceAfterOverdraw);
        }

        [Fact]
        public void CanReturnNewBalanceFromDepositFunds()
        {
            // Arrange
            Program.balance = 1000m;

            // Act
            decimal newBalanceAfterDeposit = Program.DepositFunds(200m);

            // Assert
            Assert.Equal(1200m, newBalanceAfterDeposit); // TODO Fix, but not sure why it's not working
        }

        [Fact]
        public void CannotDepositNegativeAmount()
        {
            // Arrange
            Program.balance = 200m;

            // Act
            decimal balanceAfterNegativeDeposit = Program.DepositFunds(-10m);

            // Assert
            Assert.NotEqual(190m, balanceAfterNegativeDeposit); // TODO Fix, but not sure why it's not working
        }
    }
}
