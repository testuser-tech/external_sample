#region Codeconflict

using Org.BouncyCastle.Utilities.Encoders;

namespace ExternalSample
{
    class Program
    {
        static void Main(string[] args)
        {

            byte[] testDecode = Base64.Decode("Test");

        }
    }
}

#endregion


//#region External-Version

////In der Verweisauflistung im Projekt auf "itextsharp" gehen und Aliase auf "iText" setzen

//extern alias iText;

//using Org.BouncyCastle.Utilities.Encoders;

//namespace ExternalSample
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            byte[] testDecode = Base64.Decode("Test");

//        }
//    }
//}

//#endregion