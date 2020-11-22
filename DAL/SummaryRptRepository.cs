using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
    public class SummaryRptRepository : BaseRepository<Summary_RPT>
    {
        public SummaryRptRepository(IDbConnection connection) : base(connection)
        {
        }

        protected override Summary_RPT Fetch(IDataReader reader)
        {
            return new Summary_RPT
            {
                MONTH = reader["MONTH"] != DBNull.Value ? (string)reader["MONTH"] : null,
                CURRENT_YEAR = reader["CURRENT_YEAR"] != DBNull.Value ? (long?)reader["CURRENT_YEAR"] : 0,
                LAST_YEAR = reader["LAST_YEAR"] != DBNull.Value ? (long?)reader["LAST_YEAR"] : 0,
                AVERAGE = reader["AVERAGE_YEAR"] != DBNull.Value ? (long?)reader["AVERAGE_YEAR"] : 0
            };
        }

        public List<Summary_RPT> RPT_DoanhThuHaiNamGanNhat()
        {
            return Query("RPT_DoanhThuHaiNamGanNhat");
        }
    }
}
