﻿using System;
namespace lab9
{
    public class StudentsArray
    {
        private Student[] Students;
        private string[] Names = ["Sasha", "Masha", "Polina", "Stepan", "Svyatoslav", "Roman", "James"];
        static Random Rand = new Random();
        public int Length
        {
            get => Students.Length;
        }
        public Student this[int index]
        {
            get
            {
                if (index >= 0 && index < Students.Length)
                    return Students[index];
                throw new ArgumentException();
            }
            set
            {
                if (index >= 0 && index < Students.Length)
                    Students[index] = value;
                else
                    throw new ArgumentException();
            }
        }

        public StudentsArray()
        {
            Students = Array.Empty<Student>();
        }

        public StudentsArray(int len)
        {
            Students = new Student[len];
            for (int i = 0; i < len; i++)
            {
                Student s = new(Names[Rand.Next(0, Names.Length)], Rand.Next(18, 22), Rand.Next(0, 9) + Rand.NextDouble());
                Students[i] = s;
            }
        }

        public StudentsArray(int len, string[] namesArray, int[] ageArray, int[] gpaArray)
        {
            Students = new Student[len];
            for (int i = 0; i < len; i++)
            {
                Student s = new(namesArray[i], ageArray[i], gpaArray[i]);
                Students[i] = s;
            }
        }

        public StudentsArray(StudentsArray sa)
        {
            this.Students = new Student[sa.Length];
            for (int i = 0; i < sa.Students.Length; i++)
            {
                Student s = new(sa[i]);
                this.Students[i] = s;
            }
        }

        public void GetInfo()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Students[i].GetInfo();
            }
        }

        public override bool Equals(Object? obj)
        {
            if (obj == null || !(obj is StudentsArray))
                return false;
            return this.Students == ((StudentsArray)obj).Students;
        }
    }
}