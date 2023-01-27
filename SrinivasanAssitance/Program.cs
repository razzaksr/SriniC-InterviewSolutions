// See https://aka.ms/new-console-template for more information
using SrinivasanAssitance;

Console.WriteLine("Hello, World!");
ListClass list = new ListClass();
list.InsAtStart("Razak Mohamed"); list.InsAtStart("Rasheedha"); list.InsAtStart("Rajiya");
//list.ViewByForward(list.head);
list.InsAtLast("Sabarinathan"); list.InsAtLast("Vedhanjana");
//list.ViewByForward(list.head);
list.InsAtSpecific(list.head.Next.Next.Next, "Zealous");
list.ViewByForward(list.head);
//list.DelAtStart();
//list.DelAtSpecific(list.head.Next.Next.Next.Next);
//list.DelAtSpecific(list.head);
//list.DelAtSpecific(list.head.Next.Next.Next.Next.Next);
//list.ViewByForward(list.head);

//Console.WriteLine(list.Count(list.head.Next.Next));

//Console.WriteLine(list.Search("Razak Mohamed", list.head));
//Console.WriteLine(list.Search("Razak", list.head));
//Console.WriteLine(list.Search("Razak Mohamed", list.head.Next.Next));
//Console.WriteLine(list.Search("Razak Mohamed", list.head.Next.Next.Next));

//list.Modify("Razak Mohamed","Razak Mohamed S",list.head);
//list.Modify("Razak Mohamed", "Razak Mohamed S", list.head.Next.Next.Next.Next);
list.Modify("Razak", "Razak Mohamed S", list.head);
list.ViewByForward(list.head);