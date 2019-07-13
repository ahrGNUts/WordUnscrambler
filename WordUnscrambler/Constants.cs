using System;

public class Constants
{
    public const string OptionsOnHowToEnterScrambledWords = "Please enter option - F for file or M for manual";
    public const string OptionsOnContinuingProgram = "Do you want to continue? [y/n]: ";

    public const string EnterScrambledWordsViaFile = "Enter the scrambled words filename: ";
    public const string EnterScrambledWordsManually = "Enter scrambled word(s) manually (separated by commas if multiple): ";
    public const string EnterScrambledWordsOptionNotRecognized = "Option not recognized";

    public const string ErrorScrambledWordsCannotBeLoaded = "Scrambled words not loaded because of an error. ";
    public const string ErrorProgramWillBeTerminated = "Program will now terminate.";

    public const string MatchFound = "MATCH FOUND FOR {0}: {1}";
    public const string MatchNotFound = "MATCH NOT FOUND";

    public const string Yes = "Y";
    public const string No = "N";
    public const string File = "F";
    public const string Manual = "M";

    public const string WordListFileName = "wordlist.txt";
}
