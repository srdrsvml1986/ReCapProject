using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Interceptors
{
    /// <summary>
    /// base sınıftan inherit edilen abstact MethodInterception sınıfı ValidationAspect Attributeslerimizin 
    /// çalışma sırası ve evenleri için overload bırakır
    /// </summary>
    public abstract class MethodInterception:MethodInterceptionBaseAttribute
    {
        protected virtual void OnBefore(IInvocation invocation) { }
        protected virtual void OnAfter(IInvocation invocation) { }
        protected virtual void OnExeption(IInvocation invocation,System.Exception e) { }
        protected virtual void OnSuccess(IInvocation invocation) { }
        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
                var result = invocation.ReturnValue as Task;
                    if (result != null)
                       result.Wait();
            }
            catch (System.Exception e)
            {
                isSuccess = false;
                OnExeption(invocation, e);
                throw;                
            }finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
            }
            OnAfter(invocation);

        }
    }
}
