using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommaderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command
                {
                    Id = 0,
                    HowTo = "Make cake",
                    Line = "Preheat and bake",
                    Platform = "Microwave"
                },
                new Command
                {
                    Id = 1,
                    HowTo = "Make Tea",
                    Line = "Boil water place tea bag",
                    Platform = "Kettle"
                },
                new Command
                {
                    Id = 2,
                    HowTo = "Eat cookies",
                    Line = "Buy from market",
                    Platform = "Store"
                }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{
                Id = 0,
                HowTo = "Make cake",
                Line = "Preheat and bake",
                Platform = "Microwave"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}