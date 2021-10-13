using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG2782_WMalan_EWalters_JBlignaut.Business_Layer
{
    internal class Student:IComparable<Student>
    {
        int studentNumber;
        string studentFullname,DateOfBirth, gender, phone, address, moduleCode,photo;

        public Student(int studentNumber, string studentFullname, string dateOfBirth, string gender, string phone, string address, string moduleCode,string photo)
        {
            this.StudentNumber = studentNumber;
            this.StudentFullname = studentFullname;
            DateOfBirth1 = dateOfBirth;
            this.Gender = gender;
            this.Phone = phone;
            this.Address = address;
            this.ModuleCode = moduleCode;
            this.Photo = photo;

        }

        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
        public string StudentFullname { get => studentFullname; set => studentFullname = value; }
        public string DateOfBirth1 { get => DateOfBirth; set => DateOfBirth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string ModuleCode { get => moduleCode; set => moduleCode = value; }
        public string Photo { get => photo; set => photo = value; }

        public int CompareTo(Student other)
        {
           return this.StudentFullname.CompareTo(other.StudentFullname);
        }
    }
}
