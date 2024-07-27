using System.Linq.Expressions;

namespace linq2._1
{
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello, World!");
                var list1 = new List<int> { 1, 2, 3, 4, 5, 6 };
                var list2 = new List<int> { 6, 7, 8, 9, 10, 11 };

                /////////////1.Element Operations////////////
                var firstElement = list1.First();
                var lastElement = list2.Last();
                Console.WriteLine($"First Number in List1 {firstElement}");
                Console.WriteLine($"Last Number in List2 {lastElement}");


                /////////////2.Equality Operations////////////
                var equal = list1.SequenceEqual(list2);
                Console.WriteLine($"List1 and List2 {(equal ? "are" : "are not")} equal");


                /////////////3.Concatenation////////////
                var concatenatedNumbers = list1.Concat(list2).Distinct();
                Console.WriteLine("Concat Number:" + string.Join(", ", concatenatedNumbers));

                /////////////4.Aggregate Operations////////////
                var total = list1.Aggregate(2, (a, b) => a + b);
                int sum = list1.Sum();
                double average = list1.Average();
                int max = list1.Max();
                Console.WriteLine("Aggregate: " + total);
                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Average: " + average);
                Console.WriteLine("Maximum: " + max);


                //////////////5.Sets Operations////////////
                var union = list1.Union(list2);
                var intersect = list1.Intersect(list2);
                var difference1 = list1.Except(list2);
                var difference2 = list2.Except(list1);

                Console.WriteLine("union:" + string.Join(", ", union));
                Console.WriteLine("intersect:" + string.Join(", ", intersect));
                Console.WriteLine("difference(sequence1 - sequence2): " + string.Join(", ", difference1));
                Console.WriteLine("difference(sequence2 - sequence1): " + string.Join(", ", difference2));


                /////////////6.Expression Trees//////////
                ParameterExpression p = Expression.Parameter(typeof(int), "n");
                ConstantExpression c = Expression.Constant(5, typeof(int));
                BinaryExpression b = Expression.GreaterThan(p, c);
                Expression<Func<int, bool>> l = Expression.Lambda<Func<int, bool>>(b, p);

                Func<int, bool> compile = l.Compile();
                Console.WriteLine(compile(3));


                /////////////9.Extension Methods////////////
                var filteredNumbers = list1.Filter(x => x % 2 == 0);
                Console.WriteLine("Filter Even numbers in List1:" + string.Join(", ", filteredNumbers));




            }
        }
    }
