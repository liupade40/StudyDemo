using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsDate
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dt = DateTime.Now.Date;  //当前时间
            //Console.WriteLine("今天开始时间:{0},今天结束时间:{1}", dt.Date, dt.Date.AddHours(23).AddMinutes(59).AddSeconds(59));
            //DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); //24小时制
            //DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");// 12小时制
            //DateTime startWeek = dt.AddDays(1 - Convert.ToInt32(dt.DayOfWeek.ToString("d")));  //本周周一
            //DateTime endWeek = startWeek.AddDays(7).Date.AddSeconds(-1);  //本周周日
            //Console.WriteLine("本周开始时间:{0},本周结束时间:{1}", startWeek, endWeek);
            //DateTime startMonth = dt.AddDays(1 - dt.Day);  //本月月初
            //DateTime endMonth = startMonth.AddMonths(1).AddDays(-1).Date.AddHours(23).AddMinutes(59).AddSeconds(59);  //本月月末
            //Console.WriteLine("本月开始时间:{0},本月结束时间:{1}", startMonth, endMonth);
            //DateTime startQuarter = dt.AddMonths(0 - (dt.Month - 1) % 3).AddDays(1 - dt.Day);  //本季度初
            //DateTime endQuarter = startQuarter.AddMonths(3).AddDays(-1);  //本季度末
            //DateTime startYear = new DateTime(dt.Year, 1, 1);  //本年年初
            //DateTime endYear = new DateTime(dt.Year, 12, 31);  //本年年末
            //Console.WriteLine("本年开始时间:{0},本年结束时间:{1}", startYear, endYear);
            DateTime dateTime = DateTime.Now;
            var startWeek = dateTime.BeginWeek();
            var endWeek = dateTime.EndWeek();
            var startToday = dateTime.Date;
            var EndToday = dateTime.Date.AddDays(1).AddSeconds(-1);
            var startMonth = dateTime.BeginDate();
            var endMonth = dateTime.EndTime();

            
            Console.WriteLine("本月起始时间{0}，本月结束时间{1}",startMonth,endMonth);
            var startDay = DateHelper.BeginTime(DateTime.Now);
            var endDay = DateTime.Now.Date.AddDays(1).AddSeconds(-1);
            Console.WriteLine("当天开始时间{0}，当天结束时间{1}", startToday, EndToday);
            
            Console.WriteLine("本周开始时间{0}，本周结束时间{1}", startWeek, endWeek);
            Console.ReadKey();
        }
    }
    public static class DateHelper
    {
        /// <summary>
        /// 今天的起始时间，如2017-04-18 16:32：20，获得2017-04-18 00:00：00
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime BeginTime(this DateTime dateTime)
        {
            return dateTime.BeginTime(0);
        }

        /// <summary>
        /// 几（days）天前的的起始时间，如2017-04-18 16:32：20，0天前获得2017-04-18 00:00：00
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="days">几天前：今天为(0)天;7天前为(-6)天</param>
        /// <returns></returns>
        public static DateTime BeginTime(this DateTime dateTime, int days)
        {
            dateTime = dateTime.AddDays(days);
            return dateTime.Date;
        }

        /// <summary>
        /// 月份起始时间，如2017-04-18 16:32：20，获得2017-04-01 00:00：00
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime BeginDate(this DateTime dateTime)
        {
            int year = dateTime.Year;
            int month = dateTime.Month;
            return new DateTime(year, month, 1);
        }
        /// <summary>
        /// 获取当前时间的年初时间
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime BeginYear(this DateTime dateTime)
        {
            int year = dateTime.Year;
            return new DateTime(year, 1, 1);
        }
        /// <summary>
        /// 获取当前时间的月底时间
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime EndTime(this DateTime dateTime)
        {
            return BeginDate(dateTime).AddMonths(1).AddSeconds(-1);
        }
        /// <summary>
        /// 获取当前时间的年底时间
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime EndYear(this DateTime dateTime)
        {
            int year = dateTime.Year;
            return new DateTime(year, 12, 31, 23, 59, 59);
        }
        /// <summary>
        /// 获取本周的开始时间
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime BeginWeek(this DateTime dateTime)
        {
            return dateTime.Date.AddDays(1 - Convert.ToInt32(dateTime.DayOfWeek.ToString("d")));
        }
        /// <summary>
        /// 获取本周的结束时间
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime EndWeek(this DateTime dateTime)
        {
            var date= BeginWeek(dateTime);
            return date.AddDays(7).Date.AddSeconds(-1);
        }
        /// <summary>
        /// 获取起始时间，如2017-04-18 16:32：20，获得2017-04-18 00:00：00；本月：2017-04-01 00:00：00；七天前：2017-04-12 00:00：00
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime BeginTime(this DateTime dateTime, RequestDataDate requestDataDate)
        {
            DateTime getDate = new DateTime();
            switch (requestDataDate)
            {
                case RequestDataDate.Today:
                    getDate = dateTime.BeginTime();
                    break;
                case RequestDataDate.SevenDay:
                    getDate = dateTime.BeginTime(-6);
                    break;
                case RequestDataDate.ThisMonth:
                    getDate = dateTime.BeginDate();
                    break;
            }
            return getDate;
        }
        /// <summary>
        /// 返回最大时间
        /// </summary>
        /// <returns></returns>
        public static DateTime MaxDateTime()
        {
            return new DateTime(9999, 12, 31, 23, 59, 59);
        }
    }
    public enum RequestDataDate
    {
        /// <summary>
        /// 今天
        /// </summary>
       // [Display(Name = "今天")]
        Today = 0,
        /// <summary>
        /// 最近7天
        /// </summary>
      //  [Display(Name = "近七天")]
        SevenDay = 1,
        /// <summary>
        /// 本月
        /// </summary>
        //[Display(Name = "本月")]
        ThisMonth = 2

    }
}
