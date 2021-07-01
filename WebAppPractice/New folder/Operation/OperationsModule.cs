using Autofac;
using Operations.Services;

namespace Operations
{
    public class OperationsModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public OperationsModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CalculatorService>().As<ICalculatorService>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
