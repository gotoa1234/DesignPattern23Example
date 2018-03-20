using DesignPattern23Example.Pattern.Creational.AbstractFactory.Base;
using DesignPattern23Example.Pattern.Creational.AbstractFactory.Base.MapStruct;
using DesignPattern23Example.Pattern.Creational.AbstractFactory.Inpletment.PhysicalFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23Example.Pattern.Creational.AbstractFactory.Inpletment
{
    public class MapFactory
    {
        /// <summary>
        /// 抽象工廠模式- 當傳進對應的模式，回傳相應的具體工廠
        /// </summary>
        /// <param name="gameSceneName"></param>
        /// <returns></returns>
        private MapSceneFactory GetGameScene(string gameSceneName)
        {
            MapSceneFactory returnFactory = null;
            //這邊是範例，正常來說，您掌握住專案內程式的所有Abstract Factory (本範例為MapSceneFactory)
            //作法1.反射方式回傳具體工廠
            //var getRightAssemblyName = (typeof(MapSceneFactory).Assembly.FullName);
            ////類別所在的命名空間
            //string nameSpaceLocation = "DesignPattern23Example.Pattern.Creational.AbstractFactory.Inpletment.PhysicalFactory.";
            //returnFactory = (MapSceneFactory)System.Reflection.Assembly.Load(getRightAssemblyName).CreateInstance(nameSpaceLocation + "DarkScenes");


            //作法2.使用Switch Case 來回傳具體工廠
            switch (gameSceneName)
            {
                case "DarkMap":
                    returnFactory = new DarkScenes();
                    break;
                case "LightMap":
                    returnFactory = new LightScense();
                    break;
                default:
                    return null;//沒有工廠  ˇ_ˇ
                    break;
            }

            return returnFactory;
        }

        /// <summary>
        /// 對外提供的場景資訊端口
        /// </summary>
        /// <param name="gameSceneName"></param>
        public void LoadScene(string gameSceneName)
        {
            MapSceneFactory psf = GetGameScene(gameSceneName: gameSceneName);//傳進Scene名稱
            Texture texture = psf.CreateTexture();//建立對應的文字結構模式
            Model model = psf.CreateModel();//建立對應的Model
            model.FillTexture(texture);//回傳該Model裡面是包含的模式型態
        }

    }
}
