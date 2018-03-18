using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23Example.Pattern.Creational.AbstractFactory.Inpletment
{
    public class AbstractFactoryExample
    {
        public AbstractFactoryExample() {

            //呼叫抽象工廠
            MapFactory CallAbstractFactory = new MapFactory();

            //呼叫夜晚的地圖
            CallAbstractFactory.LoadScene("DarkMap");

            //呼叫白天的地圖
            CallAbstractFactory.LoadScene("LightMap");

        }
    }
}
