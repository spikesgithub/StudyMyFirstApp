using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWinformApp.common.Interfaces
{
    public interface Iusb  //   接口 一般不写 实现方法
    {
        
        /// <summary>
        /// 设备名称
        /// </summary>
        public string equipmentName { get; set; }

        /// <summary>
        /// 添加时触发通知
        /// </summary>
        public void AddEquipment();
        public void EquipmentWorking();
    }
}
