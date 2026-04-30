namespace Tutorial.OOP_Concept
{
    internal class Customer
    {
        int _CustId;
        string _Cname;
        bool _Status;
        double _Balance;
        public Customer(int CustId, string Cname, bool Status, double Balance)
        {
            this._CustId = CustId;
            this._Cname = Cname;
            this._Status = Status;
            this._Balance = Balance;

        }

        public int CustId
        {
            get { return _CustId; }
        }
        public string Cname
        {
            get { return _Cname; }
            set
            {
                if (_Status == true)
                    _Cname = value;
            }
        }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }

        }
        public double Balance
        {
            get { return _Balance; }
            set
            {
                if (_Status == true)
                {
                    if (value >= 500)
                        _Balance = value;
                }
            }

        }
    }
}
