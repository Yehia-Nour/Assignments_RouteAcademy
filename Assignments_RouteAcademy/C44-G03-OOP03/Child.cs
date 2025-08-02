namespace Demo.Inheritance
{
    internal class Child : Parent
    {

        public int Z { get; set; }
        public Child(int _X, int _Y, int _Z) : base(_X, _Y) /*Constructor Chaining*/
        {
            //X = _X;
            //Y = _Y;
            Z = _Z;

        }

        public new int Product() /*New Version*/
        {
            //return X * Y * Z;
            return base.Product() * Z;
        }

        public override string ToString()
        {
            //return $"X: {X} \nY: {Y} \nZ: {Z}";
            return $"{base.ToString()} \nZ: {Z}";
        }
    }
}
