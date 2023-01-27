// See https://aka.ms/new-console-template for more information
using SrinivasanAssitance;

Console.WriteLine("Hello, World!");

BSTClass tree = new BSTClass();
tree.Place(45); tree.Place(50); tree.Place(4); tree.Place(34); tree.Place(12);
tree.Place(6); tree.Place(7); tree.Place(21); tree.Place(11); tree.Place(89);

//tree.PreOrder(tree.root);
tree.InOrder();

//tree.Search(50);
//tree.Search(45);

//tree.Update(4, 77);
//tree.InOrder();

tree.Delete(11);
tree.InOrder();
tree.Delete(50);
tree.InOrder();
tree.Delete(4);
tree.InOrder();