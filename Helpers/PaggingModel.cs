using System;

namespace Chuong.Helpers{
    public class PaggingModel
    {
        public int currentpage { get; set; }
        public int countpage { get; set; }
        public Func<int?, string> generateUrl { get; set; }
    }
}