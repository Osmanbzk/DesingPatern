using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DSP
{
    public interface ITransferSource
    {
        void RemoveFunds(decimal value);
    }

    public interface ITransferDestination
    {
        void AddFunds(decimal value);
    }

    public class BankAccount : ITransferSource, ITransferDestination
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public void AddFunds(decimal value)
        {
            Balance += value;
        }

        public void RemoveFunds(decimal value)
        {
            Balance -= value;
        }
    }

    public class TransferManager
    {
        public ITransferSource Source { get; set; }
        public ITransferDestination Destination { get; set; }
        public decimal Value { get; set; }
        public void Transfer()
        {
            Source.RemoveFunds(Value);
            Destination.AddFunds(Value);
        }

    }
}
