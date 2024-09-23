using MyFirstWinformApp.common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWinformApp.Models
{
    public class Upan : Iusb
    {
        public string equipmentName { get; set; }
        public Upan(string equipmentname)
        {
            equipmentName = equipmentname;
            AddEquipment();
        }
        public void AddEquipment()
        {
            throw new NotImplementedException();
        }
        public void EquipmentWorking()
        {
            throw new NotImplementedException();
        }
        private void ReadData()
        {
            throw new NotImplementedException();
        }
    }
}
