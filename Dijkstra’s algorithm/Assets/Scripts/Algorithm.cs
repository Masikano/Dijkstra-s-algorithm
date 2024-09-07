using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Algorithm : MonoBehaviour
{
    private List<Node> _nodes = new List<Node>();
    //private List<Edge> _edges = new List<Edge>();
    private int _visitedNodesCount;
    [SerializeField] private List<Button> _nodesBtn = new List<Button>();
    public void FindPath(int id)
    {
        Node currentNode = _nodes[id];
        while(_visitedNodesCount < _nodes.Count)
        {
            Node nextNode = currentNode;
            int minNeighborDistance = 99999;
            for (int i = 0; i < currentNode.GetEdgeCount() - 1; i++)
            {
                
                Edge currentEdge = currentNode.edges[i];
                Node neighbor = currentNode.GetNeighborFromEdge(currentEdge);
                if (neighbor.visited) continue;
                if (currentEdge.weight < minNeighborDistance) nextNode = neighbor;
                if(neighbor.distanceFromStart < currentNode.distanceFromStart + currentEdge.weight)
                {
                    neighbor.distanceFromStart = currentNode.distanceFromStart + currentEdge.weight;
                }
            }
            currentNode.visited = true;
            currentNode = nextNode;
        }
    }
}
