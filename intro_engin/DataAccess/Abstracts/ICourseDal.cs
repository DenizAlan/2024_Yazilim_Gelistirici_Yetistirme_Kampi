using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using intro_engin.Entities;

namespace intro_engin.DataAccess.Abstracts
{
	public interface ICourseDal
	{
		List<Course> GetAll();
		void Add(Course course);
	}
}
