using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        //variables
        public Node treeBase;
       

        //contructor
        public BinarySearchTree()
        {
            treeBase = null;
            
        }

        //methods
        public void Add(int valueToAdd)
        {
            Node nodeToAdd = new Node(valueToAdd);
            if(treeBase == null)
            {
                treeBase = nodeToAdd;
            }
            else
            {
                Node currentNode = treeBase;
                while(true)
                {
                    //currentNode = currentNode.data;
                    if(valueToAdd <= currentNode.data)
                    {
                        if (currentNode.left != null)
                        {
                            currentNode = currentNode.left;
                        }
                        else
                        {
                            currentNode.left = nodeToAdd;
                            break;
                        }
                    }
                    else 
                    {
                        if(valueToAdd >= currentNode.data)
                        {
                            if(currentNode.right != null)
                            {
                                currentNode = currentNode.right;
                            }
                            else
                            {
                                currentNode.right = nodeToAdd;
                                break;
                            }
                        }
                        //same for the right side
                    }
                }
                
            }
        }
        public bool Search(int numberToSearch)
        {
            Node currentNode = treeBase;
            while (true)
            {
                //currentNode = currentNode.data;
                if (numberToSearch <= currentNode.data)
                {
                    if (currentNode.left != null)
                    {
                        currentNode = currentNode.left;
                    }
                    else
                    {
                        currentNode.left = numberToSearch;
                        break;
                    }
                }
                else
                {
                    if (numberToSearch >= currentNode.data)
                    {
                        if (currentNode.right != null)
                        {
                            = currentNode.right;
                        }
                        else
                        {
                            currentNode.right = nodeToAdd;
                            break;
                        }
                    }
                    //same for the right side
                }



                //Similar currentNode strategy
                //Reuse traversal logic moving down one branch or the other
                //First have to check whether currentnode.data == numbertosearch - return true
                //if you ever find a null branch, instead of adding the item, return false

                return false;
        }
    }
}
