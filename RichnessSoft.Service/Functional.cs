using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage;
using RichnessSoft.Common;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using RichnessSoft.Service.Store;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Service
{

    public interface IFunctional
    {
        void AddAuditInfo<TEntity>(ref TEntity entity);
        string GetCurrentLoginUserId();
        void UpdateAuditInfo<TEntity>(ref TEntity entity);
        void UpdateAuditInfo<TEntity>(ref TEntity[] entitys);
        ResultModel Insert<TEntity>(TEntity entity) where TEntity : class;
        ResultModel Update<TEntity>(TEntity entity) where TEntity : class;
        ResultModel UpdateRange<TEntity>(TEntity[] entitys) where TEntity : class;
        ResultModel Delete<TEntity>(object id) where TEntity : class;
        ResultModel Delete<TEntity>(TEntity[] entities) where TEntity : class;
        ResultModel Delete<TEntity>(TEntity entity) where TEntity : class;
        TEntity GetById<TEntity>(object id) where TEntity : class;
        IEnumerable<TEntity> GetList<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;
        IEnumerable<TEntity> GetList<TEntity>() where TEntity : class;
        ResultModel BeginTransaction();
        ResultModel BeginTransaction(IsolationLevel isolation = IsolationLevel.ReadCommitted);
        ResultModel CommitTransaction();
        ResultModel RollbackTransaction();
        ResultModel CancelEdit<TEntity>(TEntity entities) where TEntity : class;
    }
    public class Functional : IFunctional
    {
        public readonly RicnessDbContext _context;
        private IDbContextTransaction goTransaction = null;
        private ProfileStore profileStore;
        public Functional(RicnessDbContext context, ProfileStore store)
        {
            _context = context;
            // _mapper = mapper;
            goTransaction = null;
            profileStore = store;
        }
        public void AddAuditInfo<T>(ref T entity)
        {
            try
            {
                entity.GetType().GetProperty("createatutc", BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.Public).SetValue(entity, DateTime.Now);
                entity.GetType().GetProperty("createby", BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.Public).SetValue(entity, GetCurrentLoginUserId());
                entity.GetType().GetProperty("updateatutc", BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.Public).SetValue(entity, DateTime.Now);
                entity.GetType().GetProperty("updateby", BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.Public).SetValue(entity, GetCurrentLoginUserId());
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void UpdateAuditInfo<TEntity>(ref TEntity entity)
        {
            try
            {
                entity.GetType().GetProperty("updateatutc", BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.Public).SetValue(entity, DateTime.Now);
                entity.GetType().GetProperty("updateby", BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.Public).SetValue(entity, GetCurrentLoginUserId());
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void UpdateAuditInfo<TEntity>(ref TEntity[] entitys)
        {
            try
            {
                foreach (TEntity entity in entitys)
                {
                    entity.GetType().GetProperty("updateatutc", BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.Public).SetValue(entity, DateTime.Now);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string GetCurrentLoginUserId()
        {
            string result;
            try
            {

                result = profileStore.CurrentUser.username;
                //result = _userManager.GetUserId(_httpContextAccessor.HttpContext.user);
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public TEntity GetById<TEntity>(object id) where TEntity : class
        {
            try
            {
                var entity = _context.Set<TEntity>().Find(id);

                return entity;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public IEnumerable<TEntity> GetList<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class
        {
            try
            {
                return _context.Set<TEntity>().AsNoTrackingWithIdentityResolution().Where(predicate).AsEnumerable();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public IEnumerable<TEntity> GetList<TEntity>() where TEntity : class
        {
            try
            {
                //return _context.Set<TEntity>()
                //    .AsNoTrackingWithIdentityResolution()
                //    .AsEnumerable();

                return _context.Set<TEntity>()
                    .AsEnumerable();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public ResultModel Insert<TEntity>(TEntity entity) where TEntity : class
        {
            ResultModel oResult = new ResultModel { Success = true, Message = "", Data = null };
            bool bSaveFailed;
            int pnMaxLoopFailed = 0;
            do
            {
                bSaveFailed = false;
                try
                {
                    AddAuditInfo<TEntity>(ref entity);
                    _context.Set<TEntity>().Add(entity);
                    _context.SaveChanges(true);
                    oResult = new ResultModel { Success = true, Message = "Insert success.", Data = entity };
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    bSaveFailed = true;
                    pnMaxLoopFailed++;
                    EntityReload(entity);
                    oResult = new ResultModel { Success = false, Message = ex.Message, Data = null };
                }
                catch (Exception ex)
                {
                    bSaveFailed = true;
                    pnMaxLoopFailed++;
                    EntityReload(entity);
                    oResult = new ResultModel { Success = false, Message = ex.Message, Data = null };
                    if (ex.InnerException is not null)
                    {
                        oResult.Message = ex.InnerException.Message;
                    }
                }
            } while (bSaveFailed && pnMaxLoopFailed < 5);
            return oResult;
        }
        public ResultModel Update<TEntity>(TEntity entity) where TEntity : class
        {
            ResultModel oResult = new ResultModel { Success = true, Message = "", Data = null };
            bool bSaveFailed;
            int pnMaxLoopFailed = 0;
            do
            {
                bSaveFailed = false;
                try
                {
                    UpdateAuditInfo(ref entity);
                    var updatedEntity = _context.Set<TEntity>().Update(entity);
                    if (updatedEntity is not null)
                    {
                        updatedEntity.State = EntityState.Modified;
                    }
                    _context.SaveChanges(true);
                    updatedEntity.State = EntityState.Detached;
                    oResult = new ResultModel { Success = true, Message = "Update success.", Data = entity };
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    bSaveFailed = true;
                    pnMaxLoopFailed++;
                    EntityReload(entity);
                    oResult = new ResultModel { Success = false, Message = ex.Message, Data = null };
                }
                catch (DbUpdateException ex)
                {
                    bSaveFailed = true;
                    pnMaxLoopFailed++;
                    EntityReload(entity);
                    oResult = new ResultModel { Success = false, Message = ex.Message, Data = null };
                }
                catch (Exception ex)
                {
                    bSaveFailed = true;
                    pnMaxLoopFailed++;
                    EntityReload(entity);
                    oResult = new ResultModel { Success = false, Message = ex.Message, Data = null };
                    if (ex.InnerException is not null)
                    {
                        oResult.Message = ex.InnerException.Message;
                    }
                }
            } while (bSaveFailed && pnMaxLoopFailed < 5);
            return oResult;
        }
        public ResultModel UpdateRange<TEntity>(TEntity[] entities) where TEntity : class
        {
            ResultModel oResult = new ResultModel { Success = true, Message = "", Data = null };
            bool bSaveFailed;
            int nMaxLoopFailed = 10;
            do
            {
                bSaveFailed = false;
                try
                {
                    UpdateAuditInfo(ref entities);
                    foreach (TEntity entity in entities)
                    {
                        var updatedEntity = _context.Set<TEntity>().Update(entity);
                        if (updatedEntity is not null)
                        {
                            updatedEntity.State = EntityState.Modified;
                        }
                    }
                    _context.SaveChanges(true);
                    foreach (TEntity entity in entities)
                    {
                        var updatedEntity = _context.Set<TEntity>().Update(entity);
                        if (updatedEntity is not null)
                        {
                            updatedEntity.State = EntityState.Detached;
                        }
                    }
                    oResult = new ResultModel { Success = true, Message = "Update range success.", Data = entities };
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    bSaveFailed = true;
                    nMaxLoopFailed++;
                    EntityReload(entities);
                    oResult = new ResultModel { Success = false, Message = ex.Message, Data = null };
                }
                catch (Exception ex)
                {
                    bSaveFailed = true;
                    nMaxLoopFailed++;
                    EntityReload(entities);
                    oResult = new ResultModel { Success = false, Message = ex.Message, Data = null };
                    if (ex.InnerException is not null)
                    {
                        oResult.Message = ex.InnerException.Message;
                    }
                }
            } while (bSaveFailed && nMaxLoopFailed < 5);
            return oResult;
        }
        public ResultModel Delete<TEntity>(TEntity entity) where TEntity : class
        {
            return Delete<TEntity>(new TEntity[] { entity });
        }
        public ResultModel Delete<TEntity>(TEntity[] entities) where TEntity : class
        {
            try
            {
                foreach (TEntity entity in entities)
                {
                    var deleteEntity = _context.Set<TEntity>().Remove(entity);
                    if (deleteEntity is not null)
                    {
                        deleteEntity.State = EntityState.Deleted;
                    }
                }
                _context.SaveChanges(true);
                return new ResultModel { Success = true, Message = "Delete success.", Data = entities };
            }
            catch (Exception ex)
            {
                if (ex.InnerException is not null)
                {
                    return new ResultModel { Success = false, Message = ex.InnerException.Message };
                }
                else
                {
                    return new ResultModel { Success = false, Message = ex.Message };
                }
            }
        }
        public ResultModel Delete<TEntity>(object code) where TEntity : class
        {
            try
            {
                var typeInfo = typeof(TEntity).GetTypeInfo();
                IEntityType oEntityType = null;
                IKey oKey = null;
                IReadOnlyList<IProperty> IListProperty = null;
                IProperty oProperty = null;
                if (typeInfo != null)
                {
                    oEntityType = _context.Model.FindEntityType(typeInfo);
                }
                if (oEntityType != null)
                {
                    oKey = oEntityType.FindPrimaryKey();
                }
                if (oKey != null)
                {
                    IListProperty = oKey.Properties;
                }
                if (IListProperty != null)
                {
                    oProperty = IListProperty.FirstOrDefault();
                }
                if (oProperty != null)
                {
                    oProperty = IListProperty.FirstOrDefault();
                }
                if (typeInfo != null && oProperty != null)
                {
                    PropertyInfo oPropertyInfo = typeInfo.GetProperty(oProperty?.Name);
                    if (oPropertyInfo != null)
                    {
                        var entity = Activator.CreateInstance<TEntity>();
                        oPropertyInfo.SetValue(entity, code);
                        _context.Entry(entity).State = EntityState.Deleted;
                    }
                    else
                    {
                        var entity = _context.Set<TEntity>().Find(code);
                        if (entity != null) _context.Remove(entity);
                    }
                    _context.SaveChanges(true);
                    return new ResultModel { Success = true, Message = "Delete success." };
                }
                else
                {
                    return new ResultModel { Success = false, Message = "Nothing." };
                }
            }
            catch (Exception ex)
            {

                return new ResultModel { Success = false, Message = ex.Message };
            }
        }
        public ResultModel BeginTransaction() => BeginTransaction(IsolationLevel.ReadCommitted);
        public ResultModel BeginTransaction(IsolationLevel isolation = IsolationLevel.ReadCommitted)
        {
            try
            {
                this.goTransaction = _context.Database.BeginTransaction(isolation);
                return new ResultModel { Success = true, Message = "BeginTransaction success.", Data = null };
            }
            catch (Exception ex)
            {
                return new ResultModel { Success = false, Message = ex.Message };
            }
        }
        public ResultModel CommitTransaction()
        {
            try
            {
                if (this.goTransaction != null)
                {
                    this.goTransaction.Commit();
                }
                return new ResultModel { Success = true, Message = "CommitTransaction success.", Data = null };
            }
            catch (Exception ex)
            {
                return new ResultModel { Success = false, Message = ex.Message };
                this.goTransaction.Rollback();
            }
            finally
            {
                if (this.goTransaction != null)
                {
                    this.goTransaction.Dispose();
                }
                this.goTransaction = null;
            }
        }
        public ResultModel RollbackTransaction()
        {
            try
            {
                if (this.goTransaction != null)
                {
                    this.goTransaction.Rollback();
                }
                return new ResultModel { Success = true, Message = "RollbackTransaction success.", Data = null };
            }
            catch (Exception ex)
            {
                return new ResultModel { Success = false, Message = ex.Message };
            }
            finally
            {
                if (this.goTransaction != null)
                {
                    this.goTransaction.Dispose();
                }
                this.goTransaction = null;
            }
        }
        public ResultModel CancelEdit<TEntity>(TEntity entities) where TEntity : class
        {
            try
            {
                var orderEntry = _context.Entry(entities);
                if (orderEntry.State == EntityState.Modified)
                {
                    orderEntry.CurrentValues.SetValues(orderEntry.OriginalValues);
                    orderEntry.State = EntityState.Unchanged;
                }
                return new ResultModel { Success = true, Message = "CancelEdit success.", Data = entities };
            }
            catch (Exception ex)
            {
                return new ResultModel { Success = false, Message = ex.Message };
            }
        }
        private void EntityReload(object entity)
        {
            // Update original values from the database
            try
            {
                if (_context is null) { return; }
                else if (entity is null) { return; }
                var entry = _context.Entry(entity);
                if (entry is not null)
                {
                    entry.OriginalValues.SetValues(entry.GetDatabaseValues());
                }
            }
            catch (Exception) { }
        }
        private void EntityReload(object[] entities)
        {
            // Update original values from the database
            try
            {
                if (_context is null) { return; }
                else if (entities is null || entities.Length == 0) { return; }
                for (int i = 0; i < entities.Length; i++)
                {
                    var entry = _context.Entry(entities[i]);
                    if (entry is not null)
                    {
                        entry.OriginalValues.SetValues(entry.GetDatabaseValues());
                    }
                }
            }
            catch (Exception)
            {
            }

        }
    }
}
