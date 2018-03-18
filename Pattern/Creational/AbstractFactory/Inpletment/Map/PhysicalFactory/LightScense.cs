using DesignPattern23Example.Pattern.Creational.AbstractFactory.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern23Example.Pattern.Creational.AbstractFactory.Base.MapStruct;

namespace DesignPattern23Example.Pattern.Creational.AbstractFactory.Inpletment.PhysicalFactory
{
    /// <summary>
    /// 白天的場景
    /// </summary>
    class LightScense : MapSceneFactory
    {
        public override Model CreateModel()
        {
            return new LightScenseModel();
        }

        public override Texture CreateTexture()
        {
            return new LightScenseTexture();
        }
    }

    class LightScenseModel : Model
    {
        public LightScenseModel()
        {
            Console.WriteLine("LightScense Model Created");
        }

        public override void FillTexture(Texture texture)
        {
            Console.WriteLine("LightScense Modedl is filled Texture");
        }
    }

    class LightScenseTexture : Texture
    {
        public LightScenseTexture()
        {
            Console.WriteLine("LightScense Texture Created");
        }
    }
}
