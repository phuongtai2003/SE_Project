using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DestinationBLL
    {
        private static DestinationBLL instance;
        private Destination currentDestination;
        public Destination CurrentDestination { get { return currentDestination; } }
        public static DestinationBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DestinationBLL();
                return instance;
            }
        }
        private DestinationBLL() { }

        public List<String> GetDistrict()
        {
            List<String> districts = DestinationDAL.Instance.GetDistricts();
            return districts;
        }

        public List<String> GetWards(String district)
        {
            List<String> wards = DestinationDAL.Instance.GetWards(district);
            return wards;
        }
        public List<String> GetRoads(String district, String ward) {
            List<String> roads = DestinationDAL.Instance.GetRoads(district, ward);
            return roads;
        }
        public List<String> GetNumbers(String district, String ward, String road) { 
            List<String> numbers = DestinationDAL.Instance.GetNumbers(district, ward, road);
            return numbers;
        }

        public void SetDestination(String district, String ward, String road, String number)
        {
            this.currentDestination = new Destination(number, road, ward, district);
        }

        public String GetCurrentDestId()
        {
            String id = DestinationDAL.Instance.GetDestId(CurrentDestination);
            return id;
        }
    }
}
