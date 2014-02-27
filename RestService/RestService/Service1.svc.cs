using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "add2/{a}/{b}")]
        public data Add(string a, string b)
        {
            double c;
            int a1 = Convert.ToInt32(a);
            int b1 = Convert.ToInt32(b);
            c = a1 + b1;
            return new data()
            {
                Operation = "Addition",
                Result = Convert.ToDouble(c)
            };
        }
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "sub2/{a}/{b}")]
        public data Sub(string a, string b)
        {
            double c;
            int a1 = Convert.ToInt32(a);
            int b1 = Convert.ToInt32(b);
            c = a1 - b1;
            return new data()
            {
                Operation = "Subtraction",
                Result = Convert.ToDouble(c)
            };
        }
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "mul2/{a}/{b}")]
        public data Mul(string a, string b)
        {
            double c;
            int a1 = Convert.ToInt32(a);
            int b1 = Convert.ToInt32(b);
            c = a1 * b1;
            return new data()
            {
                Operation = "Multiplication",
                Result = Convert.ToDouble(c)
            };
        }
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "div2/{a}/{b}")]
        public data Div(string a, string b)
        {
            double c;
            int a1 = Convert.ToInt32(a);
            int b1 = Convert.ToInt32(b);
            c = a1 / b1;
            return new data()
            {
                Operation = "Division",
                Result = Convert.ToDouble(c)
            };
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }

    public class data
    {
        public string Operation { get; set; }
        public double Result { get; set; }
    }
}
