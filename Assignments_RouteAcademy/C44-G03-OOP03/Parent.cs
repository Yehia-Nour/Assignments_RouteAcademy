namespace Demo.Inheritance
{
    internal class Parent
    {
        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Constructors
        public Parent(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
        #endregion

        #region Methods
        public int Product()
        {

            return X * Y;
        }
        public override string ToString()
        {
            return $"X: {X} \nY: {Y}";
        } 
        #endregion
    }
}
