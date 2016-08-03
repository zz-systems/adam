namespace Adam.Core
    open System
    open System.Net
    open System.Collections.Generic

    type Relationship =
        | None
        | Is
        | Has
    
    type Node() =
        let mutable m_Value = String.Empty
        let m_ParentEdges : List<Edge> = new List<Edge>()

        member this.Value 
            with get () = m_Value
            and set (value) = m_Value <- value

        member this.Parents = m_ParentEdges

        member public this.Neighbors =
           m_ParentEdges 
           |> Seq.map(fun item -> item.Nodes) 
           |> Seq.concat
           |> Seq.filter(fun item -> item <> this)                                    
           |> Seq.distinct

        member this.AreNeighbors(otherNode) =
            this.Neighbors
            |> Seq.exists(fun item -> item = otherNode)           
            

    and Edge() =
        let m_Nodes : List<Node> = new List<Node>()
        let mutable m_Relationship : Relationship = None

        member this.Nodes           = m_Nodes

        member this.Relationship 
            with get () = m_Relationship 
            and set (value) = m_Relationship <- value

        member public this.Add node = 
            m_Nodes.Add node
            node.Parents.Add this                   
                

    and SemanticNetwork() = 
        let m_Edges : List<Edge> = new List<Edge>()

        member public this.Edges = m_Edges

        member public this.Add toAdd =
            m_Edges.Add toAdd

        

