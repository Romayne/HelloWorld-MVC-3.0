using HelloWorldDatabaseAccess;

namespace HelloWorldRepository.Repository
{
    public class RepositoryBase
    {
        public DatabaseAccessLINQtoSQLDataContext DataContext { get; private set; }

        public RepositoryBase()
        {
            DataContext = new DatabaseAccessLINQtoSQLDataContext();
        }
    }
}