namespace TurttleChallenge.Configurations.Interface
{
    public interface IConfiguration<T> where T : class
    {
        T Load(string fileName);
    }
}
