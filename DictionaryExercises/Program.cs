﻿using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            var students = new Dictionary<int, string>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.WriteLine("name: ");
                newStudent = Console.ReadLine();

                if (newStudent != "")
                {
                    // Get the student's id
                    Console.Write("id: ");
                    var newId = int.Parse(Console.ReadLine());

                    students.Add(newId, newStudent);
                }
            }
            while (newStudent != "");

            // Print student roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }

            Console.ReadLine();
        }
    }
}
