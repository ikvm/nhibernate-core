﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by AsyncGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System.Collections;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Engine;
using NUnit.Framework;

namespace NHibernate.Test.SqlTest.Identity.MsSQL
{
	using System.Threading.Tasks;
	[TestFixture]
	public class MSSQLIdentityInsertWithStoredProcsTestAsync : IdentityInsertWithStoredProcsTestAsync
	{
		protected override bool AppliesTo(Dialect.Dialect dialect)
		{
			return dialect is MsSql2000Dialect;
		}

		protected override bool AppliesTo(ISessionFactoryImplementor factory)
		{
			// Tested resulting SQL depends on driver.
			return factory.ConnectionProvider.Driver is SqlClientDriver;
		}

		protected override string GetExpectedInsertOrgLogStatement(string orgName)
		{
			return string.Format("exec nh_organization_native_id_insert @p0;@p0 = '{0}' [Type: String (4000:0:0)]", orgName);
		}

		protected override IList Mappings
		{
			get { return new[] { "SqlTest.Identity.MsSQL.MSSQLIdentityInsertWithStoredProcs.hbm.xml" }; }
		}
	}
}