using System.Linq;

namespace PublicProtectedPrivate
{
    class Developer : Employee
    {
        public string Title;
        public string GetFullNameWithTitle()
        {
            //public, from child class
            return string.Format("{0}, {1}", base.GetFullName(), Title);
        }

        public bool IsSSNValid()
        {
            //protected, from child class
            return SSN != null && SSN.Count() == 11;
        }

        public bool IsFemale()
        {
            //private, from child class
            //return Sex == 'F'; ERROR!!

            //public method, from child class
            return GetSex() == 'F';
        }
    }
}
