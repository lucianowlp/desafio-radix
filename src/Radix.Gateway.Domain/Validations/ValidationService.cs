using Radix.Gateway.Domain.Service;

namespace Radix.Gateway.Domain.Validations
{
    public abstract class ValidationService<T> : NotificationService
    {
        public abstract void Validate(T entity);
    }
}
