using StackImplementation;

/*
 * 
Stack sondan queue baştan işlem gerçekleştirerek ilerler. 

Örneğin; 1,2,3,4,5 elemanları olan bir arrayde:
stack.Peek()-> 5
queue.Peek()-> 1 değerlerini gösterir.

*/


StackImplementation<int> stack = new StackImplementation<int>();

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);

Console.WriteLine(stack.Peek()); //5
Console.WriteLine(stack.Pop()); //5
Console.WriteLine(stack.Pop()); //4

Console.WriteLine(stack.Peek()); //3
