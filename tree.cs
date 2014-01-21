using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocketClient_2
{
    class tree
    {
         Node p = new Node(0);

            Node n1 = new Node(2);

            p.addChild(n1);

            Node n2 = new Node(3);

            p.addChild(n2);

            Console.WriteLine(p.getBest());
        
    }

    class Node
    {
        int value = 0;
        int i = 0;

        Node[] childs = new Node[100];

        public Node(int _val) {
            this.value = _val;
        }

        public void addChild(Node _child)
        {
            this.childs[i++] = (_child);
        }

        public void setValue(int _val){
            this.value = _val;
        }

        public void print(int num)
        {
            Console.WriteLine(childs[num].value);
        }

        public int getBest() 
        {

            int max  = -100;

            for (int x = 0; x < i; x++)
            {
                if (childs[x].value > max)
                {
                    max = childs[x].value;
                }
                

            }

            return max;
            
        }

    }



    }

