using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Progress {

    public string currentTest, username;
    public int maxTestNum, currentTestNum;

    public Progress()
    {
        currentTest = "<test-name>";
        username = "<username>";
        maxTestNum = -1;
        currentTestNum = -1;
    }
}
