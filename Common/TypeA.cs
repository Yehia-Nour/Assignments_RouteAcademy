namespace Common
{
	public class TypeA
    {
        // Default Access Modifier inside the class or the Struct is "private" 

        /*private*/
        int X;
        internal int Y;
        public int Z;

        //public void Print()
        //{
        //    Console.WriteLine(X);
        //}
    }

    public enum Gender
    {
        Male,
        Female
    }



	public interface ICar
    {
        void Accelrate();
    }

    public class BMWCar : ICar
    {
        public void Accelrate()
        {
            // 
        }
    }


}
