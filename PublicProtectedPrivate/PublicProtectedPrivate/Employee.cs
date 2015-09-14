namespace PublicProtectedPrivate
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        protected string SSN;
        private char Sex;
        public string GetFullName()
        {
            //public, from same class
            return string.Format("{0} {1}", FirstName, LastName);
        }
        public string GetSSN()
        {
            //protected, from same class 
            return SSN;
        }
        public void SetSSN(string SSN)
        {
            //protected, from same class 
            this.SSN = SSN;
        }

        public void SetSex(char sex)
        {
            //private, from same class 
            this.Sex = sex;
        }
        public char GetSex()
        {
            //private, from same class 
            return Sex;
        }
    }
}