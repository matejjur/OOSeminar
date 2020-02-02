namespace Seminar.BaseLib
{
    public interface IObservable
    {

        void Attach(IObserver obs);
        void Delete(IObserver obs);
        void NotifyObservers();
    }
}
