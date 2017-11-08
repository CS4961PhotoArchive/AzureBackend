using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Microsoft.Azure.Mobile.Server;
using Microsoft.Azure.Mobile.Server.Tables;
using boephotoarchiveService.DataObjects;

namespace boephotoarchiveService.Models
{
    public class boephotoarchiveContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to alter your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        private const string connectionStringName = "Data Source=tcp:boeazuresql.database.windows.net,1433;Initial Catalog=boephotoarchivedb;User ID=engsqlservice@boeazuresql;Password=@1149Eng$90015";

        public boephotoarchiveContext() : base(connectionStringName)
        {
        } 

        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add(
                new AttributeToColumnAnnotationConvention<TableColumnAttribute, string>(
                    "ServiceTableColumn", (property, attributes) => attributes.Single().ColumnType.ToString()));
        }

        public System.Data.Entity.DbSet<boephotoarchiveService.DataObjects.Attribute> Attributes { get; set; }

        public System.Data.Entity.DbSet<boephotoarchiveService.DataObjects.Context> Contexts { get; set; }

        public System.Data.Entity.DbSet<boephotoarchiveService.DataObjects.Context_Attribute> Context_Attribute { get; set; }

        public System.Data.Entity.DbSet<boephotoarchiveService.DataObjects.ICAV> ICAVs { get; set; }

        public System.Data.Entity.DbSet<boephotoarchiveService.DataObjects.Image> Images { get; set; }
    }

}
