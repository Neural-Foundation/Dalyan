//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dalyan.Domain.Query
{
    using System;
    using Dalyan.Domain;
    using System.Linq;
    using System.Text;
    using Dalyan.Domain.Query;
    using System.Data;
    using System.Xml;
    using Dalyan.Db;
    using Entities.Models;
    using Dalyan.Entities.Enumerations;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    
    public class LogLoginEditQuery : IQuery<Dalyan.Entities.Models.LogLogin>
    {
    	public Dalyan.Entities.Models.LogLogin LogLogin{ get; set; }
    }
    
    public class LogLoginEditQueryHandler : IQueryHandler<LogLoginEditQuery, Dalyan.Entities.Models.LogLogin>
    {
    	private readonly DbEntities _db;
    	public LogLoginEditQueryHandler()
    	{
    		_db = new DbEntities();
    	}
    
    	    
    	public Dalyan.Entities.Models.LogLogin Handler(LogLoginEditQuery query)
    	{
    		try
    		{
    			var obj = new Dalyan.Db.LogLogin();
    			obj = _db.LogLogin.FirstOrDefault(x => x.Id == query.LogLogin.Id);
    			obj.Id = query.LogLogin.Id;
    			obj.UserId = query.LogLogin.UserId;
    			obj.LogDate = query.LogLogin.LogDate;
    			obj.LoginLogType = query.LogLogin.LoginLogType;
    			obj.ExceptionString = query.LogLogin.ExceptionString;
    			obj.Comment = query.LogLogin.Comment;
                obj.IsDeleted = query.LogLogin.IsDeleted;
    			_db.SaveChanges();
    			return query.LogLogin;
    
    		}
    		catch (Exception ex)
    		{
    			throw new ExceptionLog(LogType.DATABASE_UPDATE, LogLevel.ERROR, ex, "EditQueryHandler");
    		}
    	}
    }
    
}
