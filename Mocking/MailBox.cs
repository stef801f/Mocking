using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking
{
    public class MailBox
    {

        public MailBox()
        {
            NumReceivedMessages = 0;

        }

            public int NumReceivedMessages { get; set; }

        public List<Mail> _mails = new List<Mail>();
        

        public string GetLatestMessageText() {
            return _mails.Last().Content;
        }

        public void Add(Mail m)  {
            NumReceivedMessages++;
            _mails.Add(m);

        } 
        
    

}
}
