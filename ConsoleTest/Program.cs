/*Console.WriteLine("ThrId={0}", Thread.CurrentThread.ManagedThreadId);

var update_time = true;
var locker = new object();

var flag_a = new AutoResetEvent(false);
var flag_m = new ManualResetEvent(false);*/

/*var time_thread = new Thread(Time);
time_thread.IsBackground = true;
time_thread.Start();
//time_thread.Priority = ThreadPriority.BelowNormal; */

/*Console.WriteLine(">>>");
var str = Console.ReadLine();
Console.WriteLine(str);*/

//update_time = false;

/*var th1 = new Thread(() => Counter(10));
var th2 = new Thread(() => Counter(100, 10));
var th3 = new Thread(() => Counter(5, 200));
th1.Start();
th2.Start();
th3.Start();*/

/*Console.ReadLine();
flag_a.Set();
Console.ReadLine();
flag_a.Set();
Console.ReadLine();
flag_a.Set();*/

/*time_thread.Join();

if (!time_thread.Join(25))
{
    time_thread.Interrupt();
}*/


/*var t1 = new Task(() => Counter(100, 10));
t1.Start();
var t2 = Task.Run(() => Counter(10, 100));

await t1;
await t2;*/

var tc1 = Task.Run(() => Compute(5));
var result1 = await tc1;

var tc2 = ComputeAsync(7);
var result2 = await tc2;


Console.ReadLine();


void Time()
{
    Console.WriteLine("ThrId={0}", Thread.CurrentThread.ManagedThreadId);
    while (true)
    {
        Thread.Sleep(100);
        Console.Title = DateTime.Now.ToString();
    }
}

void Counter(int max, int Timeout = 100)
{
    var id = Thread.CurrentThread.ManagedThreadId;

    for (int i = 0; i < max; i++)
    {
        Thread.Sleep(Timeout);
        Console.WriteLine("ThId{0} - {1}", id, i);
    }
}

static int Compute(int x)
{
    Console.WriteLine("ThrId={0}", Thread.CurrentThread.ManagedThreadId);
    Thread.Sleep(100);
    Console.WriteLine("ThrId={0}", Thread.CurrentThread.ManagedThreadId);
    return x * x;
}

static async Task<int> ComputeAsync(int x)
{
    Console.WriteLine("ThrId={0}", Thread.CurrentThread.ManagedThreadId);
    await Task.Delay(1000);
    Console.WriteLine("ThrId={0}", Thread.CurrentThread.ManagedThreadId);
    return x * x;
}