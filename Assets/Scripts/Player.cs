using HighlightPlus;
using StarterAssets;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Camera myCamera;
    [SerializeField] private StarterAssetsInputs input;
    [SerializeField] private GameManagerAndUI message;
    [SerializeField] private int maxDistance = 200; 
    [SerializeField] private LayerMask weaponLayer;

    private HighlightEffect _objEffect;

    private void Update()
    {
        UseInteractive();
    }
    private void UseInteractive()
    {
        if (Physics.Raycast(myCamera.transform.position, myCamera.transform.forward, out var weapon, maxDistance, weaponLayer))
        {
            if (weapon.collider.TryGetComponent<HighlightEffect>(out _objEffect))
                _objEffect.highlighted = true;
            message.Message(true);
            Debug.Log(weapon.collider.gameObject.name);
            if (input.interactive)
            {
                var text =weapon.collider.GetComponent<Piece>().ObjInfo;
                Debug.LogWarning("Press F");
                message.InfoPanelSwitch(true,text);
                Debug.Log(weapon.collider.gameObject.name);
            }
        }
        else
        {
            if (_objEffect)
            {
                _objEffect.highlighted = false;
                _objEffect = null;
            }

            message.InfoPanelSwitch(false,"");
            message.Message(false);
        }
       
    }
}
