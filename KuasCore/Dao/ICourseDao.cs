using KuasCore.Models;
using System;
using System.Collections.Generic;

namespace KuasCore.Dao
{
    public interface ICourseDao
    {

        IList<Course> GetAllCourse();

        Course GetCourseById(string id);

    }
}
