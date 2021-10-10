using System;

class Teacher : Person
{
    public string name;
    public string password;
    public string EmployeeID;
    public string type;

    public Teacher(string valuename, string valuepassword, string valueEmployeeID, string valuetype) : base(valuename, valuepassword, valuetype)
    {
        name = valuename;
        password = valuepassword;
        EmployeeID = valueEmployeeID;
        type = valuetype;
    }
}