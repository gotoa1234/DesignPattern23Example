using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern23Example.Pattern.Creational.AbstractFactory.Base.MapStruct;

namespace DesignPattern23Example.Pattern.Creational.AbstractFactory.Base
{
    /// <summary>
    /// 抽象地圖
    /// </summary>
    abstract class MapSceneFactory
    {
        /// <summary>
        /// 建立模組
        /// </summary>
        /// <returns></returns>
        public abstract Model CreateModel();

        /// <summary>
        /// 建立紋理
        /// </summary>
        /// <returns></returns>
        public abstract Texture CreateTexture();
    }
}
