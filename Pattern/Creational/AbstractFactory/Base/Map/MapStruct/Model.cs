using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23Example.Pattern.Creational.AbstractFactory.Base.MapStruct
{
    /// <summary>
    /// 模組
    /// </summary>
    abstract class Model
    {
        /// <summary>
        /// 紋理
        /// </summary>
        /// <param name="texture"></param>
        public abstract void FillTexture(Texture texture);
    }
}
