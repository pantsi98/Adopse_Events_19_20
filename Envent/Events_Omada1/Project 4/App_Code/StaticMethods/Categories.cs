using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.App_Code.StaticMethods
{
    class Categories
    {
        private int id;
        private string name;
        private int father;
        public static List<Categories> categories = new List<Categories>();

        static enventDataSetTableAdapters.categoryTableAdapter cat = new enventDataSetTableAdapters.categoryTableAdapter();
        static List<enventDataSet.categoryRow> catList = new List<enventDataSet.categoryRow>();


        public Categories( int id, string name , int father)
        {
            this.id = id;
            this.name = name;
            this.father = father;
        }

        public static void FillCategoryData()
        {
            catList = cat.GetCategories().ToList();
            for (int i = 0; i < catList.Count; i++)
            {
                Categories categoryItem = new Categories(catList.ElementAt(i).id, catList.ElementAt(i).name, catList.ElementAt(i).father);
                categories.Add(categoryItem);
            }
        }

        public int GetID()
        {
            return id;
        }

        public String GetName()
        {
            return name;
        }

        public int GetFather()
        {
            return father;
        }
    }
}
