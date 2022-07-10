//A PROBLEM:
//iterate over set of integer numbers and find all the triplets summing which the result will be zero.

using Algorithm_DataStruct_Lib;
using AlgorithmAndDataStructure;
using System.Diagnostics;

//var ints = In.ReadInts("16Kints.txt").ToArray();
//var watch = new Stopwatch();//stopwatch is not best way of measuring performance but it is enough for our case.
////performance measuring often called benchmarking
//watch.Start();
//var triplets = ThreeSum.Count(ints);
//watch.Stop();
//Console.WriteLine($"The number of \"zero-sum\" triplets:{triplets}");
//Console.WriteLine($"time taken:{watch.Elapsed:g}");//run on release mode to be more speed.
//Output;//for 1kints.txt file
//The number of "zero-sum" triplets:70
//time taken:0:00:00.1883229 --> 188 miliseconds
//**
////for 4kints.txt file
//The number of "zero-sum" triplets:4039
//time taken:0:00:11.5934775 -->> 11 seconds
//**
//for 8kints.txt file
//The number of "zero-sum" triplets:32074
//time taken:0:01:35.0889139 --> 1 minute 36 seconds

//The question is ; How much time is my program take as a function of the input size.
//we need to depict large numbers on a graph, and in such cases we tend to use the so-called log-log plots
//Most commonly used are two and ten.
//it is enough to use two as the log base in our case.
//we need to put input size on the x axis and running time on the y axis.
//we need to calculate slope of a line
//We can write this equation;
//lg(T(n)) = 3lgn + lga where a constant
//So;
//lg(T(n)) = lga*N^3
//devide all side to lg and result ;
//T(n) =aN^3
//****
//for 8kints.txt file
//1 minute 36 seconds is 96 seconds;
//so;
//T(8000) = 96
//96 = a*8000^3 
//a = 96/8000^3
// a = 18.7*10^-11
//So we can calculate 16kints.txt file like this;
//T(1600) = 18.17*10^-11*1600^-11 
//and result for 16kints.txt file approximately ~766

//so we run for 16KInt.txt file and result is;
//The number of "zero-sum" triplets:256097438
//time taken:0:11:24.6755423
//and 766 seconds are 12.76666666666667 minute so more or less it is what it is.
//Console.ReadLine();
//////////
///////***********************************************************
///
//one way linear linked list
//Node node = new Node(10);
//Node node2 = new Node(20);
//node.next = node2;

//Console.WriteLine($"node data -> {node.data}");
//Console.WriteLine($"node next data -> {node.next.data}");
//Console.WriteLine($"node2 data -> {node2.data}");
//Console.WriteLine($"node2 next data -> {node2.next?.data ??0}");

//one way linear linked list done with class;

LinkedListClass linkedListClass = new LinkedListClass();

linkedListClass.AddToLast(10);
linkedListClass.AddToLast(20);
linkedListClass.AddToLast(30);

//Console.WriteLine($" head  data -> {linkedListClass.head?.data}");
//Console.WriteLine($" head next data -> {linkedListClass.head?.next?.data}");
//Console.WriteLine($" head next next data -> {linkedListClass.head?.next?.next?.data}");


linkedListClass.AddToFront(101);
linkedListClass.AddToFront(202);
linkedListClass.AddToFront(303);

//Console.WriteLine($" head  data -> {linkedListClass.head?.data}");
//Console.WriteLine($" head next data -> {linkedListClass.head?.next?.data}");
//Console.WriteLine($" head next next data -> {linkedListClass.head?.next?.next?.data}");

//we can just print members by PrintListMembers method instead of above codes;
linkedListClass.PrintListMembers();





Console.ReadLine();