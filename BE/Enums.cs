using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Enums
    {
        public enum OrderStatus
        { SentEmail, NoAnswer, NotAddressedYet, Closed, Active }
        public enum GuestRequestStatus
        { Active, ClosedOnTheWeb, RequestExpired }

        public enum Type
        { Zimmer, Hotel, Camping }

        public enum Area
        { All, North, South, Center, Jerusalem }

        public enum intrested
        { Necessary, Possible, NoThanks }
    }
}
