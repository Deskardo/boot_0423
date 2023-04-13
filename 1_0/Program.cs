Console.Clear();

// MyList li = new();
// Console.WriteLine(li.Print());

// for (int i = 0; i < 11; i++)
//   li.Create(i + 1);

// Console.WriteLine(li.Print());
// Console.WriteLine(li.Read(5));
// li.Update(0, 100);
// Console.WriteLine(li.Print());
// li.DeleteAt(5);
// Console.WriteLine(li.Print());

// Node n1 = new Node(1);
// n1.Next = new Node(2);
// n1.Next.Next = new Node(3);
// n1.Next.Next.Next = new Node(4);
// n1.Next.Next.Next.Next = new Node(5);
// n1.Next.Next.Next.Next.Next = new Node(6);

// Node current = n1;


// Print(n1);

NodeList nl = new NodeList();
for (int i = 0; i < 11; i++)
  nl.Create(i + 1);

Console.WriteLine(nl.Print());