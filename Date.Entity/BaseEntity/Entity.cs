
namespace Date.Entity.BaseEntity
{
    public class Entity<T>
    {
        public virtual T Id
        {
            get;
             set;
        }

        public DateTime CreationDate
        {
            get;
             set;
        }

        public int DeletedStatus
        {
            get;
             set;
        }
    }
}
