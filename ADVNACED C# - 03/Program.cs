#region


//List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];

//PrintGrades(grades);
//Console.WriteLine();
//Console.WriteLine();

//Console.WriteLine($"number of items : {grades.Count}");
//Console.WriteLine();
//Console.WriteLine();

//grades.Sort();

//Console.WriteLine($"Sorted List ascendingly");


//Console.WriteLine();
//Console.WriteLine();

//Console.WriteLine("First grade after 90");
//Console.WriteLine(grades.Find(grade => grade > 90));
//Console.WriteLine();
//Console.WriteLine();

//Console.WriteLine("All grades below 70");

//var failingGrades = grades.FindAll(grades => grades < 70);
//PrintGrades(failingGrades);
//Console.WriteLine();
//Console.WriteLine();

//Console.WriteLine("Remove all grades below 75");
//grades.RemoveAll(grades => grades < 75);
//PrintGrades(grades);
//Console.WriteLine();
//Console.WriteLine();

//Console.WriteLine("Check if there are grades = 100");
//Console.WriteLine(grades.Contains(100) ? "Yes there grades = 100" : "There is no grades = 100");
//Console.WriteLine();
//Console.WriteLine();

//List<String> gradesValue = grades.ConvertAll(grade => $"Grade: {grade}");
//PrintGrades(gradesValue);


#endregion


#region

//var players = new SortedList<int, string>
//{
//    { 500, "Ahmed" },
//    { 200, "Sara" },
//    { 800, "Ali" },
//    { 350, "Mona" }
//};
//PrintPlayer(players);
//Console.WriteLine();
//Console.WriteLine();

//Console.WriteLine($"First Key {players.Keys[0]}");
//Console.WriteLine($"First Value {players.Values[0]}");
//Console.WriteLine();
//Console.WriteLine();


//Console.WriteLine("Check if there is 500");
//Console.WriteLine(players.ContainsKey(500));
//Console.WriteLine();
//Console.WriteLine();

//Console.WriteLine("Safely check if there 999");
//players.TryGetValue(999, out string val);
//Console.WriteLine(val ?? "There are no matching result");
//Console.WriteLine();
//Console.WriteLine();

//players.Remove(200);
//PrintPlayer(players);
#endregion


#region

//var contacts = new Dictionary<string, string>()
//        {
//            { "Adham", "01012345678" },
//            { "Ahmed", "01198765432" },
//            { "Sara", "01234567890" },
//            { "Mona", "01555555555" }
//        };

//contacts["Omar"] = "01201201201";

//try
//{
//    contacts.Add("Adham", "01012345678");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex);
//}
//Console.WriteLine();
//Console.WriteLine();


//Console.WriteLine(contacts.TryAdd("Adham", "01012345678"));
//Console.WriteLine();
//Console.WriteLine();

//bool hasKey = contacts.ContainsKey("Ali"); 
//Console.WriteLine(hasKey);
//Console.WriteLine();
//Console.WriteLine();

//var val = contacts.GetValueOrDefault("X", "Not found");
//Console.WriteLine(val);
//Console.WriteLine();
//Console.WriteLine();

//Console.WriteLine(string.Join(" - ", contacts.Keys));
//Console.WriteLine(string.Join(" - ", contacts.Values));
//Console.WriteLine();
//Console.WriteLine();


#endregion


#region

//using static System.Net.Mime.MediaTypeNames;

//var emailValidator = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
//{
//    "ahmed@test.com",
//    "AHMED@test.com",
//    "sara@test.com",
//    "Sara@Test.Com"
//};
//Console.WriteLine(emailValidator.Count);
//// it will print 2 because hashset only stores unique values
//// and doesnt matter which case it is because we used to IgnoreCase comparer

//Console.WriteLine();
//Console.WriteLine();


//var setA = new HashSet<int>() { 
//1, 2, 3, 4, 5
//};
//var setB = new HashSet<int>() { 
//4, 5, 6, 7, 8
//};

//Console.WriteLine("Set A");
//PrintSet(setA);
//Console.WriteLine();

//Console.WriteLine("union");
//var unionSet = new HashSet<int>(setA);
//unionSet.UnionWith(setB);
//PrintSet(unionSet);
//Console.WriteLine();


//Console.WriteLine("intersection");
//var intersectedSet =  new HashSet<int>(setA);
//intersectedSet.IntersectWith(setB);
//PrintSet(intersectedSet);
//Console.WriteLine();


//Console.WriteLine("except");
//var exceptSet =  new HashSet<int>(setA);
//exceptSet.ExceptWith(setB);
//PrintSet(exceptSet);
//Console.WriteLine();

//Console.WriteLine(new HashSet<int>() { 1, 2 }.IsSubsetOf(setA));


#endregion


#region



//var documents = new Queue<string>();

//documents.Enqueue("Report.pdf");
//documents.Enqueue("Invoice.pdf");
//documents.Enqueue("Letter.docx");
//documents.Enqueue("Resume.pdf");
//documents.Enqueue("Photo.jpg");

//Console.WriteLine("Queue contents:");
//foreach (var doc in documents)
//{
//    Console.WriteLine(doc);
//}
//Console.WriteLine();
//Console.WriteLine();

//Console.WriteLine($"Total documents: {documents.Count}");
//Console.WriteLine();
//Console.WriteLine();

//Console.WriteLine($"Next to print: {documents.Peek()}");
//Console.WriteLine();
//Console.WriteLine();

//Console.WriteLine("Processing queue:");
//while (documents.Count > 0)
//{
//    string current = documents.Dequeue();
//    Console.WriteLine($"Printing: {current}");
//}
//Console.WriteLine();
//Console.WriteLine();

//Console.WriteLine("Trying Try Dequeue on empty queue:");
//bool success = documents.TryDequeue(out string result);

//if (!success)  Console.WriteLine("Queue is empty, nothing to dequeue.");

//else  Console.WriteLine($"Dequeued: {result}");



#endregion


#region


var history = new Stack<string>();

history.Push("google.com");
history.Push("youtube.com");
history.Push("facebook.com");
history.Push("instagram.com");
history.Push("reddit.com");

Console.WriteLine($"Current page: {history.Peek()}");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Going back:");
for (int i = 0; i < 3; i++)
{
    string leftPage = history.Pop();
    Console.WriteLine($"Leaving: {leftPage}");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"Current page now: {history.Peek()}");

while (history.Count > 0)
{
    history.Pop();
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Trying TryPop on empty stack:");
bool success = history.TryPop(out string page);

if (!success)
{
    Console.WriteLine("Stack is empty nothing to pop");
}
else
{
    Console.WriteLine($"Popped: {page}");
}


#endregion

static void PrintGrades<T>(List<T> grades )
{ 
    foreach (var grade in grades) Console.WriteLine(grade);
}

static void PrintPlayer(SortedList<int, string> players)
{
    foreach (var player in players) Console.WriteLine(player);
}
static void PrintSet<T>(HashSet<T> set)
{
    foreach (var item in set) Console.WriteLine(item);
}