using UnityEngine;

[CreateAssetMenu(fileName = "Data",menuName = "CreateShowpiece")]
public class Showpiece : ScriptableObject
{
    [SerializeField] private string nameObj;
    [SerializeField] private string info;

    public string NameObj => nameObj;
    public string Info => info;
}
