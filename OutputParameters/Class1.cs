namespace OutputParameters
{
    class Class1
    {
        static Class1()
        {

        }

        public void Divider(int num1, out int mainNum)
        {
            int sum = num1 / 2;
            mainNum = sum;
        }

        public void Divider(decimal num1, out decimal mainNum)
        {
            decimal sum = num1 / 2;
            mainNum = sum;
        }
    }
}
