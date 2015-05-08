
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class CourseDao : GenericDao<Course>, ICourseDao{
    

        override protected IRowMapper<Course> GetRowMapper()
        {
            return new CourseRowMapper();
        }

        public IList<Course> GetAllCourse()
        {
            string command = @"SELECT * FROM Course ORDER BY CourseID ASC";
            IList<Course> Course = ExecuteQueryWithRowMapper(command);
            return Course;
        }

        public Course GetCourseById(string id)
        {
            string command = @"SELECT * FROMCourse WHERE CourseID = @Id";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Id", DbType.String).Value = id;

            IList<Course> Course = ExecuteQueryWithRowMapper(command, parameters);
            if (Course.Count > 0)
            {
                return Course[0];
            }

            return null;
        }

    }
}
