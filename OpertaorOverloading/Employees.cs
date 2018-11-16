

namespace OpertaorOverloading
{
    class Employees
    {
        public Employees()
        {

        }

        public int Id { get; set; }

        public static bool operator ==(Employees employees1, Employees employees2)
        {
            if(employees1.Id == employees2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool operator !=(Employees employees1, Employees employees2)
        {
            if (employees1.Id != employees2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
