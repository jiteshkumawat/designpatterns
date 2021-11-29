namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler? _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            
            return handler;
        }
        
        public virtual void Handle(long amount)
        {
            if (this._nextHandler != null)
            {
                this._nextHandler.Handle(amount);
            }
        }
    }
}