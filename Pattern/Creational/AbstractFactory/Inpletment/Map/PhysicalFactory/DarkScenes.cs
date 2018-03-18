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
    /// 夜晚的地圖場景
    /// </summary>
    class DarkScenes : MapSceneFactory
    {
        /// <summary>
        /// 載入模組
        /// </summary>
        /// <returns></returns>
        public override Model CreateModel()
        {
            return new DarkScenesModel();
        }

        /// <summary>
        /// 建立紋理
        /// </summary>
        /// <returns></returns>
        public override Texture CreateTexture()
        {
            return new DarkScenesTexture();
        }
    }

    /// <summary>
    /// 模組內部實作細節
    /// </summary>
    class DarkScenesModel : Model
    {
        public DarkScenesModel()
        {
            Console.WriteLine("DarkScenes Model Created");
        }

        public override void FillTexture(Texture texture)
        {
            Console.WriteLine("DarkScenes Model is filled Texture");
        }
    }

    /// <summary>
    /// 紋理內部實作細節
    /// </summary>
    class DarkScenesTexture : Texture
    {
        public DarkScenesTexture()
        {
            Console.WriteLine("DarkScenes Texture Created");
        }
    }

}
