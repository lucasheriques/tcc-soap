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
        teacher.Name = "Lesandro Ponciano";
        teacher.Description = "Ótimo professor e orientador!";
        teacher.Disciplines = "Interação Humano Computador";
        teacher.University = "PUC Minas";
        teacher.Birthday = "22/01/1985";
        teachers.Add(teacher.Id, teacher);
        Teacher teacher2 = new Teacher();
        teacher2.Id = 2;
        teacher2.Name = "Maria Augusta";
        teacher2.Description = "Ótimo professor e orientador!";
        teacher2.Disciplines = "Interação Humano Computador";
        teacher2.University = "PUC Minas";
        teacher2.Birthday = "22/01/1985"; ;
        teachers.Add(teacher2.Id, teacher2);
        Teacher teacher3 = new Teacher();
        teacher3.Name = "Maria Werneck";
        teacher3.Id = 2;
        teacher3.Description = "Ótimo professor e orientador!";
        teacher3.Disciplines = "Interação Humano Computador";
        teacher3.University = "PUC Minas";
        teacher3.Birthday = "22/01/1985"; ;
        teachers.Add(teacher3.Id, teacher3);

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