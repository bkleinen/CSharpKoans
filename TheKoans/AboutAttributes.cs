#define TRACE_ON

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace TheKoans
{
    [Author("Barbara Kleinen")]
    public class AboutAttributes
    {
        public static void Run() {
            MyMovie myMovie = new MyMovie();
            Trace.Msg("tracing is on");
        }
    }
    [Serializable]
    // http://msdn.microsoft.com/en-US/library/48zeb25s%28v=VS.80%29.aspx
    public class MyMovie
    {
        private string _movieName = "";
        [NonSerialized()]
        private string _internalName = "";
        public string MovieName
        {
            get { return _movieName; }
            set { _movieName = value; }

        }   // Propery für den Film-Namen
        
        public string InternalName
        {
            get { return _internalName; }
            set { _internalName = value; }

        }
    }
    //System.Runtime.InteropServices
    [ComVisible(true)]
    public class MyMovie2
    {

    }

    [ComVisible(false)]
    public class InternalMovie
    {
        private string _movieName = "";

        public string MovieName
        {
            get { return _movieName; }
            set { _movieName = value; }
        }   // Propery für den Film-Namen
    }
    // System.Diagnostics
    public class Trace
{
    [Conditional("TRACE_ON")]
    public static void Msg(string msg)
    {
        Console.WriteLine(msg);
    }
}
    /*
     * Writing Custom Attributes 
     * http://msdn.microsoft.com/en-us/library/84c42s56%28v=vs.71%29.aspx
     */
    [System.AttributeUsage( System.AttributeTargets.Class |
                       System.AttributeTargets.Struct)]
public class Author : System.Attribute
{
    private string name;
    
    public Author(string name)
    {
        this.name = name;
    }
}

}
