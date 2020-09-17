using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0915
{
    class Drama
    {
        #region 멤버변수
        private int chenal;
        public string title;
        private string maleActor;
        private string femalActor;
        #endregion
        #region property
        public string MaleActor
        {
            get{return maleActor;}
            set{maleActor=value;}


        }

        public string FemalActor
        {
            get { return femalActor; }
            set { femalActor = value; }
        }
        #endregion

    }
    class ClassText2
    {
        static void Main()
        {
            Drama d1 = new Drama();
            d1.title = "악의 꽃";
            d1.MaleActor = "이준기";
            d1.FemalActor = "문채원";
            Console.WriteLine();
        }
    }
}
