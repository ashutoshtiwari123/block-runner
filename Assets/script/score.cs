using UnityEngine;
using UnityEngine.UI;

public class score: MonoBehaviour
{
    public Text Scoretext;
    public Text finalscore;
     
    int myscore = 0;

    void Update()
    {
        Scoretext.text = myscore.ToString();   
        finalscore.text = "Score:"+myscore.ToString();
    }
    public void addscore(int score)
    {
        myscore = myscore + score;
    }
}
