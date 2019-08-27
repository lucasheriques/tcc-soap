using Models;
using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
public class SampleService : ISampleService
{
    Dictionary<int, Teacher> teachers;
    Teacher teacher;
    public SampleService()
    {
        teachers = new Dictionary<int, Teacher>();
        teacher = new Teacher();
        teacher.Id = 1;
        teacher.Name = "Lucas";
        teachers.Add(teacher.Id, teacher);
        Teacher teacher2 = new Teacher();
        teacher2.Id = 2;
        teacher2.Name = "Iara";
        teacher2.Description = "Great teacher!";
        teacher2.University = "PUC Minas";
        teacher2.Birthday = "18/10/1996";
        teacher2.Disciplines = "Mobile";
        teachers.Add(teacher2.Id, teacher2);

    }
    public string Test(string s)
    {
        Console.WriteLine("Test Method Executed!");
        return s;
    }
    public void XmlMethod(XElement xml)
    {
        Console.WriteLine(xml.ToString());
    }
    public Teacher GetTeacher(int id)
    {
        Console.WriteLine("Teacher method " + id);
        if (teachers.ContainsKey(id))
            return (Teacher)teachers[id];
        return null;
    }
    public List<Teacher> GetTeachers()
    {
        return new List<Teacher>(teachers.Values);
    }
}