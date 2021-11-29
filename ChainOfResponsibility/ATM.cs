namespace DesignPatterns.ChainOfResponsibility
{
    public class ATM
    {
        private TwoThousandHandler twoThousandHandler = new TwoThousandHandler();
        private FiveHundredHandler fiveHundredHandler = new FiveHundredHandler();
        private TwoHundredHandler twoHundredHandler = new TwoHundredHandler();
        private HundredHandler hundredHandler = new HundredHandler();
        
        public ATM()
        {
            // Prepare the chain of Handlers
            twoThousandHandler.SetNext(fiveHundredHandler);
            fiveHundredHandler.SetNext(twoHundredHandler);
            twoHundredHandler.SetNext(hundredHandler);
        }

        public void Withdraw(long requestedAmount)
        {
            twoThousandHandler.Handle(requestedAmount);
        }
    }
}