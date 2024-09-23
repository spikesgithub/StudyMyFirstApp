using MyFirstWinformApp.common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWinformApp.Models
{
    internal class Light : Iusb
    {
        public string equipmentName { get ; set; }

        public Light(string equipmentname)
        {
            equipmentName = equipmentname;
        }
        public void AddEquipment()
        {
            MessageBox.Show($"{equipmentName} cha ru le");
        }
        public void EquipmentWorking()
        {
            MessageBox.Show($"{equipmentName} is working");
        }
        private void OpenLight()
        {

        }
    }
}
