using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//open to be freely walked upon or blocked by a wall - freely accessible to any other object
public enum NodeType {
    Open = 0,
    Blocked = 1
}

//data container
public class Node {
    public NodeType nodetype = NodeType.Open; //freely walkable by default
    //identify each node by an index, use a 2D array to keep track of all the nodes - the node class has properties to store x and y index
    public int xIndex = -1; //track position in 2D array initialised to an invalid value as a flag(when index has not been fit)
    public int yIndex = -1;

    //store coordinates that directly correspond to x and y
    public Vector3 position; //keep track of the node's position, no transform data available from monobehaviour

    //keep track of nodes connected to this node, use list as connection is based on proximity
    public List<Node> neighbours = new List<Node>();
    //special node to reference the best path through the maze to get to this node, each node keeps track of this best path to get to it

    public Node previous = null; 
    //constructor to set up the basics - save parameters to corresponding variables
    public Node(int xIndex, int yIndex, NodeType nodeType) {
        this.xIndex = xIndex;
        this.yIndex = yIndex;
        this.nodetype = nodeType;
    }

    //clear previous pathfinding attempts - rebuild/recalculate the path 
    public void Reset() {
        previous = null;
    }
}
