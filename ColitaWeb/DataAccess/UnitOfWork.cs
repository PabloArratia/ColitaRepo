using ColitaWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColitaWeb.DataAccess
{
    public class UnitOfWork : IDisposable
    {
        private colitaContext context = new colitaContext(new DbContextOptions<colitaContext>());
        public UnitOfWork()
        {
        }

        private GenericRepository<ColitaEF> colitaEFRepository;
        public GenericRepository<ColitaEF> ColitaEFRepository => this.colitaEFRepository ?? new GenericRepository<ColitaEF>(context);


        public GenericResponse Save()
        {
            try
            {
                context.SaveChanges();
                return new GenericResponse { Success = true };
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Message: " + ex.Message);
                sb.AppendLine("StackTrace: " + ex.StackTrace);
                return new GenericResponse { Success = false, Message = sb.ToString() };
            }
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
