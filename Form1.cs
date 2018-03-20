using DesignPattern23Example.Pattern.Creational.Singleton.Impletment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignPattern23Example.Pattern.Creational.AbstractFactory.Inpletment;
using DesignPattern23Example.Pattern.Creational.FactoryMethod.Inpletment;

namespace DesignPattern23Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 創建-單例模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Singleton_button_Click(object sender, EventArgs e)
        {
            //進行單例模式的負載平衡模擬
            SingletonExample Creational = new SingletonExample();


        }

        private void AbstractFactory_button_Click(object sender, EventArgs e)
        {
            //進行抽象工廠模式的模擬建立
            AbstractFactoryExample Creational = new AbstractFactoryExample();
        }

        private void FactoryMethod_button_Click(object sender, EventArgs e)
        {
            //進行抽象工廠方法的模擬建立
            FactoryMethodExample Creational = new FactoryMethodExample();
        }
    }
}
