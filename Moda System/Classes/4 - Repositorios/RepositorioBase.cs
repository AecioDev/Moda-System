using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Moda_System.Classes
{
    public class RepositorioBase<TEntity> : IDisposable, IRepositorioBase<TEntity> where TEntity : class
    {
        protected ContextoDB Db = new ContextoDB();

        public List<ErrosDB> Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            var erros = ValidationResult(Db);
            if (erros.Count() == 0)
                Db.SaveChanges();
            return erros;
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public List<ErrosDB> Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            var erros = ValidationResult(Db);
            if (erros.Count() == 0)
                Db.SaveChanges();
            return erros;
        }

        public List<ErrosDB> Update(TEntity obj)
        {            
            Db.Entry(obj).State = EntityState.Modified;
            var erros = ValidationResult(Db);
            if (erros.Count() == 0)
                Db.SaveChanges();
            return erros;
        }

        public static List<ErrosDB> ValidationResult(DbContext context)
        {
            List<ErrosDB> errosDB = new List<ErrosDB>();

            var erros = context.GetValidationErrors();

            foreach (System.Data.Entity.Validation.DbEntityValidationResult item in erros)
            {
                foreach (System.Data.Entity.Validation.DbValidationError vErro in item.ValidationErrors)
                {
                    errosDB.Add(new ErrosDB(vErro.ErrorMessage, vErro.PropertyName));
                }
            }

            return errosDB;
        }
    }
}
