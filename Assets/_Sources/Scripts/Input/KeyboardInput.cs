using UnityEngine;

public class KeyboardInput
{
    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";

    public Vector3 Movement => new Vector3(Input.GetAxisRaw(Horizontal), 0, Input.GetAxisRaw(Vertical));
    public bool IsBusterActivated => Input.GetKeyDown(KeyCode.F);
}
