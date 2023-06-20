namespace IOC.Web.Models
{
    public interface IDateService
    {
        DateTime GetDateTime { get; }
    }

    public interface ISingletonDateService : IDateService
    {

    }

    public interface IScopeDateService : IDateService
    {

    }


    public interface ITransientDateService : IDateService
    {

    }
}
