
using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public int GetScore()
    {
        return _score;
    }

    public int GetGoalCount()
    {
        return _goals.Count;
    }

    public Goal GetGoal(int index)
    {
        return _goals[index];
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int RecordEvent(int index)
    {
        int points = _goals[index].RecordEvent();
        _score += points;
        return points;
    }

    public void ShowGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");
        }

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
        }
    }

    public int GetLevel()
    {
        return (_score / 500) + 1;
    }

    public void SaveGoals()
    {
        List<string> lines = new List<string>();

        lines.Add($"Score|{_score}");

        foreach (Goal goal in _goals)
        {
            lines.Add(goal.SaveData());
        }

        File.WriteAllLines("goals.txt", lines);
        Console.WriteLine("Goals saved!");
    }

    public void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved file was found.");
            return;
        }

        string[] lines = File.ReadAllLines("goals.txt");

        if (lines.Length == 0 || !lines[0].StartsWith("Score|"))
        {
            Console.WriteLine("The saved file is invalid.");
            return;
        }

        List<Goal> loadedGoals = new List<Goal>();
        int loadedScore;

        if (!int.TryParse(lines[0].Split('|')[1], out loadedScore))
        {
            Console.WriteLine("The saved score is invalid.");
            return;
        }

        try
        {
            for (int i = 1; i < lines.Length; i++)
            {
                string[] p = lines[i].Split('|');

                if (p[0] == "Simple" && p.Length == 5)
                {
                    loadedGoals.Add(new SimpleGoal(
                        p[1], p[2], int.Parse(p[3]), bool.Parse(p[4])));
                }
                else if (p[0] == "Eternal" && p.Length == 4)
                {
                    loadedGoals.Add(new EternalGoal(
                        p[1], p[2], int.Parse(p[3])));
                }
                else if (p[0] == "Checklist" && p.Length == 7)
                {
                    loadedGoals.Add(new ChecklistGoal(
                        p[1], p[2], int.Parse(p[3]),
                        int.Parse(p[4]), int.Parse(p[5]), int.Parse(p[6])));
                }
            }

            _goals = loadedGoals;
            _score = loadedScore;

            Console.WriteLine("Goals loaded!");
        }
        catch (FormatException)
        {
            Console.WriteLine("The saved file contains invalid data.");
        }
    }
}
