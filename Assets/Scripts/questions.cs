using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questions : MonoBehaviour
{
    private string[] qs=new string[6];
    private string[] answer = new string[6];
    private static int current=0;
    private Text ques;
    private Text ans;
    private Button next;
    private Button show;
    private Button prev;
    // Start is called before the first frame update
    void Start()
    {
        qs[0] = "Q1) If gaseous HCL is cooled to about -84C, it condenses to a liquid that does not conduct electricity. Why is it so? Do you expect ions be present in pure liquid HCl?";
        qs[1] = "Q2) How would the electrical conductivity of a solution of Ba(OH)2 change as a solution of H2SO4 is added slowly to it?";
        qs[2] = "Q3) Is your saliva acidic or basic before and after having a meal?";
        qs[3] = "Q4) Using vinegar and ammonia solutions determine which substances in the list given below can be used as acid base indicators./nBeet juice, plum juice, turmeric solution.";
        qs[4] = "Q5) Why does the application of vinegar remove the scales from a kettle?";
        qs[5] = "Q6) Ammonia (NH3) does not contain any hydroxide group yet it produces hydroxide ions in water. Explain.";

        answer[0] = "In liquefied HCl ,the H and Cl atoms have a covalent bond. Therefore there are no +ve and –ve ions to conduct electricity. It is when HCl mixes with water, forming hydrochloric acid, it dissociates into H+ and Cl- ions . That is why hydrochloric acid is conductive and pure liquid HCL is not.";
        answer[1] = "A neutralization reaction will occur which will yield barium sulfate and water. Barium sulfate is extremely insoluble in water and virtually all of it will precipitate and quickly sink to the bottom of its container since it’s also very dense. Now that we have water in the solution(H+ and OH- ions) the conductivity of the solution will increase by a great factor as water is a better conductor than both acids or bases.";
        answer[2] = "Before taking a meal, the saliva is slightly basic (PH=7.4) but after a meal it becomes acidic (PH=5.8).";
        answer[3] = " Beet juice and turmeric solutions can be used as acid base indicators. Beet juice was red in vinegar but changed to purple/pink in ammonia. Similarly, turmeric solution was yellow in vinegar but turned orange/red-brown in ammonia. Plum juice didn’t not show any change but plum skin extract did act as an indicator.";
        answer[4] = "Vinegar helps get rid of the white deposit i-e limescale or calciumcarbonate. Limescale can be dissolved fairly easily using a solution of a mild acid. The most commonly used is white vinegar.";
        answer[5] = "Ammonia itself obviously doesn't contain hydroxide ions, but it reacts with water to produce ammonium ions and hydroxide ions./nNH3(aq) + H2O(l)⇌NH + 4(aq) + OH−(aq)";

        GameObject go = GameObject.FindGameObjectWithTag("QuestionText");
        ques = go.GetComponent<Text>();
        ques.text = qs[current];

        go = GameObject.FindGameObjectWithTag("AnswerText");
        ans = go.GetComponent<Text>();

        go = GameObject.FindGameObjectWithTag("NextButton");
        next = go.GetComponent<Button>();
        
        go = GameObject.FindGameObjectWithTag("PrevButton");
        prev = go.GetComponent<Button>();
        prev.interactable = false;
        
        go = GameObject.FindGameObjectWithTag("ShowButton");
        show = go.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextQuestion()
    {
        if (current>=0 && current<=4)
        {
            current++;
            ques.text = qs[current];
            ans.text = "";
            show.interactable = true;
            prev.interactable = true;

            if (current == 5)
            {
                next.interactable = false;
            }
        }
        
    }

    public void PrevQuestion()
    {
        if (current>0 && current<=5)
        {
            current--;
            ques.text = qs[current];
            ans.text = "";
            show.interactable = true;
            next.interactable = true;

            if (current == 0)
            {
                prev.interactable = false;
            }
        }
    }

    public void ShowAnswer()
    {
        ans.text = "Ans) " + answer[current];
        show.interactable = false;
    }
}
