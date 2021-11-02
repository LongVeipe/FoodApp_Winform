using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    class Meals
    {
        private static Meals __instant;

        public static Meals getInstant()
        {
            if (__instant == null)
                __instant = new Meals();
            return __instant;
        }

        private DataTable meals = new DataTable();
        public Meals()
        {
            meals.Columns.Add("id", typeof(string));
            meals.Columns.Add("category", typeof(int));
            meals.Columns.Add("name", typeof(string));
            meals.Columns.Add("img", typeof(string));
            meals.Columns.Add("price", typeof(int));
            meals.Columns.Add("number", typeof(int));
            initData();
        }

        private void initData()
        {
            //beef
            add(1, "Beef and Mustard Pie", @"..\..\..\img\meals\beef\sytuqu1511553755.jpg", 100000);
            add(1, "Beef and Oyster pie", @"..\..\..\img\meals\beef\wrssvt1511556563.jpg", 100000);
            add(1, "Beef Bourguignon", @"..\..\..\img\meals\beef\vtqxtu1511784197.jpg", 100000);
            add(1, "Beef Brisket Pot Roast", @"..\..\..\img\meals\beef\ursuup1487348423.jpg", 100000);
            add(1, "Beef Dumpling Stew", @"..\..\..\img\meals\beef\uyqrrv1511553350.jpg", 100000);

            //chicken
            add(2, "Ayam Percik", @"..\..\..\img\meals\chicken\020z181619788503.jpg", 130000);
            add(2, "Brown Stew Chicken", @"..\..\..\img\meals\chicken\sypxpx1515365095.jpg", 130000);
            add(2, "Chick-Fil-A Sandwich", @"..\..\..\img\meals\chicken\sbx7n71587673021.jpg", 130000);
            add(2, "Chicken & mushroom Hotpot", @"..\..\..\img\meals\chicken\uuuspp1511297945.jpg", 130000);
            add(2, "Chicken Alfredo Primavera", @"..\..\..\img\meals\chicken\syqypv1486981727.jpg", 130000);
            add(2, "Chicken Basquaise", @"..\..\..\img\meals\chicken\wruvqv1511880994.jpg", 130000);
            add(2, "Chicken Congee", @"..\..\..\img\meals\chicken\1529446352.jpg", 130000);
            add(2, "Chicken Couscous", @"..\..\..\img\meals\chicken\qxytrx1511304021.jpg", 130000);
            add(2, "Chicken Enchilada Casserole", @"..\..\..\img\meals\chicken\qtuwxu1468233098.jpg", 130000);
            add(2, "Chicken Fajita Mac and Cheese", @"..\..\..\img\meals\chicken\qrqywr1503066605.jpg", 130000);
            add(2, "Chicken Ham and Leek Pie", @"..\..\..\img\meals\chicken\xrrtss1511555269.jpg", 130000);
            add(2, "Chicken Handi", @"..\..\..\img\meals\chicken\wyxwsp1486979827.jpg", 130000);

            //dessert
            add(3, "Apam balik", @"..\..\..\img\meals\dessert\adxcbq1619787919.jpg", 170000);
            add(3, "Apple & Blackberry Crumble", @"..\..\..\img\meals\dessert\xvsurr1511719182.jpg", 180000);
            add(3, "Apple Frangipan Tart", @"..\..\..\img\meals\dessert\wxywrq1468235067.jpg", 160000);
            add(3, "Choc Chip Pecan Pie", @"..\..\..\img\meals\dessert\rqvwxt1511384809.jpg", 125000);
            add(3, "Chocolate Avocado Mousse", @"..\..\..\img\meals\dessert\uttuxy1511382180.jpg", 100000);
            add(3, "Key Lime Pie", @"..\..\..\img\meals\dessert\qpqtuu1511386216.jpg", 220000);
            add(3, "Madeira Cake", @"..\..\..\img\meals\dessert\urtqut1511723591.jpg", 190000);
            add(3, "Pancakes", @"..\..\..\img\meals\dessert\rwuyqx1511383174.jpg", 1950000);
            add(3, "Portuguese custard tarts", @"..\..\..\img\meals\dessert\vmz7gl1614350221.jpg", 200000);
            add(3, "Walnut Roll Gužvara", @"..\..\..\img\meals\dessert\u9l7k81628771647.jpg", 210000);

            //lamb
            add(4, "Kapsalon", @"..\..\..\img\meals\lamb\sxysrt1468240488.jpg", 170000);
            add(4, "Keleya Zaara", @"..\..\..\img\meals\lamb\8x09hy1560460923.jpg", 180000);
            add(4, "Lamb and Lemon Souvlaki", @"..\..\..\img\meals\lamb\rjhf741585564676.jpg", 210000);
            add(4, "Lamb and Potato pie", @"..\..\..\img\meals\lamb\sxrpws1511555907.jpg", 215000);
            add(4, "Lamb tomato and sweet spices", @"..\..\..\img\meals\lamb\qtwtss1468572261.jpg", 140000);
            add(4, "Lamb Tzatziki Burgers", @"..\..\..\img\meals\lamb\k420tj1585565244.jpg", 160000);
            add(4, "Lancashire hotpot", @"..\..\..\img\meals\lamb\uttrxw1511637813.jpg", 140000);
            add(4, "McSinghs Scotch pie", @"..\..\..\img\meals\lamb\vssrtx1511557680.jpg", 150000);
            add(4, "Rigatoni with fennel sausage sauce", @"..\..\..\img\meals\lamb\qtqvys1468573168.jpg", 150000);
            add(4, "Stuffed Lamb Tomatoes", @"..\..\..\img\meals\lamb\u55lbp1585564013.jpg", 150000);
            add(4, "Tunisian Lamb Soup", @"..\..\..\img\meals\lamb\t8mn9g1560460231.jpg", 230000);
            add(4, "Lamb Tagine", @"..\..\..\img\meals\lamb\yuwtuu1511295751.jpg", 220000);
            add(4, "Lamb Rogan josh", @"..\..\..\img\meals\lamb\vvstvq1487342592.jpg", 170000);
        }
        public DataRow getMealsById(int id)
        {
            return meals.Rows[id];
        }

        public DataRow[] getMealsByName(string name)
        {
            DataRow[] row = meals.Select("[name] Like '%" + name + "%'");
            return row;
        }

        public void add(int category, string name, string img, int price)
        {
            string id = meals.Rows.Count.ToString();
            meals.Rows.Add(new object[] { id, category, name, img, price, 0});
            meals.AsDataView().Sort = "category ASC";
            meals.AcceptChanges();
        }

        public DataTable getMeals()
        {
            return meals;
        }

        public void Pay()
        {
            DataRow[] rows = getSelectedMeals();
            foreach(DataRow item in rows)
            {
                item[5] = 0;
            }
            meals.AcceptChanges();
        }
        public void changeNumber(string id, int number)
        {
            DataRow row = meals.Select("[id] = '" + id + "'")[0];
            row[5] = number;
            meals.AcceptChanges();
        }
        //public DataRow[] getJobsDisable()
        //{
        //    string id = "2";
        //    DataRow[] row = jobs.Select("[enable] = '" + id + "'");
        //    return row;
        //}

        public DataRow[] getMealsByCategory(int category)
        {
            DataRow[] row = meals.Select("[category] = " + category);
            return row;
        }

        public DataRow[] getSelectedMeals()
        {
            DataRow[] rows = meals.Select("[number] > 0");
            return rows;
        }
    }
}
