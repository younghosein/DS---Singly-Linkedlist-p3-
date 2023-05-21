using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist_Example_2
{
    class Linkedlist
    {
        public Node head;

        public void print()
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(n.data + " . ");
                n = n.next;
            }
        }

        public void push(int nd)
        {
            Node nn = new Node(nd);
            nn.next = head;
            head = nn;
        }

        public void addafter(int nd, int N)
        {
            Node n = head;
            for(int i = 1; i < N; i++)
            {
                if (n == null)
                {
                    Console.WriteLine("Zor nazan vojod ndre in khonehe");
                    return;
                }
                n = n.next;
            }
            Node nn = new Node(nd);
            nn.next = n.next;
            n.next = nn;
        }

        public void append(int nd)
        {
            if (head == null)
            {
                head = new Node(nd);
                return;
            }

            Node last = head;

            while (last.next != null)
            {
                last = last.next;
            }
            Node nn = new Node(nd);

            last.next = nn;

            nn.next = null;
        }
        public void delfirst()
        {
            if (head == null)
            {
                Console.WriteLine("Khalie ddsh");
                return;
            }

            head = head.next;
        }
        public void delend()
        {
            if (head == null)
            {
                return;
            }

            Node n = head;

            while (n.next.next != null)
            {
                n = n.next;
            }
            n.next = null;
        }
        public void deld(int dd)
        {
            Node dn = head;
            Node bn = null;

            if (dn != null && dn.data == dd)
            {
                head = dn.next;
                return;
            }
            while (dn != null && dn.data != dd)
            {
                bn = dn;
                dn = dn.next;
            }
            if (dn == null)
            {
                Console.WriteLine("Adade bikhodi nde,babato isgan kn");
                return;
            }
            bn.next = dn.next;
        }
        public void delp(int p)
        {
            if (head == null)
                return;

            Node n = head;

            if (p == 0)
            {
                head = n.next;
                return;
            }

            for (int i = 0; n != null && i < p - 1; i++)
                n = n.next;

            if (n == null || n.next == null)
                return;

            Node next = n.next.next;

            n.next = next;
        }
        public int countl()
        {
            Node t = head;
            int c = 0;
            while (t != null)
            {
                c++;
                t = t.next;
            }
            return c;
        }
        public int countn(int d)
        {
            Node n = head;
            int c = 0;
            while (n != null)
            {
                if (n.data == d)
                {
                    c++;
                }
                n = n.next;
            }
            return c;
        }

        public bool search(int sd)
        {
            Node n = head;
            while (n != null)
            {
                if (n.data == sd)
                    return true;
                n = n.next;
            }
            return false;
        }
        public void nth(int loc)
        {
            Node n = head;
            int c = 0;
            while (n != null)
            {
                if (c == loc)
                {
                    Console.WriteLine($"Element At Index {(loc + 1)} is {n.data}");
                }
                c++;
                n = n.next;
            }
        }

        public void mid()
        {
            Node m = head;
            Node l = head;

            if (head != null)
            {
                while (l != null && l.next != null)
                {
                    l = l.next.next;
                    m = m.next;
                }
                Console.WriteLine(m.data);
            }
        }

        public void sdelcopy()
        {
            Node n = head;

            Node nxn;

            if (head == null)
                return;

            while (n.next != null)
            {
                if (n.data == n.next.data)
                {
                    nxn = n.next.next;
                    n.next = null;
                    n.next = nxn;
                }
                else
                    n = n.next;
            }
        }
        public void reverse()
        {
            Node bn = null;
            Node n = head;
            Node last = null;

            while (n != null)
            {
                last = n.next;
                n.next = bn;
                bn = n;
                n = last;
            }

            head = bn;
        }
        public Node connect(Node h1, Node h2)
        {
            Node i;
            if (h1 == null)
                return h2;
            else
            {
                if (h2 != null)
                {
                    for (i = h1; i.next != null; i = i.next) ;
                    i.next = h2;
                }
                return h1;
            }
        }
        public Node reverse_by_k(Node h, int k)
        {
            Node t1 = h;
            Node t2 = null, t3 = null;
            int c = 0;

            while (t1 != null && c < k)
            {
                t2 = t1.next;
                t1.next = t3;
                t3 = t1;
                t1 = t2;
                c++;
            }

            if (h != null)
            {
                h.next = t1;
            }

            c = 0;
            while (c < k - 1 && t1 != null)
            {
                t1 = t1.next;
                c++;
            }

            if (t1 != null)
            {
                t1.next = reverse_by_k(t1.next, k);
            }

            return t3;
        }
        //Tabe Ostad
        public void reversebk(int k)
        {
            int count = 0;
            Node p, q, t, last, prevlast = null;
            p = null;
            q = head;
            t = q.next;
            last = q;
            bool ch = false;
            while (t != null)
            {
                count = 0;
                p = null;
                prevlast = last;
                last = q;
                while (count < k && t != null)
                {
                    count++;
                    q.next = p;
                    p = q;
                    q = t;
                    t = t.next;
                }
                if (ch == false)
                {
                    head = p;
                    ch = true;
                }
                if (prevlast != last)
                    prevlast.next = p;
            }
            if (prevlast == last && k != count)
                head = q;
            else
                prevlast.next = q;
            if (count == k)
                q.next = null;
            else
                q.next = p;
        }
        public void delcopy()
        {
            Node t1 = null;
            Node t2 = null;
            Node t3 = null;
            t1 = head;

            while (t1 != null && t1.next != null)
            {
                t2 = t1;

                while (t2.next != null)
                {
                    if (t1.data == t2.next.data)
                    {
                        t3 = t2.next;
                        t2.next = t2.next.next;
                    }
                    else
                    {
                        t2 = t2.next;
                    }

                    t1 = t1.next;
                }
            }

        }
    }
}