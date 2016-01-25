using System;//w ww. jav a  2s .c  om
using System.Net;
using System.Net.Sockets;

public class Example
{
    public static void Main()
    {
        string data = "data";
        WebClient client = new WebClient();

        client.Encoding = System.Text.Encoding.UTF8;

        string reply = client.UploadString("http://www.wp.pl", data);

        Console.WriteLine(reply);

    }
}