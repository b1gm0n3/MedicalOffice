using MedicalOffice.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedicalOffice.DAL
{
    public class MedicalOfficeContext : DbContext
    {
        public MedicalOfficeContext(DbContextOptions<MedicalOfficeContext> opt) : base(opt)
        {

        }

        public DbSet<Patient> Patients { get; set; }

        //public DbSet<Patient>  { get; set; }

        //public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        //{
        //    foreach (var entry in ChangeTracker.Entries().Where(e => e.Entity is AuditEntity))
        //    {
        //        switch (entry.State)
        //        {
        //            case EntityState.Added:
        //                entry.CurrentValues["CreatedAt"] = DateTime.Now;
        //                entry.CurrentValues["CreatedBy"] = "OMT-Test";
        //                break;
        //            case EntityState.Deleted:
        //                entry.State = EntityState.Modified;
        //                entry.CurrentValues["DeletedAt"] = DateTime.Now;
        //                entry.CurrentValues["DeletedBy"] = "OMT-Test";
        //                break;
        //            case EntityState.Modified:
        //                entry.CurrentValues["UpdatedAt"] = DateTime.Now;
        //                entry.CurrentValues["UpdatedBy"] = "OMT-Test";
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //    return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        //}
    }
}