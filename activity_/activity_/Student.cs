using System;

class Student : Person
{
    public string name;
    public string password;
    public string StudentID;
    public string type;

    public Student(string valuename, string valuepassword, string valueStudentID, string valuetype) : base(valuename, valuepassword, valuetype)
    {
        name = valuename;
        password = valuepassword;
        StudentID = valueStudentID;
        type = valuetype;
    }
}