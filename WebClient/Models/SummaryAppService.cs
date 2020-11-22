using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebClient.Models
{
    public class SummaryAppService : BaseService
    {
        public List<Summary> GetSummaryCategories()
        {
            return Gets<Summary>("summary");
        }

        public List<Summary> GetSummaryCategoriesByTime(Summary obj)
        {
            return Gets<Summary>("Summary/GetAllByTimeCategories", obj);
        }

        public List<Summary_RPT> RPT_DoanhThuHaiNamGanNhat()
        {
            return Gets<Summary_RPT>("Summary/RPT_DoanhThuHaiNamGanNhat");
        }

        public List<Summary> RPT_TrangThaiDonHang(Summary obj)
        {
            return Gets<Summary>("Summary/RPT_TrangThaiDonHang", obj);
        }
    }
}
