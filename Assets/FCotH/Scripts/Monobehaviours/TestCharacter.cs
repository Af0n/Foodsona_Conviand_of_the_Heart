using UnityEngine;

public class TestCharacter : MonoBehaviour
{
    public Character TestChar;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log(TestChar);
            TestChar.Level++;
        }
    }
}
