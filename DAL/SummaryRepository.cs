﻿using DTO;
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
                Name = (string)reader["CategoryName"],
                Total = (int)reader["Total"]
            };
        }
        public List<Summary> GetSummaryCategories()
        {
            return Query("GetSummaryCategories");
        }
    }
}
