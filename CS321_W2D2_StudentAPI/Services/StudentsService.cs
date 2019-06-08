using System;
using System.Collections.Generic;
using System.Linq;
using CS321_W2D2_StudentAPI.Models;

namespace CS321_W2D2_StudentAPI.Services
{
    public class StudentsService : IStudentsService
    {
        // seed some initial Student data
        private List<Student> _students = new List<Student>()
        {
            new Student
            {
                Id = 1,
            },
            new Student
            {
                Id = 2,
            }
        };
        // keep track of next id number
        private int _nextId = 3;

        public Student Add(Student student)
        {
            // assign an id (and then increment _nextId for next time)
            student.Id = _nextId++;
            // store in the list of Posts
            _students.Add(student);
            // return the new Student with Id filled in
            return student;
        }

        public Student Get(int id)
        {
            // return the specified Student or null if not found
            return _students.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

        public Student Update(Student updatedStudent)
        {
            // get the Student object in the current list with this id 
            var currentStudent = this.Get(updatedStudent.Id);

            // return null if item to update isn't found
            if (currentStudent == null) return null;

            // copy the property values from the updated student into the current student object
            currentStudent.FirstName = updatedStudent.FirstName;
            currentStudent.LastName = updatedStudent.LastName;
            currentStudent.BirthDate = updatedStudent.BirthDate;
            currentStudent.Email = updatedStudent.Email;
            currentStudent.Phone = updatedStudent.Phone;

            return currentStudent;
        }

        public void Remove(Student student)
        {
            _students.Remove(student);
        }
    }
}
