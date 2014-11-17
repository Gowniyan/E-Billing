using System.Data.Entity;
using MySQL_MVC_Template1.Models;

namespace MySQL_MVC_Template1
{
    public class mydb_finalEntities : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<MySQL_MVC_Template1.mydb_finalEntities>());

        public mydb_finalEntities() : base("name=mydb_finalEntities")
        {
        }

        public DbSet<employeemaster> employeemasters { get; set; }
    }
}
