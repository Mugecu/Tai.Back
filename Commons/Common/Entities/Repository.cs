namespace Common.Entities
{
    public abstract class Repository<T> : IDisposable where T : AggregateRoot
    {
        public abstract Task<T> CreateAsync(T root);
        public abstract Task<T?> GetAsync(Guid id);
        public abstract Task SaveAsync();


        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                    Dispose();
            }
            _disposed = true;
        }

        public void Dispose()
        {
            //Dispose(true);
            //GC.SuppressFinalize(this);
        }
    }
}
