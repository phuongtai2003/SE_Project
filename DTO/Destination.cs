using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Destination
    {
        private String _destNum;
        private String _destRoad;
        private String _destWard;
        private String _destDistrict;

        public String DestNum { get { return _destNum; } }
        public String DestRoad { get { return _destRoad;} }
        public String DestWard { get { return _destWard;} }
        public String DestDistrict { get { return _destDistrict;} }

        public Destination(string destNum, string destRoad, string destWard, string destDistrict)
        {
            _destNum = destNum;
            _destRoad = destRoad;
            _destWard = destWard;
            _destDistrict = destDistrict;
        }
    }
}
