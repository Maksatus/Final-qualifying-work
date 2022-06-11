using UnityEngine;

public class Piece : MonoBehaviour
{
    [SerializeField] private Showpiece obj;
    
    public string ObjName => obj.name;
    public string ObjInfo => obj.Info;
}
