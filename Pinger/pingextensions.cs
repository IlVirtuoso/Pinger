using System;
using System.Net.NetworkInformation;
using System.Threading;

namespace pingerextensions {
    public class pingerextensions // : Pinger //activate while in use with main class
    {

    }

    public class extensivestatistic // : Statistical //use when in use with main class 
    {
        
        
    }

    public class Node <T>{
        internal T elem;
        internal Node<T> next;

        public Node(T elem, Node<T> next){
            this.elem = elem;
            this.next = next;
        }
    }

    
}