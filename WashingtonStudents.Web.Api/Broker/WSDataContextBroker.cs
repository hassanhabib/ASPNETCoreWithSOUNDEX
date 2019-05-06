using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WashingtonStudents.Web.Api.Models;

namespace WashingtonStudents.Web.Api.Broker
{
    public class WSDataContextBroker :  DbContext
    {
        public WSDataContextBroker(DbContextOptions<WSDataContextBroker> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        [DbFunction(FunctionName = "SOUNDEX", Schema = "")]
        public static string SoundsLike(string keyword)
        {
            throw new NotImplementedException();
        }
    }
}
