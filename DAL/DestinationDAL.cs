using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DestinationDAL
    {
        private static DestinationDAL instance;

        public static DestinationDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DestinationDAL();
                return instance;
            }
        }
        private DestinationDAL() { }

        public List<String> GetDistricts()
        {
            String sql = "SELECT DISTINCT destDistrict FROM Destination ORDER BY destDistrict DESC";
            DataTable data = DatabaseProvider.Instance.ExecuteQueryCmd(sql);
            List<String> districts = new List<String>();
            foreach(DataRow row in data.Rows)
            {
                districts.Add(row[0].ToString());
            }
            return districts;
        }

        public List<String> GetWards(String district)
        {
            String sql = String.Format("SELECT DISTINCT destWard FROM Destination WHERE destDistrict = N'{0}' ORDER BY destWard DESC", district);
            DataTable data = DatabaseProvider.Instance.ExecuteQueryCmd(sql);
            List<String> wards = new List<String>();
            foreach (DataRow row in data.Rows)
            {
                wards.Add(row[0].ToString());
            }
            return wards;
        }

        public List<String> GetRoads(String district, String ward) {
            String sql = String.Format("SELECT DISTINCT destRoad FROM Destination WHERE destDistrict = N'{0}' and destWard = N'{1}'", district, ward);
            DataTable data = DatabaseProvider.Instance.ExecuteQueryCmd(sql);
            List<String> roads = new List<String>();
            foreach (DataRow row in data.Rows)
            {
                roads.Add(row[0].ToString());
            }
            return roads;
        }

        public List<String> GetNumbers(String district, String ward, String road) {
            String sql = String.Format("SELECT Distinct destNum FROM Destination WHERE destDistrict = N'{0}' and destWard = N'{1}' AND destRoad = N'{2}'", district, ward, road);
            DataTable data = DatabaseProvider.Instance.ExecuteQueryCmd(sql);
            List<String> numbers = new List<String>();
            foreach(DataRow row in data.Rows)
            {
                numbers.Add(row[0].ToString());
            }
            return numbers;
        }

        public String GetDestId(Destination dest)
        {
            string number = dest.DestNum;
            string road = dest.DestRoad;
            string district = dest.DestDistrict;
            string ward = dest.DestWard;
            string sql = string.Format("SELECT destinationId FROM Destination WHERE destNum = N'{0}' AND destRoad = N'{1}' AND destWard = N'{2}' AND destDistrict = N'{3}'", number, road, ward, district);
            DataTable data = DatabaseProvider.Instance.ExecuteQueryCmd(sql);
            if(data.Rows.Count == 1) {
                string id = "";
                foreach (DataRow row in data.Rows) { 
                    id = row[0].ToString();
                }
                return id;
            }
            else
            {
                return null;
            }
        }
    }
}
