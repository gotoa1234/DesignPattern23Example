using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23Example.Pattern.Creational.FactoryMethod.Inpletment
{
    public class FactoryMethodExample
    {
        public FactoryMethodExample()
        {
            Patrix patrix = new Patrix();

            patrix.LoadScene("HalfPaper");

            patrix.LoadScene("Matrix");
        }
    }

    class Patrix
    {
        private PatrixSceneFactory GetGameScene(string gameSceneName)
        {
            switch (gameSceneName)
            {
                case "HalfPaper":
                    return new HalfPaperFactory();
                case "Matrix":
                    return new MatrixFactory();
                default:
                    break;
            }


            return (PatrixSceneFactory)Assembly.Load("FactoryMethodExample").CreateInstance("FactoryMethodExample." + gameSceneName +"Factory");
        }

        public void LoadScene(string gameSceneName)
        {
            PatrixSceneFactory psf = GetGameScene(gameSceneName);
            PatrixScene ps = psf.CreateScene();
            ps.InitScene();
        }
    }

    abstract class PatrixSceneFactory
    {
        public abstract PatrixScene CreateScene();

    }

    abstract class PatrixScene
    {
        public void InitScene()
        {
            Texture texture = CreateTexture();
            Model model = CreateModel();
            model.FillTexture(texture);
        }
        public abstract Model CreateModel();
        public abstract Texture CreateTexture();
    }

    abstract class Model
    {
        public abstract void FillTexture(Texture exture);
    }

    abstract class Texture
    {
    }

    #region 產品A : HalfPaper 的工廠相關

    /// <summary>
    /// 產品A : HalfPaper 的工廠
    /// </summary>
    class HalfPaperFactory : PatrixSceneFactory
    {
        public override PatrixScene CreateScene()
        {
            return new HalfPaper();
        }
    }

    class HalfPaper : PatrixScene
    {
        public HalfPaper()
        {
            Console.WriteLine("HalfPaper Creating");
        }
        public override Model CreateModel()
        {
            return new HalfPaperModel();
        }
        public override Texture CreateTexture()
        {
            return new HalfPaperTexture();
        }
    }

    class HalfPaperModel : Model
    {
        public HalfPaperModel()
        {
            Console.WriteLine("HalfPaper Model Creating");
        }
        public override void FillTexture(Texture exture)
        {
            Console.WriteLine("HalfPaper Model is filled Texture");
        }
    }

    class HalfPaperTexture : Texture
    {
        public HalfPaperTexture()
        {
            Console.WriteLine("HalfPaper Texture Created");
        }
    }

    #endregion

    #region 產品B : Matrix 的工廠相關


    class MatrixFactory : PatrixSceneFactory
    {
        public override PatrixScene CreateScene()
        {
            return new Matrix();
        }
    }

    class Matrix : PatrixScene
    {
        public Matrix()
        {
            Console.WriteLine("Matrix Created");
        }

        public override Model CreateModel()
        {
            return new MatrixModel();
        }

        public override Texture CreateTexture()
        {
            return new MatrixTexture();
        }
    }

    class MatrixModel : Model
    {
        public MatrixModel()
        {
            Console.WriteLine("Matrix Model Created");
        }

        public override void FillTexture(Texture exture)
        {
            Console.WriteLine("Matrix Model is filled Texture");
        }
    }

    class MatrixTexture : Texture
    {
        public MatrixTexture()
        {
            Console.WriteLine("Matrix Texture Created");
        }
    }
    #endregion

}

