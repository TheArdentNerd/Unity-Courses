using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
   [TextArea(2,6)]
   // The attribute TextArea in our variable displays the minimum and maximum number 
   //of lines shown in the inspector
   [SerializeField] string question = "Enter new question text here";
   [SerializeField]string[] answers = new string[4];
   // So just like our question we are going to want to change htem in the inspector
   // but we dont want to be able to change them from outside the scriptable object

   [SerializeField] int correctAnswerIndex;

   public string GetQuestion()
   {
      return question;
   }
   public int GetCorrectAnswerIndex()
   {
      return correctAnswerIndex;
   }
   public string GetAnswer(int index)
   {
      return answers[index];
   }
   // We want GetAnswer to accept a parameter of type int called index
   // We want to return answers at the index that we specified
   //This method is passing in an index that we want to use and returning an answer at that given index
}
