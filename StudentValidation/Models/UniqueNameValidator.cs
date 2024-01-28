//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;


//namespace StudentValidation.Models

//{
//    //[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
//    public class UniqueNameValidator : ValidationAttribute
//    {
//        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
//        {
//            var student = (Student)validationContext.ObjectInstance;

//            if (!string.IsNullOrEmpty(student.Name))
//            {
//                List<Student> existingStudents = GetExistingStudents()
//                if (existingStudents.Any(s => s.Id != student.Id && s.Name.Equals(student.Name, StringComparison.OrdinalIgnoreCase)))
//                {
//                    return new ValidationResult("Name must be unique among students.");
//                }
//            }
//            return ValidationResult.Success;
//        }

//    }
//}
