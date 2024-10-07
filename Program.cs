
using System.Net; 
  
class Program{ 
      
static void Main(string[] args)   
{ 
      
    // Get the Name of the host   
    string hostName = Dns.GetHostName();  
    Console.WriteLine(hostName);   
      
    // Get the IP from GetHostByName mmethod of the dns class
    string IP = Dns.GetHostEntry(hostName).AddressList[0].ToString();   

    int host1_int = 1721631254;
    int host2_int = 1721647254;
    int host3_int = 1721651254;

    string host1 = host1_int.ToString();
    string host2 = host2_int.ToString();
    string host3 = host3_int.ToString();

    var charsToRemove = new string[] { " ", ".", ":", ";", "/", "%", "@", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
    foreach (var c in charsToRemove)
    {
        IP = IP.Replace(c, string.Empty);
    }

    if((IP == host1) || (IP == host2) || (IP == host3))
    {
        Console.Write("The IP address of the host is correct");
    } else {
        Console.Write("The IP address of the host is incorrect");
    }
}   
}
