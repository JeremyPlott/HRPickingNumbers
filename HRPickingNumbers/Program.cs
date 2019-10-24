using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HRPickingNumbers {
    class Program {
        static void Main(string[] args) {

            List<int> a = new List<int>() { 4, 97, 5, 97, 97, 4, 97, 4, 97, 97, 97, 97, 4, 4, 5, 5, 97, 5, 97, 99, 4, 97, 5, 97, 
                97, 97, 5, 5, 97, 4, 5, 97, 97, 5, 97, 4, 97, 5, 4, 4, 97, 5, 5, 5, 4, 97, 97, 4, 97, 5, 4, 4, 97, 97, 97, 5, 5, 
                97, 4, 97, 97, 5, 4, 97, 97, 4, 97, 97, 97, 5, 4, 4, 97, 4, 4, 97, 5, 97, 97, 97, 97, 4, 97, 5, 97, 5, 4, 97, 4, 
                5, 97, 97, 5, 97, 5, 97, 5, 97, 97, 97 };

            SortedDictionary<int, int> d = new SortedDictionary<int, int>();

            foreach(int i in a) {
                if(!d.ContainsKey(i)) {
                    d.Add(i, 1);
                } else {
                    d[i]++;
                }
            }

            var largest = d.Values.Max();

            foreach(var key in d.Keys) {                
                var count = 0;
                if(d.ContainsKey(key + 1)) {
                    count = d[key] + d[key + 1];
                }
                if(largest < count) {
                    largest = count;
                }
            }
            Console.WriteLine(largest);
        }
    }
}
