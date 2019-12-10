using CapStone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapStone.ViewModels.GameViewModel;

namespace CapStone.DAL
{
    public class SeedData : ObservableObject
    {
        public static List<Box> _boardSeed;
        public List<Box> BoardSeed
        {
            get { return _boardSeed; }
            set { 
                _boardSeed = value;
                OnPropertyChanged(nameof(BoardSeed));
            }
        }
        public static List<Box> GenerateBoxes()
        {
            List<Box> _boardseed = new List<Box>()
            {
                new Box()
                {
                    State = Box.BoxState.Empty,
                    Pos = 0
                },
                new Box()
                {
                    State = Box.BoxState.O,
                    Pos = 1
                },
                new Box()
                {
                    State = Box.BoxState.X,
                    Pos = 2
                },
                new Box()
                {
                    State = Box.BoxState.Empty,
                    Pos = 3
                },
                new Box()
                {
                    State = Box.BoxState.Empty,
                    Pos = 4
                },
                new Box()
                {
                    State = Box.BoxState.Empty,
                    Pos = 5
                },
                new Box()
                {
                    State = Box.BoxState.Empty,
                    Pos = 6
                },
                new Box()
                {
                    State = Box.BoxState.Empty,
                    Pos = 7
                },
                new Box()
                {
                    State = Box.BoxState.Empty,
                    Pos = 8
                },
                new Box()
                {
                    State = Box.BoxState.Empty,
                    Pos = 9
                },
                new Box()
                {
                    State = Box.BoxState.Empty,
                    Pos = 10
                },
                new Box()
                {
                    State = Box.BoxState.Empty,
                    Pos = 11
                },
                new Box()
                {
                    State = Box.BoxState.Empty,
                    Pos = 12
                },
                new Box()
                {
                    State = Box.BoxState.Empty,
                    Pos = 13
                },
                new Box()
                {
                    State = Box.BoxState.Empty,
                    Pos = 14
                },
                new Box()
                {
                    State = Box.BoxState.Empty,
                    Pos = 15
                }
            };
            return _boardSeed;
        }
    }
}
