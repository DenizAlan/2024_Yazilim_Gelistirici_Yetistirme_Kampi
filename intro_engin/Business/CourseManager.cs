using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using intro_engin.DataAccess.Abstracts;
using intro_engin.DataAccess.Concretes;
using intro_engin.Entities;

namespace intro_engin.Business;

public class CourseManager
{
	private readonly ICourseDal _courseDal;

	public CourseManager(CourseDal courseDal)
	{
		_courseDal = courseDal;
	}

	public List<Course> GetAll()
	{
		//business rules
		
        return _courseDal.GetAll();
    }
}
