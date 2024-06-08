using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsLibrary
{
    public class SUV : Car
    {
        // Поля
        protected bool allWheelDrive;
        protected string offRoadType;
        // Свойства
        public bool AllWheelDrive { get; set; }
        public string OffRoadType { get; set; }
        // Конструкторы
        public SUV() : base()
        {
            AllWheelDrive = true;
            OffRoadType = "Нет типа";
        }
        public SUV(int num, string b, int y, string c, int p, int gc, bool awd, string ot) : base(num, b, y, c, p, gc)
        {
            AllWheelDrive = awd;
            OffRoadType = ot;
        }
        public SUV(SUV other) : base(other)
        {
            AllWheelDrive = other.AllWheelDrive;
            OffRoadType = other.OffRoadType;
        }
        // Методы
        public override void ShowVirt()
        {
            base.ShowVirt();
            Console.WriteLine($"Полный привод: {AllWheelDrive}, Тип бездорожья: {OffRoadType}");
        }
        public void ShowReg()
        {
            base.ShowReg();
            Console.WriteLine($"Полный привод: {AllWheelDrive}, Тип бездорожья: {OffRoadType}");
        }
        public override string ToString()
        {
            return base.ToString() + $", Полный привод: {AllWheelDrive}, Тип бездорожья: {OffRoadType}";
        }
        public override void Init()
        {
            base.Init();

            Console.WriteLine("Есть ли полный привод?(да - 1, нет - 0)");
            AllWheelDrive = Convert.ToBoolean(VHS.Input("Количество мест не может быть отрицательным.", x => 0 <= x && x <= 1));

            Console.WriteLine("Введите тип бездорожья");
            OffRoadType = Console.ReadLine();
        }
        public override void RandomInit()
        {
            base.RandomInit();
            string[] ORTypes = { "Песчаный", "Гравийный", "Лесной", "Каменистый", "Болотный" };
            AllWheelDrive = Convert.ToBoolean(rnd.Next(0, 1));
            OffRoadType = ORTypes[rnd.Next(5)];
        }
        public override object Clone()
        {
            return new SUV(this.id.Number, this.Brand, this.Year, this.Color, this.Price, this.gClearance, this.AllWheelDrive, this.OffRoadType);
        }
        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
                return false;
            SUV other = (SUV)obj;
            return AllWheelDrive == other.AllWheelDrive && OffRoadType == other.OffRoadType;
        }
    }
}
