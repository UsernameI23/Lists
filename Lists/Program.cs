

List<string> members = new List<string> { "Liam", "Macy", "Luke", "Henry" };
string[] memberArr = new string[] { "Greg", "Patrick", "Connor", "Dylan" };
members.AddRange(memberArr);
members.Sort();
foreach (string m in members)
    Console.WriteLine(m);
members.Reverse();
foreach (string m in members)
    Console.WriteLine(m);
