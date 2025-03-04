namespace HR
{
    public interface IEmployee
    {
    
    }
    
    namespace Mgr
    {
        public interface IManager : IEmployee
        {

        }

        public class Manager : IManager
        {

        }

        public class AsstManager : IManager
        {

        }

    }

    public interface IExecutive : IEmployee
    {

    }

    public class Executive : IExecutive
    {

    }
}