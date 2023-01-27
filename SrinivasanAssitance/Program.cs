// See https://aka.ms/new-console-template for more information
using SrinivasanAssitance;

Console.WriteLine("Hello, World!");

/*
StackMember<double> stackMember = new StackMember<double>();

stackMember.push(2.3); stackMember.push(9.1); stackMember.push(5.4);
stackMember.push(8.2); stackMember.push(11.5); stackMember.push(4.1);

//Console.WriteLine(stackMember.top);
stackMember.Value();

stackMember.pop(); stackMember.pop();
stackMember.Value();
*/

IntStackMember stk = new IntStackMember();
stk.push(33); stk.push(44); stk.push(90); stk.push(43); stk.push(10);
stk.push(55); stk.push(89); stk.push(21); stk.push(56); stk.push(11);

stk.Value();