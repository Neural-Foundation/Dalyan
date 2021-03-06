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
    
    public class CommonUserTypeGetAllQuery : IQuery<IList<Dalyan.Entities.Models.CommonUserType>>
    {
    	
    }
    
    public class CommonUserTypeGetAllQueryHandler : IQueryHandler<CommonUserTypeGetAllQuery, IList<Dalyan.Entities.Models.CommonUserType>>
    {
    	private readonly DbEntities _db;
    	public CommonUserTypeGetAllQueryHandler()
    	{
    		_db = new DbEntities();
    	}
    
    	    
    	public IList<Dalyan.Entities.Models.CommonUserType> Handler(CommonUserTypeGetAllQuery query)
    	{
    		try
    		{
    			var result = _db.CommonUserType.Where(x => x.IsDeleted == false).AsEnumerable().ToList();
    			Mapper.CreateMap<Dalyan.Db.CommonUserType, Dalyan.Entities.Models.CommonUserType>();
    			return Mapper.Map<IEnumerable<Dalyan.Db.CommonUserType>, IEnumerable<Dalyan.Entities.Models.CommonUserType>>(result).ToList();
    
    		}
    		catch (Exception ex)
    		{
    			throw new ExceptionLog(LogType.DATABASE_SELECT, LogLevel.ERROR, ex, "GetAllQueryHandler");
    		}
    	}
    }
    
}
