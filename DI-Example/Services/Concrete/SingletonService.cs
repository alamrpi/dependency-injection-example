using DI_Example.Services.Abstract;

namespace DI_Example.Services.Concrete
{
    public class SingletonService : ISingletonService
    {
        private int _randomNumber;
        public SingletonService()
        {
            Random rn = new();
            _randomNumber= rn.Next(1, 1000);
        }

        public int GetRandomNumber()
        {
            return _randomNumber;
        }
    }
}
