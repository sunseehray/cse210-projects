using System;

public class ChecklistGoal : Goal
{
    private int _checklistPoints;
    private int _checklistSteps;
    private int _checklistStepsCompleted;

    public override void CreateChildGoal()
    {
        // call the base method for creating a goal
        CreateBaseGoal();

        // get the number of steps to achieve the goal
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string stringChecklistSteps = Console.ReadLine();
        _checklistSteps = Convert.ToInt32(stringChecklistSteps);

    }

    // check if goal is complete
    public override bool IsComplete() 
    {
        if (_checklistStepsCompleted >= _checklistSteps) {
            _statusSymbol = "X";
            return true;
        } else {
            return false;
        }
    }
    
    public override void RecordEvent()
    {

    }

    public override void ListGoal()
    {
        Console.Write($"[{_statusSymbol}] {_name} ({_description}) -- Currently Completed {_checklistStepsCompleted}/{_checklistSteps}");
    }

}