using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bencode;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test encode function
            Dictionary<string, object> dic = new Dictionary<string, Object>
                            {
                                {"nick", "Create Chen"},
                                {"blog","http://www.cnblogs.com/technology"},
                                {"interests", new List<object> {"coding", "basketball"}}
                            };
            byte[] bytes = BencodeUtility.Encode(dic).ToArray();
            string str = Encoding.ASCII.GetString(bytes);
            Console.WriteLine(str);

            //Test decode function
            object obj = BencodeUtility.Decode(bytes);

            //This is ok in this case
            dic = BencodeUtility.DecodeDictionary(bytes);
        }
    }
}