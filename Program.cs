// See https://aka.ms/new-console-template for more information


using practiceCSharp;

Thread t1 = new Thread(new ThreadStart(PracticeThreads.func1));
Thread t2 = new Thread(new ThreadStart(PracticeThreads.func2));

PracticeThreads obj = new PracticeThreads();
//Thread t3 = new Thread(new ThreadStart(obj.notThreadSafeFunction));
//t3.Start();

//Thread t4 = new Thread(new ThreadStart(obj.notThreadSafeFunction));
//t4.Start();

//obj.notThreadSafeFunction();

//t1.Start();
//t2.Start();

extension.extensionMain();
Console.ReadLine();



