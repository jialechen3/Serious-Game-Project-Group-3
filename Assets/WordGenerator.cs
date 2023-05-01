using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {

	private static string[] wordList = {   "Homelessness", "can", "be", "caused", "by", "Family", "violence",
"A", "shortage", "of", "affordable", "housing",
"Physical", "or", "mental", "health", "issues",
"Unemployment", "or", "job", "loss",
"Drug", "and", "alcohol", "abuse", "and", "addiction",
"Family", "and", "relationship", "breakdown",
"Not", "feeling", "safe", "at", "home"  };

	public static string GtRandomWord ()
	{
		int randomIndex = Random.Range(0, wordList.Length);
		string randomWord = wordList[randomIndex];

		return randomWord;
	}

	public static string GetNextWord (int index)
	{
		
		string randomWord = wordList[index];

		return randomWord;
	}

}
