using QueueImplementation;

MyGenericQueue<int> queue = new MyGenericQueue<int>();

//Enqueue kuyruğa eleman ekler.
//Peek kuyruktaki ilk elemanı döndürür.
// Dequeue kuyruktaki ilk elemanı siler ve döndürür.

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);

Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Peek());

Console.ReadKey();