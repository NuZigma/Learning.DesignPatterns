using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>
namespace Learning.DesignPatterns.Singleton
{

    public class SingletonSample
    {
        public static void Run()
        {
            var some = AppConfig.Instance.CurrentDateTime;

            Console.WriteLine("Singleton ==> Current DateTime ==> " + some.ToString());

            // some = new AppConfig();

            var some2 = AppConfigLazy2.Instance.CurrentDateTime;
        }
    }
    /// <summary>
    /// Singleton class 
    /// </summary>
    public class AppConfig
    {

        private AppConfig()
        {

        }

        /// <summary>
        /// Gets the current date time.
        /// </summary>
        /// <value>
        /// The current date time.
        /// </value>
        public DateTime CurrentDateTime
        {
            get
            {
                return DateTime.Now;
            }
        }
        /// <summary>
        /// The _config
        /// </summary>
        private static volatile AppConfig _config;

        /// <summary>
        /// The pad lock for maintaining a thread lock.
        /// </summary>
        private static readonly Object padLock = new object();

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static AppConfig Instance
        {
            get
            {

                if (_config == null)
                {
                    lock (padLock) // making thread-safe
                    {
                        //{
                        if (_config == null) //second level check to make sure, within the short span, another concurent thread didnt initialize the object. 
                        {
                            _config = new AppConfig();
                        }
                    }
                }
                //}

                return _config;
            }
        }
    }



    /// <summary>
    /// a Simpler version of Singleton class with lazy initialization.
    /// </summary>
    public class AppConfigLazy1
    {
        // static holder for instance, will not get initialized until first use, due to static contructor.
        private static readonly AppConfigLazy1 _instance = new AppConfigLazy1();

        /// <summary>
        /// Prevents a default instance of the <see cref="AppConfigLazy1"/> class from being created.
        /// </summary>
        private AppConfigLazy1()
        {

        }

        /// <summary>
        /// for Lazy Initializes the <see cref="AppConfigLazy1"/> class.
        /// </summary>
        static AppConfigLazy1()
        {

        }


        public static AppConfigLazy1 Instance
        {
            get
            {
                return _instance;
            }
        }



        /// <summary>
        /// Gets the current date time.
        /// </summary>
        /// <value>
        /// The current date time.
        /// </value>
        public DateTime CurrentDateTime
        {
            get
            {
                return DateTime.Now;
            }
        }
    }


    /// <summary>
    /// a Simpler version of Singleton class with lazy initialization.
    /// </summary>
    public class AppConfigLazy2
    {
        // static holder for instance, need to use lambda to construct since constructor private
        private static readonly Lazy<AppConfigLazy2> _instance = new Lazy<AppConfigLazy2>(() => new AppConfigLazy2());

        /// <summary>
        /// Prevents a default instance of the <see cref="AppConfigLazy2"/> class from being created.
        /// </summary>
        private AppConfigLazy2()
        {

        }
        
        public static AppConfigLazy2 Instance
        {
            get
            {
                return _instance.Value;
            }
        }


        /// <summary>
        /// Gets the current date time.
        /// </summary>
        /// <value>
        /// The current date time.
        /// </value>
        public DateTime CurrentDateTime
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
    
}
