﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp_lab3
{
    public class Furniture
    {
        private int date_prod; //дата производства
        private string type; //вид мебели
        private string material; //материал
        public Furniture(string type, int date, string material)//конструктор с 3 аргументами
        {
            this.type = type;
            this.date_prod = date;
            this.material = material;
        }

        public Furniture(int date, string material)//конструктор с двумя аргументами
        {
            this.date_prod = date;
            type = "Шкаф";
            this.material = material;
        }

        public Furniture(int date) //конструктор с одним аргументом
        {
            this.date_prod = date;
            type = "Шкаф";
            material = "Фанера";
        }


        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public int Date_prod
        {
            get
            {
                return date_prod;
            }
            set
            {
                date_prod = value;
            }
        }

        public string Material
        {
            get
            {
                return material;
            }
            set
            {
                material = value;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Класс: Мебель");
            Console.WriteLine("Вид мебели: {0}", type);
            Console.WriteLine("Дата производства: {0}", Convert.ToString(date_prod));
            Console.WriteLine("Материал: {0}", material);
        }
    }

    public class Shkaf : Furniture
    {
        private string color; //цвет шкафа
        private static int count = 0; //счетчик
        public Shkaf(int date, string material, string color) : base(date, material)//конструктор
        {

            this.color = color;
            count++;
        }

        public Shkaf(int date, string color) : base(date)//конструктор
        {

            this.color = color;
            count++;
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Класс: Шкаф");
            Console.WriteLine("Цвет шкафа: {0}", color);

        }
        public static void HowManyShkafs()
        {
            Console.WriteLine("Количество шкафов: {0}", count);
        }

    }

    public class ForPosuda : Shkaf
    {
        private string model; //модель
        public ForPosuda(int date, string material, string color, string model) : base(date, material, color) //конструктор
        {
            this.model = model;
        }

        public ForPosuda(int date, string color, string model) : base(date, color) //конструктор
        {
            this.model = model;
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Класс: для посуды");
            Console.WriteLine("Модель для посуды: {0}", model);

        }
    }
    public class ForObuv : Shkaf
    {
        private string model; //модель
        public ForObuv(int date, string material, string color, string model) : base(date, material, color)//конструктор
        {
            this.model = model;
        }

        public ForObuv(int date, string color, string model) : base(date, color)//конструктор
        {
            this.model = model;
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Класс: для обуви");
            Console.WriteLine("модель для обуви: {0}", model);

        }
    }
    public class ForOdejda : Shkaf
    {
        ForOdejda[] data;
        private string model; //модель
        public ForOdejda this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
        public ForOdejda(int date, string material, string color, string model) : base(date, material, color)//конструктор
        {
            this.model = model;
        }

        public ForOdejda(int date, string color, string model) : base(date, color)//конструктор
        {
            this.model = model;
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Класс: для одежды");
            Console.WriteLine("Модель для одежды: {0}", model);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Furniture furniture = new Furniture("Тумбочка", 2020, "Фонера");
            furniture.ShowInfo();
            Console.WriteLine();
            Shkaf.HowManyShkafs();
            Console.WriteLine();
            Shkaf shkaf = new Shkaf(2019, "Сереневый");
            shkaf.ShowInfo();
            Console.WriteLine();
            ForPosuda ForPosuda = new ForPosuda(2017, "Черный", "с стеклянными матовыми дверцами");
            ForPosuda.ShowInfo();
            Console.WriteLine();
            Shkaf.HowManyShkafs();
            Console.WriteLine();
            ForObuv ForObuv = new ForObuv(2015, "Бежевый", "с стеклянными глянцевыми дверцами");
            ForObuv.ShowInfo();
            Console.WriteLine();
            ForOdejda ForOdejda = new ForOdejda(1950, "Мореный дуб", "Черный", "с позолоченными ручками");
            ForOdejda.ShowInfo();
            Console.WriteLine();
            Shkaf.HowManyShkafs();
            Console.ReadLine();
        }

    }
}
