namespace Coding.Exercise
{
  public class InvalidTransactionException : Exception
  {

    public TransactionData TransactionData { get; }

    public InvalidTransactionException(string message, TransactionData transactionData, Exception innerException) : base(message, innerException)
    {
      TransactionData = transactionData;
    }
    public InvalidTransactionException(string message, TransactionData transactionData) : base(message)
    {
      TransactionData = transactionData;
    }
    public InvalidTransactionException(string message) : base(message)
    {

    }
    public InvalidTransactionException(string message, Exception innerException) : base(message, innerException)
    {

    }
    public InvalidTransactionException() : base()
    {

    }
  }

  public class TransactionData
  {
    public string Sender { get; init; }
    public string Receiver { get; init; }
    public decimal Amount { get; init; }
  }
}
// completed