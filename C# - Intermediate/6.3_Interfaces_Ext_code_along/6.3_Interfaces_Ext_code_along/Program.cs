using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3_Interfaces_Ext_code_along
{

    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger(@"C:\Users\ptome"));
            dbMigrator.Migrate();
        }
    }
}
