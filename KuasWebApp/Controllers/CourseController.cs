using KuasCore.Models;
using KuasCore.Services;
using KuasCore.Services.Impl;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace KuasWebApp.Controllers
{
    public class CourseController : ApiController
    {

        public ICourseService CourseService { get; set; }

        [HttpGet]
        public IList<Course> GetAllCourse()
        {
            var course = CourseService.GetAllCourses();
            return course;
        }

        [HttpGet]
        [ActionName("byId")]
        public Course GetAllCourseById(string id)
        {
            var course = CourseService.GetCourseById(id);

            if (course == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return course;
        }

    }
}
