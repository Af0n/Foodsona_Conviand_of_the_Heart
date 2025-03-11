/*
This is simply a test script
*/

using UnityEngine;

public class TestCharacter : MonoBehaviour
{
    public Character TestChar;

    private void Start() {
        TestChar.SetLevel(1);
        Debug.Log(TestChar.Stats);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log(TestChar);
            TestChar.SetLevel(TestChar.Level+1);
        }
    }
}
