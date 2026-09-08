using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
           LCT01_SyntaxList();
          // LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
           //CT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            Hashtable table = new Hashtable();
            table.Add("Potion", 5);

            foreach (var item in table)
            {
                Debug.Log($"item {item}");
            }
        }

        public void LCT02_SyntaxLinkedList()
        {
            //string[] playerNames = new string[100];

            //->null
            LinkedList<string> linkedList = new LinkedList<string>();

            // [Node 1]->null
            linkedList.AddLast("Node 1");
            // [Node 1]->[Node 2]->null
            linkedList.AddLast("Node 2");
            // [Node-]->[Node 1]->[Node 2]->null
            linkedList.AddLast("Node 0");

            LinkedListNode<string> node1 = linkedList.Find("Node 1");
            Debug.Log(node1.Value);
            Debug.Log(node1.Next.Value);
           // Debug.Log(node1.Next.Next.Value);
           // Debug.Log(node1.Previous.Value);

            var firstNode = linkedList.First;
            var lastNode = linkedList.Last;
            Debug.Log(firstNode.Previous);
            Debug.Log(lastNode.Next);

            // [Node 0]->[Node 1]->[nODE 1.5]->[Node 2]->null
            linkedList.AddAfter(node1, "Node 1.5");
            // [Node 0]->[Node 0.5]->[Node 1]->[nODE 1.5]->[Node 2]->null
            linkedList.AddBefore(node1, "Node 0.5");

            // [Node 0.5]->[Node 1]->[nODE 1.5]->[Node 2]->null
            linkedList.RemoveFirst();
            // [Node 0.5]->[Node 1]->[nODE 1.5]->null
            linkedList.RemoveLast();
            // [Node 0.5]->[Node 1]->null
            linkedList.Remove("Node 1.5");

            //->null
            linkedList.Clear();

            Debug.Log("----");

            foreach (var item in linkedList)
            {
                Debug.Log(item);    
            }
        }

        public void LCT03_SyntaxHashTable()
        {
            throw new System.NotImplementedException();
        }

        public void LCT04_SyntaxDictionary()
        {
            Dictionary<string, int> inv = new Dictionary<string, int>();
            //var inv = new Dictionary<string, int>();

            inv.Add("Potion", 5);
            inv.Add("Banana", 1);
            inv.Add("Apple", 10);

            //Potion: 5
            //Banana: 1
            //Apple: 10

            //Potion: 5
            //Banana: 1
            //Apple: 0
            inv["Apple"] = 0;

            //Potion: 5
            //Banana: 1
            //Apple: 0
            //Apple1: 1
            inv["Apple1"] = 0;

            int potion = inv["Potion"];
            Debug.Log("potion: " + potion);

          //  int apple2 = inv["Potion"];
          //  Debug.Log("apple2: " + apple2);

            bool hasPotion = inv.ContainsKey("Potion");
            Debug.Log("hasPotion: " + hasPotion);

            inv.Remove("Banana");

            foreach (KeyValuePair<string, int> kvp in inv)
            {
                var key = kvp.Key;
                var value = kvp.Value; 
                Debug.Log($"{key} => {value}");
            }
        }

        #endregion
    }
}
