using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist_Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Linkedlist L = new Linkedlist();


            L.head = new Node(11);
            Node sec = new Node(26);
            Node thi = new Node(43);
            Node fou = new Node(49);
            ////Node fif = new Node(15);
            ////Node six = new Node(96);
            ////Node sev = new Node(71);
            ////Node eig = new Node(80);
            ////Node nig = new Node(96);
            ////Node ten = new Node(10);
            ////Node ele = new Node(71);
            ////Node twe = new Node(11);

            L.head.next = sec;
            sec.next = thi;
            thi.next = fou;
            //fou.next = fif;
            //fif.next = six;
            //six.next = sev;
            //sev.next = eig;
            //eig.next = nig;
            //nig.next = ten;
            //ten.next = ele;
            //ele.next = twe;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Linkedlist Is :");
            L.print();
            Console.ResetColor();
            Console.WriteLine("\n");

            ////Console.ForegroundColor = ConsoleColor.Green;
            ////Console.WriteLine("Enter The Number To Be Add In First :");
            ////int np = int.Parse(Console.ReadLine());
            ////L.push(np);
            ////Console.WriteLine("Now Linkedlist Is :");
            ////L.print();
            ////Console.ResetColor();
            ////Console.WriteLine("\n");

            //Console.ForegroundColor = ConsoleColor.Red;
            //L.addafter(4, 3);
            //Console.WriteLine("Now Linkedlist Is :");
            //L.print();
            //Console.ResetColor();
            //Console.WriteLine("\n");

            ////Console.ForegroundColor = ConsoleColor.Blue;
            ////Console.WriteLine("Enter The Number To Be Add In End :");
            ////int na = int.Parse(Console.ReadLine());
            ////L.append(na);
            ////Console.WriteLine("Now Linkedlist Is :");
            ////L.print();
            ////Console.ResetColor();
            ////Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter The Number To Be Delete :");
            int nd = int.Parse(Console.ReadLine());
            L.deld(nd);
            Console.WriteLine("Now Linkedlist Is :");
            L.print();
            Console.ResetColor();
            Console.WriteLine("\n");

            ////Console.ForegroundColor = ConsoleColor.Magenta;
            ////Console.WriteLine("Enter The Location To Be Delete :");
            ////int ndp = int.Parse(Console.ReadLine());
            ////L.delp(ndp);
            ////Console.WriteLine("Now Linkedlist Is :");
            ////L.print();
            ////Console.ResetColor();
            ////Console.WriteLine("\n");

            ////Console.ForegroundColor = ConsoleColor.DarkCyan;
            ////Console.WriteLine("The Count Of Linkedlist Is :");
            ////int co = L.countl();
            ////Console.WriteLine(co);
            ////Console.ResetColor();
            ////Console.WriteLine("\n");

            ////Console.ForegroundColor = ConsoleColor.DarkRed;
            ////Console.WriteLine("Enter The Number To Be Count :");
            ////int cn = int.Parse(Console.ReadLine());
            ////int cnn=L.countn(cn);
            ////Console.WriteLine($"The Count Of {cn} Is : ");
            ////Console.WriteLine(cnn);
            ////Console.ResetColor();
            ////Console.WriteLine("\n");


            ////Console.ForegroundColor = ConsoleColor.DarkGray;
            ////Console.WriteLine("Enter The Number To Be Search :");
            ////int sed = int.Parse(Console.ReadLine());
            ////bool s = L.search(sed);
            ////if (s == true)
            ////    Console.WriteLine($"Number {sed} Is Found In Linkedlist ...");
            ////else
            ////    Console.WriteLine($"Number {sed} Isn't Found In Linkedlist !");

            ////Console.ForegroundColor = ConsoleColor.DarkYellow;
            ////Console.WriteLine("Enter The Location To Show The Number Of That Location :");
            ////int nl = int.Parse(Console.ReadLine());
            ////L.nth((nl - 1));
            ////Console.ResetColor();
            ////Console.WriteLine("\n");

            ////Console.ForegroundColor = ConsoleColor.DarkRed;
            ////Console.WriteLine("The Middle Of Linkedlist Is :");
            ////L.mid();
            ////Console.ResetColor();
            ////Console.WriteLine("\n");

            ////Console.ForegroundColor = ConsoleColor.Cyan;
            ////L.sdelcopy();
            ////Console.WriteLine("Sorted Linkedlist Without Duplicate Is :");
            ////L.print();
            ////Console.ResetColor();
            ////Console.WriteLine("\n");

            ////Console.ForegroundColor = ConsoleColor.DarkMagenta;
            ////L.reverse();
            ////Console.WriteLine("The Reverse Of Linkedlist Is :");
            ////L.print();
            ////Console.ResetColor();
            ////Console.WriteLine("\n")

            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine("Enter The Number To Be Reverse By :");
            //int nc = int.Parse(Console.ReadLine());
            //L.head= L.reverse_by_k(L.head, nc);
            ////L.reversebk(nc);
            //Console.WriteLine($"Now Linkedlist After Reverse By {nc} Is :");
            //L.print();
            //Console.ResetColor();
            //Console.WriteLine("\n");

            //Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //L.head = L.delfirst(L.head);
            //Console.WriteLine("Now Linkedlist After Deleting First Node Is :");
            //L.print();
            //Console.ResetColor();
            //Console.WriteLine("\n");

            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //L.delend();
            //Console.WriteLine("Now Linkedlist After Deleting Last Node Is :");
            //L.print();
            //Console.ResetColor();
            //Console.WriteLine("\n");

            //Console.ForegroundColor = ConsoleColor.Blue;
            //L.delcopy();
            //Console.WriteLine("Linkedlist Without Duplicate Is :");
            //L.print();
            //Console.ResetColor();
            //Console.WriteLine("\n");

            Console.ReadKey();

        }
    }
}
