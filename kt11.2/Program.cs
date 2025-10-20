using System;

public class LinkedList<T> where T : class
{
    private class Node
    {
        public T Data { get; set; }
        public Node Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    private Node head;

    public void Add(T item)
    {
        Node newNode = new Node(item);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public bool Remove(T item)
    {
        if (head == null) return false;

        if (head.Data.Equals(item))
        {
            head = head.Next;
            return true;
        }

        Node current = head;
        while (current.Next != null)
        {
            if (current.Next.Data.Equals(item))
            {
                current.Next = current.Next.Next;
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public bool Contains(T item)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Data.Equals(item))
                return true;
            current = current.Next;
        }
        return false;
    }

    public void Print()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"{Name} ({Age})";
    }
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public override string ToString()
    {
        return $"'{Title}' by {Author}";
    }
}

public class Program
{
    static void Main()
    {
        var stringList = new LinkedList<string>();
        stringList.Add("Hello");
        stringList.Add("World");
        stringList.Add("C#");

        Console.WriteLine("String LinkedList:");
        stringList.Print();
        Console.WriteLine($"Contains 'World': {stringList.Contains("World")}");
        stringList.Remove("World");
        Console.WriteLine("После удаления 'World':");
        stringList.Print();

        var personList = new LinkedList<Person>();
        personList.Add(new Person("Alice", 25));
        personList.Add(new Person("Bob", 30));
        personList.Add(new Person("Charlie", 35));

        Console.WriteLine("\nPerson LinkedList:");
        personList.Print();

        var bookList = new LinkedList<Book>();
        bookList.Add(new Book("1984", "George Orwell"));
        bookList.Add(new Book("Brave New World", "Aldous Huxley"));

        Console.WriteLine("\nBook LinkedList:");
        bookList.Print();
        Console.WriteLine($"Contains '1984': {bookList.Contains(new Book("1984", "George Orwell"))}");
    }
}