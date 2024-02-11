using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using intro_engin.Business;
using intro_engin.DataAccess.Abstracts;
using intro_engin.Entities;

namespace intro_engin.DataAccess.Concretes
{
	public class CourseDal : ICourseDal
	{
		List<Course> courses;
		public CourseDal()
		{
			

			Course course1 = new Course();
			course1.Id = 1;
			course1.Name = "C#";
			course1.Description = ".net 8";
			course1.Price = 0;

			Course course2 = new Course();
			course2.Id = 2;
			course2.Name = "Java";
			course2.Description = "java 7";
			course2.Price = 10;

			Course course3 = new Course();
			course3.Id = 3;
			course3.Name = "Python";
			course3.Description = "python 7";
			course3.Price = 30;

			courses= new List<Course> { course1, course2 , course3};

		}		
		public List<Course> GetAll()
		{
			//sql ögren
			//Burada db işlemleri yapılır

			return courses;
		}

		public void Add(Course course)
		{
			courses.Add(course);
		}
	}
}
