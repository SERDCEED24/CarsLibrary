using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsLibrary
{
    public class PassengerCar : Car
    {
        // Поля
        protected int seats;
        protected int maxSpeed;
        // Свойства
        public int Seats
        {
            get
            {
                return seats;
            }
            set
            {
                if (value > 0)
                    seats = value;
                else
                {
                    Console.WriteLine("Кол-во сидений должно быть больше 0!");
                    seats = 1;
                }
            }
        }
        public int MaxSpeed
        {
            get
            {
                return maxSpeed;
            }
            set
            {
                if (value > 0)
                    maxSpeed = value;
                else
                {
                    Console.WriteLine("Максимальная скорость должна быть больше 0!");
                    maxSpeed = 1;
                }
            }
        }
        // Конструкторы
        public PassengerCar() : base()
        {
            Seats = 1;
            MaxSpeed = 1;
        }
        public PassengerCar(int num, string b, int y, string c, int p, int gc, int s, int ms) : base(num, b, y, c, p, gc)
        {
            Seats = s;
            MaxSpeed = ms;
        }
        public PassengerCar(PassengerCar other) : base(other)
        {
            Seats = other.Seats;
            MaxSpeed = other.MaxSpeed;
        }
        // Методы
        public override void ShowVirt()
        {
            base.ShowVirt();
            Console.WriteLine($"Количество мест: {Seats}, Максимальная скорость: {MaxSpeed} км/ч");
        }
        public void ShowReg()
        {
            base.ShowReg();
            Console.WriteLine($"Количество мест: {Seats}, Максимальная скорость: {MaxSpeed} км/ч");
        }
        public override string ToString()
        {
            return base.ToString() + $", Количество мест: {Seats}, Максимальная скорость: {MaxSpeed} км/ч";
        }
        public override void Init()
        {
            base.Init();

            Console.WriteLine("Введите количество мест:");
            Seats = VHS.Input("Количество мест не может быть отрицательным.", x => 0 <= x && x <= 10);

            Console.WriteLine("Введите максимальную скорость:");
            MaxSpeed = VHS.Input("Максимальная скорость не может быть отрицательной.", x => 0 <= x && x <= 300);
        }
        public override void RandomInit()
        {
            base.RandomInit();
            Seats = rnd.Next(2, 10);
            MaxSpeed = rnd.Next(80, 300);
        }
        public override object Clone()
        {
            return new PassengerCar(this.id.Number, this.Brand, this.Year, this.Color, this.Price, this.gClearance, this.Seats, this.MaxSpeed);
        }
        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
                return false;
            PassengerCar other = (PassengerCar)obj;
            return Seats == other.Seats && MaxSpeed == other.MaxSpeed;
        }
    }
}
