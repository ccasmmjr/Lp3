using Microsoft.EntityFrameworkCore;
using Myproject.DAL.DBContext;
using Myprojec.MODEL;

namespace MyProject.BLL
{
    public class StatusRepository
    {
        public static void Add(Status status)
        {
            using (var dbContext = new CUsersCcasmSourceReposAtvlp3tabela2MyprojectDalDatabaseDatabase1MdfContext())
            {
                dbContext.Add(status);
                dbContext.SaveChanges();
            }
        }
        public static void deleteAll()
        {
            using (var dbContext = new CUsersCcasmSourceReposAtvlp3tabela2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var status = dbContext.Statuses.ToList();
                dbContext.RemoveRange(status);
                dbContext.SaveChanges();
            }
        }
        public static List<Status> getAll()
        {
            using (var dbContext = new CUsersCcasmSourceReposAtvlp3tabela2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var status = dbContext.Statuses.ToList();
                return status;
            }
        }
        public static Status getbyID(int id)
        {
            using (var dbContext = new CUsersCcasmSourceReposAtvlp3tabela2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var status = dbContext.Statuses.Single(p=>p.Id==id);
                return status;
            }
        }
    }
}
