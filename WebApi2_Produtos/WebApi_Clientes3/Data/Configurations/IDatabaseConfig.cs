namespace WebApi_Clientes3.Data.Configurations
{
    public interface IDatabaseConfig
    {

        string DatabaseName { get; set; }

        string ConnectionString { get; set; }
    }
}
