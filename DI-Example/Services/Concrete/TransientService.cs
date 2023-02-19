using DI_Example.Services.Abstract;

namespace DI_Example.Services.Concrete
{
    public class TransientService : ITransientService
    {
        private int _randomNumber;
        public TransientService()
        {
            Random rn = new();
            _randomNumber = rn.Next(1, 1000);
        }

        public int GetRandomNumber()
        {
            return _randomNumber;
        }
    }
}
