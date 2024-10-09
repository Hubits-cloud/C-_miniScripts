
using System.Net; 
  
class Program{ 
      
static void Main()   
{ 
      
    // Get the Name of the host   
    string hostName = Dns.GetHostName();    
      
    // Get the IP from GetHostByName mmethod of the dns class
    string IP = Dns.GetHostEntry(hostName).AddressList[0].ToString();   

    // Asks the user for the calculated IP
    Console.WriteLine("Please type your calc IP address");
    string calc_IP_clean = Console.ReadLine();
    double calc_IP = Convert.ToDouble(calc_IP_clean);

    // Convert the ip addresses to strings
    string calc_IP_str = calc_IP.ToString();

    string IP_final = IP;

    // Remove unwanted characters
    var charsToRemove = new string[] { " ", ".", ":", ";", "/", "%", "@", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
    foreach (var c in charsToRemove)
    {
        IP_final = IP_final.Replace(c, string.Empty);
        calc_IP_str = calc_IP_str.Replace(c, string.Empty);
    }

    // Check if the ip's match
    if(IP == calc_IP_str)
    {
        Console.WriteLine("The IP address of the host is correct");
    } else {
        Console.WriteLine("The IP address of the host is incorrect");
    }

    Console.WriteLine("Your calculated IP address: " + calc_IP_clean);
    Console.WriteLine("Your actual IP: " + IP);
    Console.WriteLine("Your Host: " + hostName); 
}   
}
