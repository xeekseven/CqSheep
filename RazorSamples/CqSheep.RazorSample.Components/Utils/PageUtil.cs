using System;
using System.Collections.Generic;
using System.Text;

namespace CqSheep.RazorSample.Components.Utils
{
    public class PageUtil
    {
        public static Dictionary<string,string> GetPathDic(string pathKey,string routePath)
        {
            var pathDic = new Dictionary<string, string>();
            pathDic.Add(pathKey, routePath);
            return pathDic;
        }
    }
}
