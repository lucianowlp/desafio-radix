using Radix.Gateway.Client.DataContracts.Cielo.CreditCard;
using Radix.Gateway.Client.DataContracts.Stone.CreditCard;

namespace Radix.Gateway.Client.DataContracts.CreditCard
{
    public partial class CreditCardTransaction
    {
        public static implicit operator CreditCardTransactionCielo(CreditCardTransaction creditCardTransaction)
        {
            return new CreditCardTransactionCielo
            {
                MerchantOrderId = creditCardTransaction.MerchantOrderId,
                Payment = new PaymentCielo
                {
                    Type = "CreditCard",
                    Amount = creditCardTransaction.Payment.Amount,
                    Installments = creditCardTransaction.Payment.Installments,
                    SoftDescriptor = creditCardTransaction.Payment.Descriptor,
                    CreditCard = new CreditCardCielo
                    {
                        SecurityCode = creditCardTransaction.Payment.CreditCard.SecurityCode,
                        Brand = "Visa",
                        CardNumber = creditCardTransaction.Payment.CreditCard.CreditCardNumber,
                        ExpirationDate = $"{creditCardTransaction.Payment.CreditCard.ExpMonth}/{creditCardTransaction.Payment.CreditCard.ExpYear}",
                        Holder = creditCardTransaction.Payment.CreditCard.PrintedName
                    }
                }
            };
        }

        public static implicit operator CreditCardTransactionStone(CreditCardTransaction creditCardTransaction)
        {
            return new CreditCardTransactionStone
            {

            };
        }
    }
}
