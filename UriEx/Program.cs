using System;
using System.Net;

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
            System.Diagnostics.Process.Start("code.htm");
        }
    }
}
