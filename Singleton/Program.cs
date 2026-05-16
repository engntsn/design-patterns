using Singleton;

//Basic Implementation

Logger.Instance.Log("Singletone");

var instance1 = Logger.Instance;
var instance2 = Logger.Instance;

if (instance1 == instance2)
{
    Console.WriteLine("Singleton true");
}


//Thread safe
var instanceThreadSafe = LoggerThreadSafe.Instance;
instanceThreadSafe.Log("Thread safe");
 