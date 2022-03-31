using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  static Model.Modle;
using static ModelView.ModelView;

namespace View
{
    internal class View
    {
        public class ChangesEventArgs : EventArgs
        {

            public string Message;

            public ChangesEventArgs(string Message)
            {
                this.Message = Message;
            }
        }
        public event EventHandler<ChangesEventArgs> listenToChanges;
        public void TheFunctionCall(String Message)
        {
            Console.WriteLine($"Recive a new message {Message}");

            if (listenToChanges != null)
            {
                listenToChanges(this, new ChangesEventArgs(Message));
            }
        }
        public class InValidDataExpction : Exception
        {
            public InValidDataExpction(string Massage)
                : base(Massage+"\n") { }
        }

        public class DuplicateIdExpction : Exception
        {
            public DuplicateIdExpction(string Massage):base(Massage + "\n") { }
        }
        public class NotFoundExpction : Exception {
            public NotFoundExpction( string Massage) : base(Massage + "\n "){ }


        }


    }

}