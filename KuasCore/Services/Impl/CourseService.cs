﻿using KuasCore.Dao;
using KuasCore.Dao.Impl;
using KuasCore.Models;
using System.Collections.Generic;

namespace KuasCore.Services.Impl
{
    public class CourseService : ICourseService
    {

        public ICourseDao CourseDao { get; set; }

        public IList<Course> GetAllCourse()
        {
            return CourseDao.GetAllCourse();
        }

        public Course GetCourseById(string id)
        {
            return CourseDao.GetCourseById(id);
        }

    }

}
