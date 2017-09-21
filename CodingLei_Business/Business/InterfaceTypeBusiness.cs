using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingLei_Common.Helper;
using CodingLei_Model.TableModel;

namespace CodingLei_Business.Business
{
    public class InterfaceTypeBusiness
    {
        public List<InterfacesTypes> GetInterfaceTypeList()
        {
            var interfacesType = DBHelper.Context.From<InterfacesTypes>().ToList();
            return interfacesType;
        }
    }
}
