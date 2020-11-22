using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
    public class SummaryRepository : BaseRepository<Summary>
    {
        internal SummaryRepository(IDbConnection connection) : base(connection)
        {
        }

        protected override Summary Fetch(IDataReader reader)
        {
            return new Summary
            {
                Name = reader["Name"] != DBNull.Value? (string)reader["Name"] : null,
                Total = reader["Total"] != DBNull.Value ? (int?)reader["Total"] : 0
            };
        }
        public List<Summary> GetSummaryCategories(Summary obj)
        {
            Parameter[] parameters =
            {
                new Parameter { Name = "@FROMDATE", Value = obj.FROM_DATE.ToString(), DbType = DbType.String},
                new Parameter { Name = "@TODATE", Value = obj.TO_DATE.ToString(), DbType = DbType.String}
            };
            return Query("GetSummaryCategories", parameters);
        }

        public List<Summary> RPT_TrangThaiDonHang(Summary obj)
        {
            Parameter[] parameters =
            {
                new Parameter { Name = "@FROMDATE", Value = obj.FROM_DATE.ToString(), DbType = DbType.String},
                new Parameter { Name = "@TODATE", Value = obj.TO_DATE.ToString(), DbType = DbType.String}
            };
            return Query("RPT_TrangThaiDonHang", parameters);
        }
    }
}
