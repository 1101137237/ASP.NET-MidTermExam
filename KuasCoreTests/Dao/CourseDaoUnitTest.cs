using KuasCore.Dao;
using KuasCore.Dao.Impl;
using KuasCore.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Testing.Microsoft;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace KuasCoreTests.Dao
{

    [TestClass]
    public class CourseDaoUnitTest : AbstractDependencyInjectionSpringContextTests
    {
        #region 單元測試 Spring 必寫的內容 
        
        override protected string[] ConfigLocations
        {
            get
            {
                return new String[] { 
                    // assembly://MyAssembly/MyNamespace/ApplicationContext.xml
                    "~/Config/KuasCoreDatabase.xml",
                    "~/Config/KuasCoreTests.xml" 
                };
            }
        }

        #endregion

        public ICourseDao CourseDao { get; set; }

        [TestMethod]
        public void TestCourseDao_GetCourseById()
        {
            Course course = CourseDao.GetCourseById("s001");
            Assert.IsNotNull(course);
            Console.WriteLine("員工編號為 = " + course.CourseID);
            Console.WriteLine("員工姓名為 = " + course.CourseName);
            Console.WriteLine("員工年齡為 = " + course.CourseDescription);
        }

    }
}
