using System;

public class ChecklistGoal : Goal
{
    private int _checklistPoints;
    private int _checklistSteps;
    private int _checlistStepsCompleted;

    public override void CreateGoal()
    {
        StartCreateGoal();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string stringChecklistSteps = Console.ReadLine();
        SetChecklistSteps(Convert.ToInt32(stringChecklistSteps));

    }
    public void SetChecklistSteps(int checklistSteps)
    {
        _checklistSteps = checklistSteps;
    }
    
    public override void RecordEvent()
    {

    }

}