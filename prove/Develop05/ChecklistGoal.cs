using System;

public class ChecklistGoal : Goal
{
    private int _checklistPoints;
    private int _checklistSteps;
    private int _checlistStepsCompleted;

    public override void CreateChildGoal()
    {
        // call the base method for creating a goal
        CreateBaseGoal();

        // get the number of steps to achieve the goal
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string stringChecklistSteps = Console.ReadLine();
        _checklistSteps = Convert.ToInt32(stringChecklistSteps);

    }
    
    public override void RecordEvent()
    {

    }

}