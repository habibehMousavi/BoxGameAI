using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocketClient_2
{
    class memory
    {
        public List<string> completedSquare = new List<string>();
        public List<string> movementArray = new List<string>();
        public String[] g = new String[5];
        int maIndex;
        int X, Y;

        public int[] lines_hover(int x1, int y1, int x2, int y2)
        {
            int[] array = new int[6];

            //lines hover here

            return array;
        }

        public void set_memory(String x, String y)
        {
            X = int.Parse(x);
            Y = int.Parse(y);
            for (int i = 0; i < (X - 1) * Y + (Y - 1) * X; i++)
            {
                movementArray.Add("0,,,,");
            }
            maIndex = 0;
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < (Y - 1); j++)
                {
                    movementArray[maIndex] = GetListElement(movementArray, maIndex, 0) + "," +//0
                                             i.ToString() + "," +//1
                                             j.ToString() + "," +//2
                                             i.ToString() + "," +//3
                                             (j + 1).ToString();//4
                    maIndex++;
                }
            }
            for (int i = 0; i < Y; i++)
            {
                for (int j = 0; j < (X - 1); j++)
                {
                    movementArray[maIndex] = GetListElement(movementArray, maIndex, 0) + "," +//0
                                             j.ToString() + "," +//1
                                             i.ToString() + "," +//2
                                             (j + 1).ToString() + "," +//3
                                             i.ToString();//4
                    maIndex++;
                }
            }
            maIndex = 0;
        }

        public string GetListElement(List<string> Array, int ArrayIndex, int elementIndex)
        {
            string element = Array[ArrayIndex];
            string[] el = element.Split(',');
            element = el[elementIndex];
            return element;
        }

        public int find_line(string[] a)
        {
            int i = 0;
            bool flag = true;
            for (i = 0; i < movementArray.Count; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (GetListElement(movementArray, i, j) != a[j])
                    {
                        flag = false;
                        if (GetListElement(movementArray, i, 1) == a[3] && GetListElement(movementArray, i, 2) == a[4]
                            &&
                            GetListElement(movementArray, i, 3) == a[1] && GetListElement(movementArray, i, 4) == a[2]) { flag = true; }
                        break;
                    }

                }
                if (flag) break;
            }
            return i;
        }

        public void SetListElement(int type, List<string> Array, int ArrayIndex, int elementIndex, string value)
        {
            string element = Array[ArrayIndex];
            string[] el = element.Split(',');
            el[elementIndex] = value;
            if (type == 1)
                Array[ArrayIndex] = el[0] + "," + el[1] + "," + el[2] + "," + el[3] + "," + el[4] + "," + el[5] + "," + el[6];
        }
    }
}
