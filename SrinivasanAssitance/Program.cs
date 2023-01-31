// See https://aka.ms/new-console-template for more information
using SrinivasanAssitance;

Console.WriteLine("Hello, World!");

// execution of only altered functions add, modify, View, count and search

ListClass lst = new ListClass();
lst.AddToList();
lst.ViewByForward();
lst.Modify("Razak Mohamed S","Razak Mohamed Shahul Hameed");
lst.ViewByForward();
Console.WriteLine(lst.Count());
Console.WriteLine(lst.Search("Razak Mohamed S"));
Console.WriteLine(lst.Search("Sabarinathan S"));