using System.Threading.Tasks;

namespace PasswordGenerator.Data;

public interface IPasswordGeneratorDbSchemaMigrator
{
    Task MigrateAsync();
}
