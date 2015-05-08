using KuasCore.Dao;
using KuasCore.Models;
using System.Collections.Generic;

namespace KuasCore.Services
{
    public interface ICourseService
    {

        /// <summary>
        ///     取得所有員工資料.
        /// </summary>
        /// <returns>
        ///     所有員工資料
        /// </returns>
        IList<Course> GetAllCourses();

        /// <summary>
        ///     依據 ID 取得員工資料.
        /// </summary>
        /// <returns>
        ///     該員工資料
        /// </returns>
        Course GetCourseById(string id);

    }
}
