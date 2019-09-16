using Models;
using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
public class SampleService : ISampleService
{
    List<Teacher> teachers;
    Dictionary<int, Teacher> teachersDetails;
    Teacher teacher;
    public SampleService()
    {
        teachers = new List<Teacher>();
        Teacher teacher01 = new Teacher();
        teacher01.Id = 1;
        teacher01.Name = "Lesandro Ponciano";
        teachers.Add(teacher01);


        Teacher teacher02 = new Teacher();
        teacher02.Id = 2;
        teacher02.Name = "Maria Augusta";
        teachers.Add(teacher02);

        Teacher teacher03 = new Teacher();
        teacher03.Id = 2;
        teacher03.Name = "Marcelo Werneck";
        teachers.Add(teacher03);


        teachersDetails = new Dictionary<int, Teacher>();
        teacher = new Teacher();
        teacher.Id = 1;
        teacher.Name = "Lesandro Ponciano";
        teacher.Description = "Ótimo professor e orientador!";
        teacher.Disciplines = "Interação Humano Computador";
        teacher.University = "PUC Minas";
        teacher.Birthday = "22/01/1985";
        teachersDetails.Add(teacher.Id, teacher);
        Teacher teacher2 = new Teacher();
        teacher2.Id = 2;
        teacher2.Name = "Maria Augusta";
        teacher2.Description = "Ótimo professor e orientador!";
        teacher2.Disciplines = "Interação Humano Computador";
        teacher2.University = "PUC Minas";
        teacher2.Birthday = "22/01/1985"; ;
        teachersDetails.Add(teacher2.Id, teacher2);
        Teacher teacher3 = new Teacher();
        teacher3.Name = "Maria Werneck";
        teacher3.Id = 3;
        teacher3.Description = "Ótimo professor e orientador!";
        teacher3.Disciplines = "Interação Humano Computador";
        teacher3.University = "PUC Minas";
        teacher3.Birthday = "22/01/1985"; ;
        teachersDetails.Add(teacher3.Id, teacher3);

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
        if (teachersDetails.ContainsKey(id))
            return (Teacher)teachersDetails[id];
        return null;
    }
    public List<Teacher> GetTeachers()
    {
        return teachers;
    }
}