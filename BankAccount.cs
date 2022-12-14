using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        //create the -->field<-- of type double named balance with a value of 0
        private double balance = 0;
        //Define a -->method<-- named Deposit that will accept a double and store that value in the balance field
        public void Deposit(double amountToDeposit)
        {
            balance += amountToDeposit;
        }
        //Define a -->method<-- named GetBalance that will return the amount stored in the balance field
        public string GetBalance()
        {
            return $"{balance}";
        }
        public string Withdraw(double amountToWithdraw)
        {
            balance -= amountToWithdraw;
            return $"{balance}";
        }
    }


}
