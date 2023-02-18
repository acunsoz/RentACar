using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        IPaymentDal _paymentDal;

        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }

        public IResult Add(Payment payment)
        {
            IResult result = BusinessRules.Run(CardVerifacition(payment.CardNumber,payment.FullName,payment.Cvv,payment.ExpirationMounth,payment.ExpirationYear));
            if (result != null)
            {
                return result;
            }
            _paymentDal.Add(payment);
            return new SuccessResult(Messages.PaymentAdded);
        }

        public IResult Delete(Payment payment)
        {
            _paymentDal.Delete(payment);
            return new SuccessResult(Messages.PaymentDeleted);
        }

        public IDataResult<Payment> GetByCustomerId(int customerId)
        {
            return new SuccessDataResult<Payment>(_paymentDal.Get(p=>p.CustomerId==customerId));
        }

        public IResult Update(Payment payment)
        {
            _paymentDal.Update(payment);
            return new SuccessResult(Messages.PaymentUpdated);
        }

        private IResult CardVerifacition(string CardNumber,string fullName,int cvv,int month,int year)
        {
            var result =CardNumber.Length >15 && fullName != null && (cvv>=100 && cvv<=999) && (month>0 && month<=12) && year>21;
            if (!result)
            {
                return new ErrorResult(Messages.MissingInformation);
            }
            return new SuccessResult();
        }
    }
}
