namespace Tutorial.OOP_Concept.Indexers
{
    internal class Employee
    {
        int id;
        string name, jobTitle, dept, location;
        double salary;
        public Employee(int id, string name, string jobTitle, string dept, string location, double salary)
        {
            this.id = id;
            this.name = name;
            this.jobTitle = jobTitle;
            this.dept = dept;
            this.location = location;
            this.salary = salary;
        }

        //    public object this[int index]
        //    {
        //        get
        //        {
        //            return index switch
        //            {
        //                0 => id,
        //                1 => name,
        //                2 => jobTitle,
        //                3 => dept,
        //                4 => location,
        //                5 => salary,
        //                _ => throw new IndexOutOfRangeException("Invalid index")
        //            };
        //        }
        //        set
        //        {
        //            switch (index)
        //            {
        //                case 0:
        //                    id = Convert.ToInt32(value);
        //                    break;
        //                case 1:
        //                    name = Convert.ToString(value);
        //                    break;
        //                case 2:
        //                    jobTitle = Convert.ToString(value);
        //                    break;
        //                case 3:
        //                    dept = Convert.ToString(value);
        //                    break;
        //                case 4:
        //                    location = Convert.ToString(value);
        //                    break;
        //                case 5:
        //                    salary = Convert.ToDouble(value);
        //                    break;
        //                default:
        //                    throw new IndexOutOfRangeException("Invalid index");
        //            }
        //        }
        //    } public string Name { get { return name; } set { name = value; } }

        //public object this[int index]
        //{
        //    get
        //    {
        //        if (index == 0)
        //            return id;
        //        else if (index == 1)
        //            return name;
        //        else if (index == 2)
        //            return jobTitle;
        //        else if (index == 3)
        //            return dept;
        //        else if (index == 4)
        //            return location;
        //        else if (index == 5)
        //            return salary;
        //        else
        //            throw new IndexOutOfRangeException("Invalid index");
        //    }
        //    set
        //    {
        //        if (index == 0)
        //            id = (int)value;
        //        else if (index == 1)
        //            name = (string)value;
        //        else if (index == 2)
        //            jobTitle = (string)value;
        //        else if (index == 3)
        //            dept = (string)value;
        //        else if (index == 4)
        //            location = (string)value;
        //        else if (index == 5)
        //            salary = (double)value;
        //        else
        //            throw new IndexOutOfRangeException("Invalid index");
        //    }
        //}

        public object this[string name]
        {
            get
            {
                if (name.ToLower() == "id")
                    return id;
                else if (name == "name")
                    return this.name;
                else if (name == "jobTitle")
                    return jobTitle;
                else if (name == "dept")
                    return dept;
                else if (name == "location")
                    return location;
                else if (name == "salary")
                    return salary;
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
            set
            {
                if (name == "id")
                    id = Convert.ToInt32(value);
                else if (name == "name")
                    name = (string)value;
                else if (name == "jobTitle")
                    jobTitle = (string)value;
                else if (name == "dept")
                    dept = (string)value;
                else if (name == "location")
                    location = (string)value;
                else if (name == "salary")
                    salary = (double)value;
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
        }
    }
}
