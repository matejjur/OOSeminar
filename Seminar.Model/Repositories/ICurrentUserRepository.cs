namespace Seminar.Model.Repositories
{
    public interface ICurrentUserRepository
    {
        void setUsername(string username);
        string getUsername();
    }
}
