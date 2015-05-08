using AopAlliance.Intercept;
using KuasCore.Models;
using System;
using System.Diagnostics;

namespace KuasCore.Interceptors
{
    class UpdateCourseNameInterceptor : IMethodInterceptor
    {

        public object Invoke(IMethodInvocation invocation)
        {
            Console.WriteLine("DebogLogInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);
            Debug.Print("DebogLogInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);

            object result = invocation.Proceed();

            if (result is Course)
            {
                Course s = (Course)result;
                s.CourseName = s.CourseName + "asdfa";
                result = s;
              
            }
            Console.WriteLine("DebogLogInterceptor 攔截到一個方法呼叫 = [{0}]", result);
            Debug.Print("DebogLogInterceptor 攔截到一個方法呼叫 = [{0}]", result);
         
            return result;
        }
    }
}
