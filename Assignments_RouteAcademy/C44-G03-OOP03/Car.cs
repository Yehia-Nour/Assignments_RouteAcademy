using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03G01
{
    internal class Car
    {
        #region Attributes
        private int id;
        private string model;
        private int speed;
        #endregion

        #region Properties
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
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

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
        #endregion

        //public Car()
        //{
        //    // Empty
        //}

        public Car(int id, string model, int speed)
        {
            this.id = id;
            this.model = model;
            this.speed = speed;

            Console.WriteLine("1st Constructor");
        }

        public Car(int id, string model) : this(id, model, 240)
        {
            //this.id = id;
            //this.model = model;
            //this.speed = 240;

            Console.WriteLine("2nd Constructor");
        }

        public Car(string model) : this(1000, model, 240)
        {
            //this.id = 1000;
            //this.model = model;
            //this.speed = 240;

            Console.WriteLine("3rd Constructor");
        }

        public override string ToString()
        {
            //return base.ToString(); // Day03G01.Car
            return $"Id: {id}, Model: {model}, Speed: {speed}";
        }

    }
}
