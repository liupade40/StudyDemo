using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFac
{
    /// <summary>
    /// 数据源操作接口
    /// </summary>
    public interface IDataSource
    {
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <returns></returns>
        string GetData();
    }
    /// <summary>
    /// SQLSERVER数据库
    /// </summary>
    class Sqlserver : IDataSource
    {
        public string GetData()
        {
            return "通过SQLSERVER获取数据";
        }
    }
    /// <summary>
    /// ORACLE数据库
    /// </summary>
    public class Oracle : IDataSource
    {
        public string GetData()
        {
            return "通过Oracle获取数据";
        }
    }
}