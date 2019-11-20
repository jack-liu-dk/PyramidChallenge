using System.Collections.Generic;

namespace UnitTestPyramidMaxSum.TestData
{
    public class PyramidData
    {

        public static List<string> TestData3Lines()
        {
            var data = new List<string>
            {
                  "1"
                , "8 10"
                , "11 7 9"
            };
            return data;
        }
        
        public static List<string> TestData4Lines()
        {
            var data = new List<string>
            {
                  "1"
                , "8 9"
                , "1 5 9"
                , "4 5 2 3"
            };
            return data;
        }

        public static List<string> TestData5Lines()
        {
            var data = new List<string>
            {
                  "1"
                , "8 9"
                , "1 5 9"
                , "4 5 2 3"
                , "9 5 3 5 7"
            };
            return data;
        }
    }
}
