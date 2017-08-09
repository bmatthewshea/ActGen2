using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActGen
{
    public sealed class FormToggle
    {
        // Singleton for form calls on console form (Note: Do not manually create a 'new' instance - let this dfo it. ( .Show() or .Hide() )
        // http://csharpindepth.com/Articles/General/Singleton.aspx
        // http://stackoverflow.com/a/3005761/503621 &&  http://yoda.arachsys.com/csharp/singleton.html
        //

        private static readonly object padlock = new object();

        FormToggle()
        {
        }

        // console form
        public static ActGenConsoleForm Console
        {
            get
            {
                lock (padlock)
                if (_console == null)
                {
                    _console = new ActGenConsoleForm();
                }
                return _console;
            }
        }
        private static ActGenConsoleForm _console = null;

        // about form
        //public static ActGenAboutForm About
        //{
        //    get
        //    {
        //        lock (padlock)
        //            if (_about == null)
        //            {
        //                _about = new ActGenAboutForm();
        //            }
        //        return _about;
        //    }
        //}
        //private static ActGenAboutForm _about = null;
        
        //    public static ActGenMainForm MainForm
        //    {
        //        get
        //        {
        //            if (_mainform == null)
        //            {
        //                _mainform = new ActGenMainForm();
        //            }
        //            return _mainform;
        //        }
        //    }
        //    private static ActGenMainForm _mainform;

    }
}
