

using Product.Data.Infrastructure._UniteOfWork;

namespace Product.Application.Base.AppService
{
    public class BaseAppService
    {

        protected IUnitOfWork UnitOfWork { get; }
        #region CTRS
        public BaseAppService( IUnitOfWork _unitOfWork)
        {
            UnitOfWork= _unitOfWork;
        }
        #endregion
    }
}
