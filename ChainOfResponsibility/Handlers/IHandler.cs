namespace DesignPatterns.ChainOfResponsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        void Handle(long amount);
    }
}