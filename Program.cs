using System;
using System.Collections.Generic;
using Algorithms.DS;
using Algorithms.Problems;
using Algorithms.Sorting;
using Algorithms.Search;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {          
            //ExecQueueDs(inputArray);
            //ExecCircularQueue(inputArray);
            //ExecMergeSort(inputArray);
            //ExecSelectionSort(inputArray);
            //ExecBubbleSort(inputArray);            
            //ExecMeetingRangeProblem();
            //ExecReverseString();            
            //ExecReverseWords();
            //ExecMergeArrays();
            //ExecFirstComeFirstServe();
            //ExecSameMovieLength();
            //ExecFindRepeatNums();
            //ExecBinarySearch();        
            //ExecPalindromeProblem();
            //ExecWordCollectionProblem();
            //ExecSortUsingHashProblem();
            //ExecStockPricesProblem();
            //ExecFindHighestProblem();
            //ExecProductsOfAllIntsProblem();
            //ExecShuffleArrayProblem();
            //ExecFindStartingPoint();
            //ExecRepeatingNumbersProblem();
            //ExecFastMeetingRangeProblem();
            //ExecPreOrderTreeTraverser();
            //ExecInOrderTreeTraverser();
            //ExecPostOrderTreeTraverser();
            ExecBfsAlgorithm();
            ExecDfsAlgorithm();
        }

        private static void ExecDfsAlgorithm()
        {            
            var output = DepathFirstSearch.GetDFSLevelOrder(TreeTestCase1());
            Console.WriteLine("Output:");
            foreach(var item in output)
            {
                Console.WriteLine(item);
            }

            output = DepathFirstSearch.GetDFSLevelOrder(TreeTestCase2());
            Console.WriteLine("Output:");
            foreach(var item in output)
            {
                Console.WriteLine(item);
            }
        }

        private static void ExecBfsAlgorithm()
        {            
            var output = BreadthFirstSearch.GetBFSLevelOrder(TreeTestCase1());
            Console.WriteLine("Output:");
            foreach(var item in output)
            {
                var str = string.Empty;
                foreach(var val in item)
                {
                  str += string.IsNullOrEmpty(str)?$"{val}": $",{val}";
                }
                Console.WriteLine(str);
            }

            output = BreadthFirstSearch.GetBFSLevelOrder(TreeTestCase2());
            Console.WriteLine("Output:");
            foreach(var item in output)
            {
                var str = string.Empty;
                foreach(var val in item)
                {
                  str += string.IsNullOrEmpty(str)?$"{val}": $",{val}";
                }
                Console.WriteLine(str);
            }
        }

        private static BinaryTreeNode TreeTestCase1()
        {
            Console.WriteLine("Tree traversal using BFS algoritm:");
            Console.WriteLine("Input: [3,9,20,null,null,15,7]");
            var leftLeaf = new BinaryTreeNode(15);            
            var rightLeaf = new BinaryTreeNode(7);
            var lev1Left = new BinaryTreeNode(9);
            var lev1Right = new BinaryTreeNode(20,leftLeaf,rightLeaf);           
            var rootNode = new BinaryTreeNode(3,lev1Left,lev1Right);
            return rootNode;
        }

        private static BinaryTreeNode TreeTestCase2()
        {
            Console.WriteLine("Tree traversal using BFS algoritm:");
            Console.WriteLine("Input:[1,2,3,4,null,null,5]");
            var leftLeaf = new BinaryTreeNode(5);            
            var rightLeaf = new BinaryTreeNode(4);
            var lev1Left = new BinaryTreeNode(2,leftLeaf,null);
            var lev1Right = new BinaryTreeNode(3,null,rightLeaf);           
            var rootNode = new BinaryTreeNode(1,lev1Left,lev1Right);
            return rootNode;
        }

        private static void ExecPreOrderTreeTraverser()
        {
            var treeTraverser = new TreeTraverser();
            var output = treeTraverser.GetPreOrderList(GetTreeTestCase1("Pre","1,2,3"));
            PrintArray(output.ToArray(),"Tree traversal in order output:");
            treeTraverser = new TreeTraverser();
            output = treeTraverser.GetPreOrderList(GetTreeTestCase2());
            PrintArray(output.ToArray(),"Tree traversal in order output:");
        }


        private static void ExecInOrderTreeTraverser()
        {
            var treeTraverser = new TreeTraverser();
            var output = treeTraverser.GetInOrderList(GetTreeTestCase1("In","1,3,2"));
            PrintArray(output.ToArray(),"Tree traversal in order output:");         
        }


        private static void ExecPostOrderTreeTraverser()
        {
            var treeTraverser = new TreeTraverser();
            var output = treeTraverser.GetPostOrderList(GetTreeTestCase1("Post","3,2,1"));
            PrintArray(output.ToArray(),"Tree traversal in order output:");
        }

        private static BinaryTreeNode GetTreeTestCase1(string order, string expected)
        {
            Console.WriteLine($"{order} order tree traversal input:{expected}");
            //var leftLeafNode = new BinaryTreeNode(2);            
            var rLeftLeafNode = new BinaryTreeNode(3);
            //var rRightLeafNode = new BinaryTreeNode(5);
            var rightNode = new BinaryTreeNode(2,rLeftLeafNode,null);
            var rootNode = new BinaryTreeNode(1,null,rightNode);
            return rootNode;
        }

        private static BinaryTreeNode GetTreeTestCase2()
        {
            Console.WriteLine($"Pre order tree traversal input:3,1,2");
            Console.WriteLine("Expected result: 3, 1, 2");
            var rootNode = new BinaryTreeNode(3,new BinaryTreeNode(1),new BinaryTreeNode(2));
            return rootNode;
        }
        private static void ExecFastMeetingRangeProblem()
        {
            var meetings = new List<Meeting>();
            //Test case 1:
            meetings.Add(new Meeting(0,1));
            meetings.Add(new Meeting(3,5));
            meetings.Add(new Meeting(4,8));
            meetings.Add(new Meeting(10,12));
            meetings.Add(new Meeting(9,10));
            Console.WriteLine("Meetings Input:");
            foreach(var meeting in meetings)
            {
                Console.WriteLine($"({meeting.StartTime},{meeting.EndTime})");
            }
            var result = MergeMeetingsByMergeSort.MergeRanges(meetings);
            Console.WriteLine("Meetings Output:");
            foreach(var meeting in result)
            {
                Console.WriteLine($"({meeting.StartTime},{meeting.EndTime})");
            }
            meetings.Clear();
            //Test case 2:           
            meetings.Add(new Meeting(1,3));
            meetings.Add(new Meeting(4,8));
            Console.WriteLine("Meetings Input:");
            foreach(var meeting in meetings)
            {
                Console.WriteLine($"({meeting.StartTime},{meeting.EndTime})");
            }
            result = MergeMeetingsByMergeSort.MergeRanges(meetings);
            Console.WriteLine("Meetings Output:");
            foreach(var meeting in result)
            {
                Console.WriteLine($"({meeting.StartTime},{meeting.EndTime})");
            }
            //Test case 3:
            meetings.Clear();            
            meetings.Add(new Meeting(1,4));
            meetings.Add(new Meeting(2,5));
            meetings.Add(new Meeting(5,8));
            Console.WriteLine("Meetings Input:");
            foreach(var meeting in meetings)
            {
                Console.WriteLine($"({meeting.StartTime},{meeting.EndTime})");
            }
            result = MergeMeetingsByMergeSort.MergeRanges(meetings);
            Console.WriteLine("Meetings Output:");
            foreach(var meeting in result)
            {
                Console.WriteLine($"({meeting.StartTime},{meeting.EndTime})");
            }
        }

        private static void ExecRepeatingNumbersProblem()
        {
            var numbers = new int[] { 4, 1, 4, 8, 3, 2, 7, 6, 5 };
            PrintArray(numbers,"Find repeating numbers");
            var expected = 4;
            var actual = RepeatingNumbers.FindRepeat(numbers);
            Console.WriteLine($"Actual Result:{actual} Expected Result:{expected}");

            numbers = new int[] { 1,1 };
            PrintArray(numbers,"Find repeating numbers");
            expected = 1;
            actual = RepeatingNumbers.FindRepeat(numbers);
            Console.WriteLine($"Actual Result:{actual} Expected Result:{expected}");

            numbers = new int[] {  1, 2, 3, 2 };
            PrintArray(numbers,"Find repeating numbers");
            expected = 2;
            actual = RepeatingNumbers.FindRepeat(numbers);
            Console.WriteLine($"Actual Result:{actual} Expected Result:{expected}");

            numbers = new int[] { 1, 2, 5, 5, 5, 5 };
            PrintArray(numbers,"Find repeating numbers");
            expected = 5;
            actual = RepeatingNumbers.FindRepeat(numbers);
            Console.WriteLine($"Actual Result:{actual} Expected Result:{expected}");
        }

        private static void ExecFindStartingPoint()
        {
            var arr = new string[] { "grape", "orange", "plum", "radish","apple" };
            PrintArray(arr,"CircularSortedArray Input:");
            Console.WriteLine($"Expected:{4} Actual:{CircularSortedList.FindRotationPoint(arr)}");
            arr = new string[] {"cape", "cake"};
             PrintArray(arr,"CircularSortedArray Input:");
            Console.WriteLine($"Expected:{1} Actual:{CircularSortedList.FindRotationPoint(arr)}");
            arr = new string[] {"ptolemaic", "retrograde", "supplant", "undulate", "xenoepist",
            "asymptote", "babka", "banoffee", "engender", "karpatka", "othellolagkage"};
            PrintArray(arr,"CircularSortedArray Input:");
            Console.WriteLine($"Expected:{5} Actual:{CircularSortedList.FindRotationPoint(arr)}");    
        }

        private static void ExecShuffleArrayProblem()
        {
            var initial = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var shuffled = (int[]) initial.Clone();
            ShuffleArray.Shuffle(shuffled);
            Console.WriteLine($"Initial array: [{string.Join(", ", initial)}]");
            Console.WriteLine($"Shuffled array: [{string.Join(", ", shuffled)}]");

            var shuffleusingKnuth = (int[]) initial.Clone();
            ShuffleArray.Shuffle(shuffleusingKnuth);
            Console.WriteLine($"Initial array: [{string.Join(", ", initial)}]");
            Console.WriteLine($"Shuffled array: [{string.Join(", ", shuffleusingKnuth)}]");
        }

        private static void ExecProductsOfAllIntsProblem()
        {
           var output = ProductsOfAllInts.GetProductsOfAllIntsExceptAtIndex(new int[] {  1, 2, 3  });
           Console.WriteLine($"Exec Products Of All Ints Problem result:{123} Expected:{ 632 }");
           PrintArray(output,"Actual output" );
           /*Console.WriteLine($"Stock price profit result:{ProductsOfAllInts.GetProductsOfAllIntsExceptAtIndex(new int[] {  6, 1, 3, 5, 7, 8, 2 })} expected:{336}");
           Console.WriteLine($"Stock price profit result:{ProductsOfAllInts.GetProductsOfAllIntsExceptAtIndex(new int[] {  -5, 4, 8, 2, 3 })} expected:{96}");
           Console.WriteLine($"Stock price profit result:{ProductsOfAllInts.GetProductsOfAllIntsExceptAtIndex(new int[] {  -10, 1, 3, 2, -10})} expected:{300}");
           Console.WriteLine($"Stock price profit result:{ProductsOfAllInts.GetProductsOfAllIntsExceptAtIndex(new int[] { -5, -1, -3, -2})} expected:{-6}");*/
        }

        private static void ExecFindHighestProblem()
        {
           Console.WriteLine($"Find Highest result:{FindHighest.HighestProductOf3(new int[] { 1, 2, 3, 4 })} expected:{24}");
           Console.WriteLine($"Find Highest result:{FindHighest.HighestProductOf3(new int[] {  6, 1, 3, 5, 7, 8, 2 })} expected:{336}");
           Console.WriteLine($"Find Highest result:{FindHighest.HighestProductOf3(new int[] {  -5, 4, 8, 2, 3 })} expected:{96}");
           Console.WriteLine($"Find Highest result:{FindHighest.HighestProductOf3(new int[] {  -10, 1, 3, 2, -10})} expected:{300}");
           Console.WriteLine($"Find Highest result:{FindHighest.HighestProductOf3(new int[] { -5, -1, -3, -2})} expected:{-6}");
        }

        private static void ExecStockPricesProblem()
        {
           Console.WriteLine($"Stock price profit result:{StockPrices.GetMaxProfit(new int[] { 1, 5, 3, 2 })} expected:{4}");
           Console.WriteLine($"Stock price profit result:{StockPrices.GetMaxProfit(new int[] { 7, 2, 8, 9 })} expected:{7}");
           Console.WriteLine($"Stock price profit result:{StockPrices.GetMaxProfit(new int[] {  1, 6, 7, 9  })} expected:{8}");
           Console.WriteLine($"Stock price profit result:{StockPrices.GetMaxProfit(new int[] {  9, 7, 4, 1 })} expected:{-2}");
           Console.WriteLine($"Stock price profit result:{StockPrices.GetMaxProfit(new int[] { 1, 1, 1, 1})} expected:{0}");
           Console.WriteLine($"Stock price profit result:{StockPrices.GetMaxProfit(new int[] { 5 })} expected:{0}");
        }

        private static void ExecSortUsingHashProblem()
        {
             var scores = new int[] { 37, 89, 41, 65, 91, 53 };
             DisplayResultForSort(scores, SortUsingHash.Sort(scores, 100));
        }

        private static void DisplayResultForSort(int[] input, int[] sorted)
        {
            Console.WriteLine("Input:");
            foreach(var item in input)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sorted Result:");
            foreach(var item in sorted)
            {
                Console.WriteLine(item);
            }
        }

        private static void ExecWordCollectionProblem()
        {
            var text = "I like cake";
            ValidatewordCount(text);
            text = "Chocolate cake for dinner and pound cake for dessert";
            ValidatewordCount(text);
            text = "Strawberry short cake? Yum!";
            ValidatewordCount(text);
            text = "Dessert - mille-feuille cake";
            ValidatewordCount(text);
            text = "Mmm...mmm...decisions...decisions";
            ValidatewordCount(text);
            text = "Allie's Bakery: Sasha's Cakes";
            ValidatewordCount(text);          
        }

        private static void ValidatewordCount(string text)
        {
            var actual = new WordCollection(text);
            Console.WriteLine($"Words list extracted from this text:{text}");
            foreach(var kvp in actual.WordsToCounts)
            {
                Console.WriteLine($"{kvp.Key}:{kvp.Value}");
            }
        }

        private static void ExecPalindromeProblem()
        {
            var testcase = "dad";
            Console.WriteLine($"Palindrome Test:{testcase} Result-{Palindrome.IsPalindrome(testcase.ToCharArray())}");
            testcase = "cicic";
            Console.WriteLine($"Palindrome Test:{testcase} Result-{Palindrome.IsPalindrome(testcase.ToCharArray())}");
            testcase = "sweet";
            Console.WriteLine($"Palindrome Test:{testcase} Result-{Palindrome.IsPalindrome(testcase.ToCharArray())}");
            testcase = "mom";
            Console.WriteLine($"Palindrome Test:{testcase} Result-{Palindrome.IsPalindrome(testcase.ToCharArray())}");
              testcase = "level";
            Console.WriteLine($"Palindrome Test:{testcase} Result-{Palindrome.IsPalindrome(testcase.ToCharArray())}");
              testcase = "Racecar";
            Console.WriteLine($"Palindrome Test:{testcase} Result-{Palindrome.IsPalindrome(testcase.ToCharArray())}");
              testcase = "MADAM";
            Console.WriteLine($"Palindrome on any combination Test:{testcase} Result-{Palindrome.IsPalindromeOnAnyCombination(testcase.ToCharArray())}");
              testcase = "noon";
            Console.WriteLine($"Palindrome on any combination Test:{testcase} Result-{Palindrome.IsPalindromeOnAnyCombination(testcase.ToCharArray())}");
                testcase = "radar";
            Console.WriteLine($"Palindrome on any combination Test:{testcase} Result-{Palindrome.IsPalindromeOnAnyCombination(testcase.ToCharArray())}");
                testcase = "hi";
            Console.WriteLine($"Palindrome on any combination Test:{testcase} Result-{Palindrome.IsPalindromeOnAnyCombination(testcase.ToCharArray())}");
                testcase = "";
            Console.WriteLine($"Palindrome on any combination Test:{testcase} Result-{Palindrome.IsPalindromeOnAnyCombination(testcase.ToCharArray())}");
                testcase = "ivicc";
            Console.WriteLine($"Palindrome on any combination Test:{testcase} Result-{Palindrome.IsPalindromeOnAnyCombination(testcase.ToCharArray())}");
                 testcase = "babaccabab";
            Console.WriteLine($"Palindrome on any combination Test:{testcase} Result-{Palindrome.IsPalindrome(testcase.ToCharArray())}");
            Console.WriteLine($"Palindrome on any combination Test:{testcase} Result-{Palindrome.IsPalindromeOnAnyCombination(testcase.ToCharArray())}");
        }

        private static void ExecBinarySearch()
        {
            var numbers = new int[] { 1,2,3,77,99,1093 };
            //Binary search test cases           
            Console.WriteLine($"Expected Resut {false} Actual Result {BinarySearch.Search(numbers,5000)}");
            Console.WriteLine($"Expected Resut {true} Actual Result {BinarySearch.Search(numbers,1093)}");
            Console.WriteLine($"Expected Resut {true} Actual Result {BinarySearch.Search(numbers,2)}");
            Console.WriteLine($"Expected Resut {false} Actual Result {BinarySearch.Search(numbers,0)}");

            numbers = new int[] {0, 2, 4, 6, 8, 10, 12, 14, 16};
            UnitTestForBinarySearch(numbers,9, false) ;
            UnitTestForBinarySearch(new int[] {0, 2, 4, 6, 8, 10, 12, 14, 16, 18 },9, false) ;
            UnitTestForBinarySearch(numbers,0, true) ;
            UnitTestForBinarySearch(numbers,16, true) ;
            UnitTestForBinarySearch(numbers,8, true) ;
            AllTrueCases();
            AllFalseCases();
        }

        private static void AllTrueCases() 
        {
            int[] sorted = new int[] { 0, 2, 4, 6, 8, 10, 12, 14, 16 }; 
            for (int i = 0; i < sorted.Length; i++) 
            {
                UnitTestForBinarySearch(sorted, sorted[i],true);
            }
        }
 
        private static void AllFalseCases() 
        {
            int[] sorted = new int[] { 0, 2, 4, 6, 8, 10, 12, 14, 16 }; 
            UnitTestForBinarySearch(sorted,sorted[0] - 1, false);    
            for (int i = 0; i < sorted.Length; i++) 
            {
                UnitTestForBinarySearch(sorted, sorted[i] + 1,false);
            }   
        }

        private static void UnitTestForBinarySearch(int[] numbers,int searchParm, bool expectedResult)
        {
            Console.WriteLine($"Expected Resut {expectedResult} Actual Result {BinarySearch.RecursiveSearch(numbers,-1,numbers.Length,searchParm)}");
        }

        private static void ExecFindRepeatNums()
        {
            var numbers = new int[] { 1, 5, 9, 7, 2, 6, 3, 8, 2, 4 };
           
            var actual = RepeatingNumber.FindRepeat(numbers);
            Console.WriteLine($"Expected Resut {2} Actual Result {actual}");
        }

        private static void ExecSameMovieLength()
        {
            //Test case 1:
            var result = SameMovieLength.CanTwoMoviesFillFlight(new int[] { 3, 8, 3 }, 6);
            //Test case 2:
            //var result =  SameMovieLength.CanTwoMoviesFillFlight(new int[] { 1, 2, 3, 4, 5, 6 }, 7);
            Console.WriteLine($"Expected result:{true} Actual Result:{result}");
        }        

        private static void ExecFirstComeFirstServe()
        {
            //Test case 1
            var takeOutOrders = new int[] { 1, 4, 5 };
            var dineInOrders = new int[] { 2, 3, 6 };
            var servedOrders = new int[] { 1, 2, 3, 4, 5, 6 };
            //Test case 2
            //var takeOutOrders = new int[] { 1, 5 };
            //var dineInOrders = new int[] { 2, 3, 6 };
            //var servedOrders = new int[] { 1, 2, 3, 5, 6, 8 };
            var result =  FirstComeFirstServe.IsFirstComeFirstServed(takeOutOrders, dineInOrders, servedOrders);
            Console.WriteLine($"Expected result:{true} Actual Result:{result}");
        }

        private static void ExecMergeArrays()
        {
            //test case1
            //var input = new int[] {1,28, 69,222};
            //var input2 = new int[] {3,18, 70,92, 600};
            //test case2
            //var input = new int[] { 2, 4, 6 };
            //var input2 = new int[] { 1, 3, 7 };
            //test case3
            var input = new int[] { 2, 4, 6, 8 };
            var input2 = new int[] { 1, 7 };
            //Console.WriteLine(new string(input));
            var m = MergeSortedArrays.MergeArrays(input, input2);
            foreach(var item in m)
            {
                Console.WriteLine(item);                        
            }
        }     

        private static void ExecReverseWords()
        {
            var input = "lol and OMG".ToCharArray();
            Console.WriteLine(new string(input));
            ReverseWords.Reverse(input);
            Console.WriteLine(new string(input));                        
        }

        private static void ExecReverseString()
        {
            var expected = "EDCBA".ToCharArray();
            var actual = "ABCDE".ToCharArray();
            Console.WriteLine(actual);
            ReverseString.Reverse(actual);
            Console.WriteLine(actual);           
        }

        private static void ExecMeetingRangeProblem()
        {
            var meetings = new List<Meeting>();
            //Test case 1:
            /*meetings.Add(new Meeting(0,1));
            meetings.Add(new Meeting(3,5));
            meetings.Add(new Meeting(4,8));
            meetings.Add(new Meeting(10,12));
            meetings.Add(new Meeting(9,10));*/
            //Test case 2:
            /*meetings.Add(new Meeting(1,3));
            meetings.Add(new Meeting(4,8));*/
            //Test case 3:
            meetings.Add(new Meeting(1,4));
            meetings.Add(new Meeting(2,5));
            meetings.Add(new Meeting(5,8));
            var result = MeetingRange.MergeRanges(meetings);
            foreach(var meeting in result)
            {
                Console.WriteLine($"({meeting.StartTime},{meeting.EndTime})");
            }
        }

        private static void ExecSelectionSort(int[] inputArray)
        {
            Console.WriteLine("<--Selection Sort Algorithm-->");
            var sortArray = new  SelectionSort();
            PrintArray(inputArray, "Input:");
            int[] output = sortArray.Sort(inputArray);
            PrintArray(output,"Result:");
        }

        private static void ExecBubbleSort(int[] inputArray)
        {
            Console.WriteLine("<--Bubble Sort Algorithm-->");
            var sortArray = new  SelectionSort();
            PrintArray(inputArray, "Input:");
            int[] output = sortArray.Sort(inputArray);
            PrintArray(output,"Result:");
        }

        private static void ExecMergeSort(int[] inputArray)
        {
            Console.WriteLine("<--Merge Sort Algorithm-->");
            PrintArray(inputArray, "MergeSort Input:");
            int[] output = MergeSort.Sort(inputArray);
            PrintArray(output,"MergeSort Result:");
        }


        private static void ExecCircularQueue(int[] inputArray)
        {
            Console.WriteLine("<--Circular Queue data structure-->");
            CircularQueue circularQueue = new CircularQueue(3); // set the size to be 3
            Console.WriteLine($"EnQueue 1:{circularQueue.enQueue(1)}");  // return true
            Console.WriteLine($"EnQueue 2:{circularQueue.enQueue(2)}");  // return true
            Console.WriteLine($"EnQueue 3:{circularQueue.enQueue(3)}");  // return true
            Console.WriteLine($"EnQueue 4:{circularQueue.enQueue(4)}");  // return false, the queue is full
            Console.WriteLine($"Rear:{circularQueue.Rear()}");  // return 3
            Console.WriteLine($"Is Queue full:{circularQueue.isFull()}");  // return true
            Console.WriteLine($"DeQueue:{circularQueue.deQueue()}");  // return true
            Console.WriteLine($"EnQueue 4:{circularQueue.enQueue(4)}");  // return true
            Console.WriteLine($"Rear:{circularQueue.Rear()}");  // return 4
            Console.WriteLine("Current Queue status:");
            PrintArray(circularQueue.GetAll(), "Current Queue Status:");
            Console.WriteLine($"DeQueue:{circularQueue.deQueue()}");  // return true
            Console.WriteLine($"EnQueue 5:{circularQueue.enQueue(5)}");  // return true
            PrintArray(circularQueue.GetAll(), "Current Queue Status:");
        }

        private static void PrintArray(string[] arr, string heder)
        {
            Console.WriteLine(heder);
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        private static void PrintArray(int[] arr, string heder)
        {
            Console.WriteLine(heder);
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        
        private static void ExecQueueDs(int[] inputArray)
        {
             var queueDs = new QueueDs();
             foreach(var item in inputArray)
             {
                 //Add item in array - Q first in
                 queueDs.enQueue(item);
             }             
             Console.WriteLine($"Item deQueued:{queueDs.deQueue()}");
             int addNewItem = 100;
             Console.WriteLine($"Item enQueued:{addNewItem.ToString()}");
             queueDs.enQueue(100);
             var itemInQ = queueDs.GetAllItems();

             //Print the output
             foreach(var item in itemInQ)
             {                 
                Console.WriteLine(item);
             }    

             //queueDs.enQueue()
        }
    }
}
