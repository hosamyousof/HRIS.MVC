using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace HRIS.Test
{
    [TestClass]
    public class UnitTest1
    {
        private static Dictionary<string, string> GetParams(string uri)
        {
            var matches = Regex.Matches(uri, @"[\?&](([^&=]+)=([^&=#]*))", RegexOptions.Compiled);
            return matches.Cast<Match>().ToDictionary(
                m => Uri.UnescapeDataString(m.Groups[2].Value),
                m => Uri.UnescapeDataString(m.Groups[3].Value)
            );
        }

        [TestMethod]
        public void TestMethod1()
        {

            string url = "staging.connectwisedev.com/?setOption=%7BcontentType%3A%27application%2Fx-www-form-urlencoded%27%2Cmethod%3A%27post%27%2CtimeOut%3A60000%7D";

            var list = GetParams(url);

            Debug.WriteLine(list["setOption"]);
            string json = list["setOption"];
            Debug.WriteLine(json);
            Dictionary<string, string> values = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            Debug.WriteLine(values["contentType"]);

            //CryptLib _crypt = new CryptLib();
            //string hashShaKey = "HRIS_KEY1";
            //string key = CryptLib.getHashSha256(hashShaKey, 31);
            //string iv = CryptLib.GenerateRandomIV(16);
            //string password = "P@ssw0rd";
            //string encrypted = _crypt.encrypt(password, key, iv);
            //string decrypted = _crypt.decrypt(encrypted, key, iv);
            //Debug.WriteLine("Vector: " + iv);
            //Debug.WriteLine("Encrypted: " + encrypted);
            //Debug.WriteLine("Key: " + key);
            //Debug.WriteLine("Decrypted: " + decrypted);
        }


        [TestMethod]
        public void TestGenerateLicense()
        {
            string companyName = "Jhon Maynard Bolante";


        }
    }
}