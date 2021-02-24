using System;
using System.Collections.Generic;

namespace OOP_Lab2
{
    public interface IBaseInfo
    {
        int ID { get; set; }
        string Type { get; set; }
        string Model { get; set; }
        int YearOfIssue { get; set; }
        List<CrewMember> CrewMembers { get; set; }
        int NumberOfPassengers { get; set; }
        DateTime DateOfTheLatestMaintenance { get; set; }
    }
}
