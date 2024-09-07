using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public int index;
    public int distanceFromStart;
    public bool visited;
    public List<Edge> edges = new List<Edge>();
    public Node GetNeighborFromEdge(Edge edge)
    {
        Node neighborID;
        if (edge.nodeEnd.index != index)
        {
            neighborID = edge.nodeEnd;
        }
        else
        {
            neighborID = edge.nodeStart;
        }
        
        
        
        return neighborID;
    }
    public int GetEdgeCount()
    {
        return edges.Count;
    }
}
