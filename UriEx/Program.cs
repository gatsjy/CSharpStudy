using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;

namespace UriEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri info = new Uri("http://www.domain.com:80/info/");
            Uri page = new Uri("http://www.domain.com/info/page.html");

            Console.WriteLine(info.Host);
            Console.WriteLine(info.Port);
            Console.WriteLine(page.Port);

            Console.WriteLine(info.IsBaseOf(page));
            Uri relative = info.MakeRelativeUri(page);
            Console.WriteLine(relative.IsAbsoluteUri);
            Console.WriteLine(relative.ToString());

            // 이책의 예제코드 페이지를 현재폴더의 한 파일로 내려받아서 기본 웹 브라우저로 표시하는 예
            // http://www.albahari.com/nutshell/ 이렇게 귀중한 사이트가 있다!! 발견탱
            WebClient wc = new WebClient { Proxy = null };
            wc.DownloadFile("http://www.albahari.com/nutshell/code.aspx", "code.html");
            //System.Diagnostics.Process.Start("code.htm");

            var client = new HttpClient();
            var task1 = client.GetStringAsync("http://www.linqpad.net");
            var task2 = client.GetStringAsync("http://www.albahari.com");

            // IP Addresses and URIS
            IPAddress a1 = new IPAddress(new byte[] { 101, 102, 103, 104 });
            IPAddress a2 = IPAddress.Parse("101.102.103.104");
            Console.WriteLine(a1.Equals(a2));
            Console.WriteLine(a1.AddressFamily);

            IPAddress a3 = IPAddress.Parse("[3EA0:FFFF:198A:E4A3:4FF2:54fA:41BC:8D31]");
            Console.WriteLine(a3.AddressFamily);

            Console.WriteLine();
            Console.WriteLine("Address with port:");
            IPAddress a = IPAddress.Parse("101.102.103.104");
            IPEndPoint ep = new IPEndPoint(a, 222);
            Console.WriteLine(ep.ToString());

            // Working with HTTP
            // HTTP Hearders
            WebClient wc3 = new WebClient();
            wc3.Headers.Add("CustomerHearder", "JustPlaying/1.0");
            wc3.DownloadString("http://www.oreilly.com");

            foreach (string name in wc.ResponseHeaders.Keys)
                Console.WriteLine(name + "=" + wc3.ResponseHeaders[name]);

            // QueryString
            wc3.QueryString.Add("q", "WebClient");
            wc3.QueryString.Add("hl", "fr");
            wc3.DownloadFile("http://wwww.google.com/search", "results.html");
            OpenHtml("results.html");
        }

        static void OpenHtml(string location)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                Process.Start(new ProcessStartInfo("cmd", $"/c start {location}"));
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                Process.Start("xdg-open, location"); // Desktop Linux
            else throw new Exception("Platform-specific code needed to open URL.");
        }
    }
}
